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
            tbLeftFile = new TextBox();
            tbRightFile = new TextBox();
            imageList1 = new ImageList(components);
            tbLeftFolder = new TextBox();
            tbRightFolder = new TextBox();
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
            SuspendLayout();
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(98, 26);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(185, 23);
            btnLeft.TabIndex = 0;
            btnLeft.Text = "Open left";
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRight.Location = new Point(749, 26);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(197, 23);
            btnRight.TabIndex = 1;
            btnRight.Text = "Open right";
            btnRight.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            btnCompare.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCompare.Location = new Point(400, 26);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(245, 23);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.TextAlign = ContentAlignment.BottomCenter;
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // tbLeftFile
            // 
            tbLeftFile.Location = new Point(12, 79);
            tbLeftFile.Name = "tbLeftFile";
            tbLeftFile.Size = new Size(502, 23);
            tbLeftFile.TabIndex = 3;
            tbLeftFile.TextChanged += tbLeftFile_TextChanged;
            // 
            // tbRightFile
            // 
            tbRightFile.Location = new Point(520, 79);
            tbRightFile.Name = "tbRightFile";
            tbRightFile.Size = new Size(489, 23);
            tbRightFile.TabIndex = 4;
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
            // 
            // tbLeftFolder
            // 
            tbLeftFolder.Location = new Point(12, 129);
            tbLeftFolder.Name = "tbLeftFolder";
            tbLeftFolder.Size = new Size(502, 23);
            tbLeftFolder.TabIndex = 6;
            // 
            // tbRightFolder
            // 
            tbRightFolder.Location = new Point(520, 129);
            tbRightFolder.Name = "tbRightFolder";
            tbRightFolder.Size = new Size(489, 23);
            tbRightFolder.TabIndex = 7;
            // 
            // lvView
            // 
            lvView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvView.Columns.AddRange(new ColumnHeader[] { chFsType, chLeftState, chRightState, chName, chDSL, chDSR, chLS });
            lvView.FullRowSelect = true;
            lvView.Location = new Point(12, 195);
            lvView.Name = "lvView";
            lvView.Size = new Size(997, 475);
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
            chName.Width = 300;
            // 
            // chDSL
            // 
            chDSL.Text = "Physical size (left)";
            chDSL.TextAlign = HorizontalAlignment.Right;
            chDSL.Width = 150;
            // 
            // chDSR
            // 
            chDSR.Text = "Physical size (right)";
            chDSR.TextAlign = HorizontalAlignment.Right;
            chDSR.Width = 160;
            // 
            // chLS
            // 
            chLS.Text = "Logical size";
            chLS.TextAlign = HorizontalAlignment.Right;
            chLS.Width = 150;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 679);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 9;
            label1.Text = "Selected items:";
            // 
            // lbSelCount
            // 
            lbSelCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbSelCount.AutoSize = true;
            lbSelCount.Location = new Point(104, 679);
            lbSelCount.Name = "lbSelCount";
            lbSelCount.Size = new Size(12, 15);
            lbSelCount.TabIndex = 10;
            lbSelCount.Text = "-";
            // 
            // chSkipGoodFiles
            // 
            chSkipGoodFiles.AutoSize = true;
            chSkipGoodFiles.Location = new Point(12, 170);
            chSkipGoodFiles.Name = "chSkipGoodFiles";
            chSkipGoodFiles.Size = new Size(102, 19);
            chSkipGoodFiles.TabIndex = 11;
            chSkipGoodFiles.Text = "skip good files";
            chSkipGoodFiles.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 703);
            Controls.Add(chSkipGoodFiles);
            Controls.Add(lbSelCount);
            Controls.Add(label1);
            Controls.Add(lvView);
            Controls.Add(tbRightFolder);
            Controls.Add(tbLeftFolder);
            Controls.Add(tbRightFile);
            Controls.Add(tbLeftFile);
            Controls.Add(btnCompare);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "WDS Comparer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeft;
        private Button btnRight;
        private Button btnCompare;
        private TextBox tbLeftFile;
        private TextBox tbRightFile;
        private TextBox tbLeftFolder;
        private TextBox tbRightFolder;
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
    }
}
