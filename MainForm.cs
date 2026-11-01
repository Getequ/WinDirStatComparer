namespace WinDirStatComparer
{
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            tbLeftFile.Text = "C:\\share\\yd_report__work.json";
            tbRightFile.Text = "C:\\share\\yd_report__chuwi.json";

            tbLeftFolder.Text = "D:\\yd\\Yandex.Disk\\2017";
            tbRightFolder.Text = "C:\\Users\\Denis\\Yandex.Disk\\2017";
        }

        private void tbLeftFile_TextChanged(object sender, EventArgs e) {

        }

        private void btnCompare_Click(object sender, EventArgs e) {
            var leftTree = Comparer.LoadReport(tbLeftFile.Text, tbLeftFolder.Text);
            var rightTree = Comparer.LoadReport(tbRightFile.Text, tbRightFolder.Text);

            var compared = Comparer.CompareReports(leftTree.AllItems, rightTree.AllItems);

            FillView(compared.Tree);
        }

        private void FillView(CompareItem[] items) {
            lvView.Items.Clear();

            foreach (var item in items) {
                if (chSkipGoodFiles.Checked && !item.IsFolder && item.GoodSize) {
                    continue;
                }
                var lvItem = new ListViewItem();
                lvItem.ImageIndex = GetIconIndex(item);
                var leftState = lvItem.SubItems.Add("");
                var rightState = lvItem.SubItems.Add("");

                lvItem.SubItems.Add(item.Name);
                lvItem.SubItems.Add(item.Left != null ? FormatFileSize(item.Left.PhysicalSize) : "");
                lvItem.SubItems.Add(item.Right != null ? FormatFileSize(item.Right.PhysicalSize) : "");
                lvItem.SubItems.Add(FormatFileSize(Math.Max(item.Left?.LogicalSize ?? 0, item.Right?.LogicalSize ?? 0)));
                lvItem.Tag = item;
                lvView.Items.Add(lvItem);
            }
        }

        public static string FormatFileSize(long bytes) {
            return $"{bytes / 1024:N0} КБ";
        }

        private int GetIconIndex(CompareItem item) {
            if (item.IsFolder) {
                if (item.GoodSize)
                    return 0;
                else
                    return 1;
            }

            if (item.BothGoodSize)
                return 2;
            if (item.GoodSize)
                return 6;
            else
                return 3;
        }

        private void lvView_MouseDoubleClick(object sender, MouseEventArgs e) {
            var slvItem = lvView.SelectedItems[0];
            var idx = slvItem.Index;
            var citem = slvItem.Tag as CompareItem;

            var good = 0;
            var bad = 0;
            if (citem != null && citem.Children != null && citem.Children.Length > 0) {
                foreach (var item in citem.Children) {
                    if (chSkipGoodFiles.Checked && !item.IsFolder && item.BothGoodSize) {
                        good++;
                        continue;
                    }
                    if (chSkipLeftGood.Checked && !item.IsFolder && (item.Left?.GoodSize ?? false)) {
                        continue;
                    }
                    if (chSkipRightGood.Checked && !item.IsFolder && (item.Right?.GoodSize ?? false)) {
                        continue;
                    }

                    if (item.GoodSize)
                        good++;
                    else
                    if (!item.IsFolder)
                        bad++;

                    var lvItem = new ListViewItem();
                    lvItem.ImageIndex = GetIconIndex(item);

                    var leftState = lvItem.SubItems.Add("");
                    var rightState = lvItem.SubItems.Add("");

                    if (lvItem.ImageIndex == 6) {
                        lvItem.UseItemStyleForSubItems = false;
                        if (item.Left?.GoodSize ?? false) {
                            leftState.ForeColor = Color.Green;
                        }
                        else {
                            leftState.ForeColor = Color.Red;
                        }
                        if (item.Right?.GoodSize ?? false) {
                            rightState.ForeColor = Color.Green;
                        }
                        else {
                            rightState.ForeColor = Color.Red;
                        }
                        leftState.Text = "#";
                        rightState.Text = "#";
                    }

                    lvItem.SubItems.Add(item.Name);
                    lvItem.SubItems.Add(item.Left != null ? FormatFileSize(item.Left.PhysicalSize) : "");
                    lvItem.SubItems.Add(item.Right != null ? FormatFileSize(item.Right.PhysicalSize) : "");
                    lvItem.SubItems.Add(FormatFileSize(Math.Max(item.Left?.LogicalSize ?? 0, item.Right?.LogicalSize ?? 0)));
                    lvItem.Tag = item;
                    lvView.Items.Insert(++idx, lvItem);
                }
                slvItem.SubItems[3].Text = slvItem.SubItems[3].Text + $" good: {good}, bad: {bad}";
            }
        }

        private void lvView_SelectedIndexChanged(object sender, EventArgs e) {
            var items = new List<CompareItem>();

            foreach (ListViewItem item in lvView.SelectedItems) {
                items.Add(item.Tag as CompareItem);
            }

            lbSelCount.Text = items.Count.ToString() + "; Logical size: " + FormatFileSize(items.Sum(x => Math.Max(x.Left?.LogicalSize ?? 0, x.Right?.LogicalSize ?? 0)));
        }
    }
}
