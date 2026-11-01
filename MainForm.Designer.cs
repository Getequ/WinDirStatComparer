namespace WinDirStatComparer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnLeft = new Button();
            btnRight = new Button();
            btnCompare = new Button();
            imageList1 = new ImageList(components);
            lvView = new ListView();
            chFsType = new ColumnHeader();
            chLeftState = new ColumnHeader();
            chRightState = new ColumnHeader();
            chName = new ColumnHeader();
            chDSL = new ColumnHeader();
            chDSR = new ColumnHeader();
            chLS = new ColumnHeader();
            label1 = new Label();
            lbSelCount = new Label();
            chSkipGoodFiles = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbRightFolder = new TextBox();
            tbRightFile = new TextBox();
            tbLeftFile = new TextBox();
            tbLeftFolder = new TextBox();
            chSkipLeftGood = new CheckBox();
            chSkipRightGood = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(12, 26);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(185, 23);
            btnLeft.TabIndex = 0;
            btnLeft.Text = "Open left";
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRight.Location = new Point(502, 26);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(197, 23);
            btnRight.TabIndex = 1;
            btnRight.Text = "Open right";
            btnRight.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            btnCompare.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCompare.Location = new Point(203, 26);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(293, 23);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.TextAlign = ContentAlignment.BottomCenter;
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dirsuccess.bmp");
            imageList1.Images.SetKeyName(1, "direrror.bmp");
            imageList1.Images.SetKeyName(2, "success.bmp");
            imageList1.Images.SetKeyName(3, "error.bmp");
            imageList1.Images.SetKeyName(4, "left.bmp");
            imageList1.Images.SetKeyName(5, "right.bmp");
            imageList1.Images.SetKeyName(6, "question.bmp");
            // 
            // lvView
            // 
            lvView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvView.Columns.AddRange(new ColumnHeader[] { chFsType, chLeftState, chRightState, chName, chDSL, chDSR, chLS });
            lvView.FullRowSelect = true;
            lvView.Location = new Point(12, 161);
            lvView.Name = "lvView";
            lvView.Size = new Size(687, 560);
            lvView.SmallImageList = imageList1;
            lvView.TabIndex = 8;
            lvView.UseCompatibleStateImageBehavior = false;
            lvView.View = View.Details;
            lvView.SelectedIndexChanged += lvView_SelectedIndexChanged;
            lvView.MouseDoubleClick += lvView_MouseDoubleClick;
            // 
            // chFsType
            // 
            chFsType.Text = "";
            chFsType.Width = 24;
            // 
            // chLeftState
            // 
            chLeftState.Text = "";
            chLeftState.Width = 24;
            // 
            // chRightState
            // 
            chRightState.Text = "";
            chRightState.Width = 24;
            // 
            // chName
            // 
            chName.Text = "Name";
            chName.Width = 270;
            // 
            // chDSL
            // 
            chDSL.Text = "Physical size (left)";
            chDSL.TextAlign = HorizontalAlignment.Right;
            chDSL.Width = 110;
            // 
            // chDSR
            // 
            chDSR.Text = "Physical size (right)";
            chDSR.TextAlign = HorizontalAlignment.Right;
            chDSR.Width = 115;
            // 
            // chLS
            // 
            chLS.Text = "Logical size";
            chLS.TextAlign = HorizontalAlignment.Right;
            chLS.Width = 110;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 730);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 9;
            label1.Text = "Selected items:";
            // 
            // lbSelCount
            // 
            lbSelCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbSelCount.AutoSize = true;
            lbSelCount.Location = new Point(104, 730);
            lbSelCount.Name = "lbSelCount";
            lbSelCount.Size = new Size(12, 15);
            lbSelCount.TabIndex = 10;
            lbSelCount.Text = "-";
            // 
            // chSkipGoodFiles
            // 
            chSkipGoodFiles.AutoSize = true;
            chSkipGoodFiles.Checked = true;
            chSkipGoodFiles.CheckState = CheckState.Checked;
            chSkipGoodFiles.Location = new Point(12, 136);
            chSkipGoodFiles.Name = "chSkipGoodFiles";
            chSkipGoodFiles.Size = new Size(102, 19);
            chSkipGoodFiles.TabIndex = 11;
            chSkipGoodFiles.Text = "skip good files";
            chSkipGoodFiles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tbRightFolder, 1, 1);
            tableLayoutPanel1.Controls.Add(tbRightFile, 1, 0);
            tableLayoutPanel1.Controls.Add(tbLeftFile, 0, 0);
            tableLayoutPanel1.Controls.Add(tbLeftFolder, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(687, 63);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tbRightFolder
            // 
            tbRightFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRightFolder.Location = new Point(346, 34);
            tbRightFolder.Name = "tbRightFolder";
            tbRightFolder.Size = new Size(338, 23);
            tbRightFolder.TabIndex = 9;
            // 
            // tbRightFile
            // 
            tbRightFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRightFile.Location = new Point(346, 3);
            tbRightFile.Name = "tbRightFile";
            tbRightFile.Size = new Size(338, 23);
            tbRightFile.TabIndex = 8;
            // 
            // tbLeftFile
            // 
            tbLeftFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLeftFile.Location = new Point(3, 3);
            tbLeftFile.Name = "tbLeftFile";
            tbLeftFile.Size = new Size(337, 23);
            tbLeftFile.TabIndex = 4;
            // 
            // tbLeftFolder
            // 
            tbLeftFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLeftFolder.Location = new Point(3, 34);
            tbLeftFolder.Name = "tbLeftFolder";
            tbLeftFolder.Size = new Size(337, 23);
            tbLeftFolder.TabIndex = 7;
            // 
            // chSkipLeftGood
            // 
            chSkipLeftGood.AutoSize = true;
            chSkipLeftGood.Location = new Point(178, 136);
            chSkipLeftGood.Name = "chSkipLeftGood";
            chSkipLeftGood.Size = new Size(119, 19);
            chSkipLeftGood.TabIndex = 13;
            chSkipLeftGood.Text = "skip if left is good";
            chSkipLeftGood.UseVisualStyleBackColor = true;
            // 
            // chSkipRightGood
            // 
            chSkipRightGood.AutoSize = true;
            chSkipRightGood.Location = new Point(331, 136);
            chSkipRightGood.Name = "chSkipRightGood";
            chSkipRightGood.Size = new Size(127, 19);
            chSkipRightGood.TabIndex = 14;
            chSkipRightGood.Text = "skip if right is good";
            chSkipRightGood.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 754);
            Controls.Add(chSkipRightGood);
            Controls.Add(chSkipLeftGood);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(chSkipGoodFiles);
            Controls.Add(lbSelCount);
            Controls.Add(label1);
            Controls.Add(lvView);
            Controls.Add(btnCompare);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "WDS Comparer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeft;
        private Button btnRight;
        private Button btnCompare;
        private ImageList imageList1;
        private ListView lvView;
        private ColumnHeader chFsType;
        private ColumnHeader chLeftState;
        private ColumnHeader chRightState;
        private ColumnHeader chName;
        private ColumnHeader chDSL;
        private ColumnHeader chLS;
        private ColumnHeader chDSR;
        private Label label1;
        private Label lbSelCount;
        private CheckBox chSkipGoodFiles;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbRightFolder;
        private TextBox tbRightFile;
        private TextBox tbLeftFile;
        private TextBox tbLeftFolder;
        private CheckBox chSkipLeftGood;
        private CheckBox chSkipRightGood;
    }
}
