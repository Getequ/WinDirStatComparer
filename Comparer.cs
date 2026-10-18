using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinDirStatComparer;

internal class Comparer {
    public static (FsItem[] Tree, FsItem[] AllItems) LoadReport(string path, string folder) {
        var content = File.ReadAllText(path);
        var allItems = JsonSerializer.Deserialize<FsItem[]>(content);
        var roots = new List<FsItem>();
        var filtered = new List<FsItem>();
        var folders = new List<FsItem>();

        var idx = 0;
        var startIdx = folder.Length + 1;

        foreach (var item in allItems) {
            if (item.Name.Length < startIdx || !item.Name.StartsWith(folder + "\\")) continue;

            item._idx = idx++;
            item.Name = item.Name.Substring(startIdx);
            item.IsFolder = item.Files > 0 || item.Folders > 0 || item.WinDirStatAttributes == "0x20000004";
            if (!item.Name.Contains("\\")) {
                roots.Add(item);
            }
            filtered.Add(item);

            if (item.Files > 0 || item.Folders > 0)
                folders.Add(item);
        }

        foreach (var item in folders) {
            
            item.Children = filtered.Where((x, i) => 
                i >= item._idx &&
                x.Name.StartsWith(item.Name + "\\") &&
                x.Name.IndexOf('\\', item.Name.Length+1) == -1
            ).ToArray();
        }

        return (roots.ToArray(), filtered.ToArray());
    }

    public static (CompareItem[] Tree, CompareItem[] AllPairs) CompareReports(FsItem[] left, FsItem[] right) {
        var dLeft = left.ToDictionary(x => x.Name, x => x);
        var dRight = right.ToDictionary(x => x.Name, x => x);
        var roots = new List<CompareItem>();

        var compared = left.FullOuterJoin<FsItem, FsItem, string, CompareItem>(right, l => l.Name, r => r.Name, 
                (l, r, key) => new CompareItem {
                    Name = key,
                    Left = l,
                    Right = r
                })
                .ToArray();

        var idx = 0;
        foreach (var item in compared) {
            if (!item.Name.Contains("\\"))
                roots.Add(item);

            idx++;
            if (item.Left == null || item.Right == null) continue;

            if (!item.Left.IsFolder) continue;

            item.Children = compared.Where(x =>
                x.Name.StartsWith(item.Name + "\\") && 
                !x.Name.Substring(item.Name.Length + 1).Contains("\\")
            ).ToArray();
        }

        return (roots.ToArray(), compared);
    }
}

public class FsItem {
    public string Name { get; set; }
    public bool IsFolder { get; set; }
    public int Files { get; set; }
    public int Folders { get; set; }
    [JsonPropertyName("Logical Size")]
    public long LogicalSize { get; set; }
    [JsonPropertyName("Physical Size")]
    public long PhysicalSize { get; set; }
    [JsonPropertyName("WinDirStat Attributes")]
    public string WinDirStatAttributes { get; set; }
    public FsItem[] Children { get; set; }
    public int _idx { get; set; }

    public bool GoodSize => PhysicalSize == LogicalSize || (PhysicalSize > LogicalSize && PhysicalSize - LogicalSize < 4096);
    public override bool Equals(object? obj) {
        return obj is FsItem fsi && fsi.Name == Name && fsi.LogicalSize == LogicalSize && fsi.PhysicalSize == PhysicalSize;
    }
}

public class CompareItem {
    public string Name { get; set; }
    public FsItem Left { get; set; }
    public FsItem Right { get; set; }
    public CompareItem[] Children { get; set; }
    public bool FilesEqual => Left.Equals(Right);
    public bool GoodSize => ((Left != null && Right != null && Left.LogicalSize == Right.LogicalSize) || Left == null || Right == null) && ((Left?.GoodSize ?? false) || (Right?.GoodSize ?? false));
}

internal static class MyExtensions {
    internal static IEnumerable<TResult> FullOuterGroupJoin<TA, TB, TKey, TResult>(
        this IEnumerable<TA> a,
        IEnumerable<TB> b,
        Func<TA, TKey> selectKeyA,
        Func<TB, TKey> selectKeyB,
        Func<IEnumerable<TA>, IEnumerable<TB>, TKey, TResult> projection,
        IEqualityComparer<TKey> cmp = null) {
        cmp = cmp ?? EqualityComparer<TKey>.Default;
        var alookup = a.ToLookup(selectKeyA, cmp);
        var blookup = b.ToLookup(selectKeyB, cmp);

        var keys = new HashSet<TKey>(alookup.Select(p => p.Key), cmp);
        keys.UnionWith(blookup.Select(p => p.Key));

        var join = from key in keys
                   let xa = alookup[key]
                   let xb = blookup[key]
                   select projection(xa, xb, key);

        return join;
    }

    internal static IEnumerable<TResult> FullOuterJoin<TA, TB, TKey, TResult>(
        this IEnumerable<TA> a,
        IEnumerable<TB> b,
        Func<TA, TKey> selectKeyA,
        Func<TB, TKey> selectKeyB,
        Func<TA, TB, TKey, TResult> projection,
        TA defaultA = default(TA),
        TB defaultB = default(TB),
        IEqualityComparer<TKey> cmp = null) {
        cmp = cmp ?? EqualityComparer<TKey>.Default;
        var alookup = a.ToLookup(selectKeyA, cmp);
        var blookup = b.ToLookup(selectKeyB, cmp);

        var keys = new HashSet<TKey>(alookup.Select(p => p.Key), cmp);
        keys.UnionWith(blookup.Select(p => p.Key));

        var join = from key in keys
                   from xa in alookup[key].DefaultIfEmpty(defaultA)
                   from xb in blookup[key].DefaultIfEmpty(defaultB)
                   select projection(xa, xb, key);

        return join;
    }
}