namespace KKShare.View
{
    partial class DirectoryCheckView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.problemsFOLV = new BrightIdeasSoftware.FastObjectListView();
            this.problemOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dirOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.parentPathOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.infoLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelAbortBtn = new System.Windows.Forms.Button();
            this.checkingWorker = new System.ComponentModel.BackgroundWorker();
            this.imagePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.problemsFOLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // problemsFOLV
            // 
            this.problemsFOLV.AllColumns.Add(this.problemOLVCol);
            this.problemsFOLV.AllColumns.Add(this.dirOLVCol);
            this.problemsFOLV.AllColumns.Add(this.parentPathOLVCol);
            this.problemsFOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.problemsFOLV.CellEditUseWholeCell = false;
            this.problemsFOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.problemOLVCol,
            this.dirOLVCol});
            this.problemsFOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.problemsFOLV.FullRowSelect = true;
            this.problemsFOLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.problemsFOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.problemsFOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.problemsFOLV.Location = new System.Drawing.Point(12, 64);
            this.problemsFOLV.Name = "problemsFOLV";
            this.problemsFOLV.SelectColumnsMenuStaysOpen = false;
            this.problemsFOLV.SelectColumnsOnRightClick = false;
            this.problemsFOLV.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.problemsFOLV.ShowFilterMenuOnRightClick = false;
            this.problemsFOLV.ShowGroups = false;
            this.problemsFOLV.ShowItemCountOnGroups = true;
            this.problemsFOLV.Size = new System.Drawing.Size(325, 109);
            this.problemsFOLV.TabIndex = 0;
            this.problemsFOLV.UseCompatibleStateImageBehavior = false;
            this.problemsFOLV.View = System.Windows.Forms.View.Details;
            this.problemsFOLV.VirtualMode = true;
            // 
            // problemOLVCol
            // 
            this.problemOLVCol.AspectName = "Text";
            this.problemOLVCol.Groupable = false;
            this.problemOLVCol.IsEditable = false;
            this.problemOLVCol.Text = "Problem";
            this.problemOLVCol.Width = 160;
            // 
            // dirOLVCol
            // 
            this.dirOLVCol.AspectName = "DirPath";
            this.dirOLVCol.FillsFreeSpace = true;
            this.dirOLVCol.Groupable = false;
            this.dirOLVCol.IsEditable = false;
            this.dirOLVCol.Text = "Directory";
            // 
            // parentPathOLVCol
            // 
            this.parentPathOLVCol.AspectName = "ParentPath";
            this.parentPathOLVCol.DisplayIndex = 1;
            this.parentPathOLVCol.Groupable = false;
            this.parentPathOLVCol.IsEditable = false;
            this.parentPathOLVCol.IsVisible = false;
            this.parentPathOLVCol.Text = "Parent";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabel.Location = new System.Drawing.Point(65, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(272, 41);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Checking directory...";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okBtn.Enabled = false;
            this.okBtn.Location = new System.Drawing.Point(88, 186);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.onOkClick);
            // 
            // cancelAbortBtn
            // 
            this.cancelAbortBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelAbortBtn.Location = new System.Drawing.Point(186, 186);
            this.cancelAbortBtn.Name = "cancelAbortBtn";
            this.cancelAbortBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelAbortBtn.TabIndex = 4;
            this.cancelAbortBtn.Text = "Cancel";
            this.cancelAbortBtn.UseVisualStyleBackColor = true;
            this.cancelAbortBtn.Click += new System.EventHandler(this.onCancelClick);
            // 
            // checkingWorker
            // 
            this.checkingWorker.WorkerReportsProgress = true;
            this.checkingWorker.WorkerSupportsCancellation = true;
            this.checkingWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkingWorker_Work);
            this.checkingWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.checkingWorker_Progress);
            this.checkingWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkingWorker_Completed);
            // 
            // imagePicBox
            // 
            this.imagePicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imagePicBox.Image = global::KKShare.Properties.Resources.fileCheck_preloader;
            this.imagePicBox.Location = new System.Drawing.Point(22, 12);
            this.imagePicBox.Name = "imagePicBox";
            this.imagePicBox.Size = new System.Drawing.Size(32, 32);
            this.imagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagePicBox.TabIndex = 1;
            this.imagePicBox.TabStop = false;
            // 
            // DirectoryCheckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 221);
            this.Controls.Add(this.imagePicBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelAbortBtn);
            this.Controls.Add(this.problemsFOLV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectoryCheckView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shared Folder Check";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.problemsFOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView problemsFOLV;
        private BrightIdeasSoftware.OLVColumn problemOLVCol;
        private System.Windows.Forms.PictureBox imagePicBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelAbortBtn;
        private System.ComponentModel.BackgroundWorker checkingWorker;
        private BrightIdeasSoftware.OLVColumn parentPathOLVCol;
        private BrightIdeasSoftware.OLVColumn dirOLVCol;
    }
}