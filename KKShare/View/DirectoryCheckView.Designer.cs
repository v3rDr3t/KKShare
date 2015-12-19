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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryCheckView));
            this.problemsFOLV = new BrightIdeasSoftware.FastObjectListView();
            this.problemsOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.problemsFOLV.AllColumns.Add(this.problemsOLVCol);
            this.problemsFOLV.CellEditUseWholeCell = false;
            this.problemsFOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.problemsOLVCol});
            this.problemsFOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.problemsFOLV.FullRowSelect = true;
            this.problemsFOLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.problemsFOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.problemsFOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.problemsFOLV.Location = new System.Drawing.Point(12, 64);
            this.problemsFOLV.Name = "problemsFOLV";
            this.problemsFOLV.ShowGroups = false;
            this.problemsFOLV.Size = new System.Drawing.Size(325, 109);
            this.problemsFOLV.TabIndex = 0;
            this.problemsFOLV.UseCompatibleStateImageBehavior = false;
            this.problemsFOLV.View = System.Windows.Forms.View.Details;
            this.problemsFOLV.VirtualMode = true;
            // 
            // problemsOLVCol
            // 
            this.problemsOLVCol.AspectName = "Text";
            this.problemsOLVCol.FillsFreeSpace = true;
            this.problemsOLVCol.Groupable = false;
            this.problemsOLVCol.IsEditable = false;
            this.problemsOLVCol.Text = "Problems";
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(65, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(272, 41);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Checking directory...";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okBtn
            // 
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
            this.imagePicBox.Image = ((System.Drawing.Image)(resources.GetObject("imagePicBox.Image")));
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
            this.Text = "Directory Check";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.problemsFOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView problemsFOLV;
        private BrightIdeasSoftware.OLVColumn problemsOLVCol;
        private System.Windows.Forms.PictureBox imagePicBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelAbortBtn;
        private System.ComponentModel.BackgroundWorker checkingWorker;
    }
}