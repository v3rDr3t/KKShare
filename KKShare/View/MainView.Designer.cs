namespace KKShare
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.peersGroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshPeersButton = new System.Windows.Forms.Button();
            this.addPeerButton = new System.Windows.Forms.Button();
            this.RemovePeerButton = new System.Windows.Forms.Button();
            this.peersTabs = new System.Windows.Forms.TabControl();
            this.lanTabPage = new System.Windows.Forms.TabPage();
            this.internetTabPage = new System.Windows.Forms.TabPage();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.browseTabPage = new System.Windows.Forms.TabPage();
            this.downloadTabPage = new System.Windows.Forms.TabPage();
            this.downloadsTreeListView = new BrightIdeasSoftware.TreeListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.uploadTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.uploadsTreeListView = new BrightIdeasSoftware.TreeListView();
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.portLabel = new System.Windows.Forms.Label();
            this.networkGroupBox = new System.Windows.Forms.GroupBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sharedGroupBox = new System.Windows.Forms.GroupBox();
            this.sharedDataListView = new BrightIdeasSoftware.DataListView();
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.addSharedButton = new System.Windows.Forms.Button();
            this.removeSharedButton = new System.Windows.Forms.Button();
            this.logFastObjectListView = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.internetDataListView = new BrightIdeasSoftware.DataListView();
            this.lanDataListView = new BrightIdeasSoftware.DataListView();
            this.browseFolderDataTreeListView = new BrightIdeasSoftware.DataTreeListView();
            this.browseFilesDataListView = new BrightIdeasSoftware.DataListView();
            this.peersGroupBox.SuspendLayout();
            this.peersTabs.SuspendLayout();
            this.lanTabPage.SuspendLayout();
            this.internetTabPage.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.browseTabPage.SuspendLayout();
            this.downloadTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadsTreeListView)).BeginInit();
            this.uploadTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadsTreeListView)).BeginInit();
            this.networkGroupBox.SuspendLayout();
            this.sharedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logFastObjectListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseFolderDataTreeListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseFilesDataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // peersGroupBox
            // 
            this.peersGroupBox.Controls.Add(this.addPeerButton);
            this.peersGroupBox.Controls.Add(this.RemovePeerButton);
            this.peersGroupBox.Controls.Add(this.RefreshPeersButton);
            this.peersGroupBox.Controls.Add(this.peersTabs);
            this.peersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.peersGroupBox.Name = "peersGroupBox";
            this.peersGroupBox.Size = new System.Drawing.Size(200, 363);
            this.peersGroupBox.TabIndex = 0;
            this.peersGroupBox.TabStop = false;
            this.peersGroupBox.Text = "Peers";
            // 
            // RefreshPeersButton
            // 
            this.RefreshPeersButton.Location = new System.Drawing.Point(68, 334);
            this.RefreshPeersButton.Name = "RefreshPeersButton";
            this.RefreshPeersButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshPeersButton.TabIndex = 3;
            this.RefreshPeersButton.Text = "R";
            this.RefreshPeersButton.UseVisualStyleBackColor = true;
            // 
            // addPeerButton
            // 
            this.addPeerButton.Location = new System.Drawing.Point(10, 334);
            this.addPeerButton.Name = "addPeerButton";
            this.addPeerButton.Size = new System.Drawing.Size(23, 23);
            this.addPeerButton.TabIndex = 1;
            this.addPeerButton.Text = "+";
            this.addPeerButton.UseVisualStyleBackColor = true;
            // 
            // RemovePeerButton
            // 
            this.RemovePeerButton.Location = new System.Drawing.Point(39, 334);
            this.RemovePeerButton.Name = "RemovePeerButton";
            this.RemovePeerButton.Size = new System.Drawing.Size(23, 23);
            this.RemovePeerButton.TabIndex = 2;
            this.RemovePeerButton.Text = "-";
            this.RemovePeerButton.UseVisualStyleBackColor = true;
            // 
            // peersTabs
            // 
            this.peersTabs.Controls.Add(this.lanTabPage);
            this.peersTabs.Controls.Add(this.internetTabPage);
            this.peersTabs.Location = new System.Drawing.Point(6, 19);
            this.peersTabs.Name = "peersTabs";
            this.peersTabs.SelectedIndex = 0;
            this.peersTabs.Size = new System.Drawing.Size(188, 309);
            this.peersTabs.TabIndex = 1;
            // 
            // lanTabPage
            // 
            this.lanTabPage.Controls.Add(this.lanDataListView);
            this.lanTabPage.Location = new System.Drawing.Point(4, 22);
            this.lanTabPage.Name = "lanTabPage";
            this.lanTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lanTabPage.Size = new System.Drawing.Size(180, 283);
            this.lanTabPage.TabIndex = 0;
            this.lanTabPage.Text = "LAN";
            this.lanTabPage.UseVisualStyleBackColor = true;
            // 
            // internetTabPage
            // 
            this.internetTabPage.Controls.Add(this.internetDataListView);
            this.internetTabPage.Location = new System.Drawing.Point(4, 22);
            this.internetTabPage.Name = "internetTabPage";
            this.internetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.internetTabPage.Size = new System.Drawing.Size(180, 283);
            this.internetTabPage.TabIndex = 1;
            this.internetTabPage.Text = "Internet";
            this.internetTabPage.UseVisualStyleBackColor = true;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logFastObjectListView);
            this.logGroupBox.Location = new System.Drawing.Point(12, 381);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(760, 168);
            this.logGroupBox.TabIndex = 2;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.browseTabPage);
            this.mainTabs.Controls.Add(this.downloadTabPage);
            this.mainTabs.Controls.Add(this.uploadTabPage);
            this.mainTabs.Controls.Add(this.settingsTabPage);
            this.mainTabs.Location = new System.Drawing.Point(219, 18);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(553, 357);
            this.mainTabs.TabIndex = 3;
            // 
            // browseTabPage
            // 
            this.browseTabPage.Controls.Add(this.browseFilesDataListView);
            this.browseTabPage.Controls.Add(this.browseFolderDataTreeListView);
            this.browseTabPage.Location = new System.Drawing.Point(4, 22);
            this.browseTabPage.Name = "browseTabPage";
            this.browseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.browseTabPage.Size = new System.Drawing.Size(545, 331);
            this.browseTabPage.TabIndex = 0;
            this.browseTabPage.Text = "Browse";
            this.browseTabPage.UseVisualStyleBackColor = true;
            // 
            // downloadTabPage
            // 
            this.downloadTabPage.Controls.Add(this.downloadsTreeListView);
            this.downloadTabPage.Location = new System.Drawing.Point(4, 22);
            this.downloadTabPage.Name = "downloadTabPage";
            this.downloadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.downloadTabPage.Size = new System.Drawing.Size(545, 331);
            this.downloadTabPage.TabIndex = 1;
            this.downloadTabPage.Text = "Downloads";
            this.downloadTabPage.UseVisualStyleBackColor = true;
            // 
            // downloadsTreeListView
            // 
            this.downloadsTreeListView.AllColumns.Add(this.olvColumn1);
            this.downloadsTreeListView.AllColumns.Add(this.olvColumn2);
            this.downloadsTreeListView.AllColumns.Add(this.olvColumn3);
            this.downloadsTreeListView.CellEditUseWholeCell = false;
            this.downloadsTreeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.downloadsTreeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.downloadsTreeListView.FullRowSelect = true;
            this.downloadsTreeListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.downloadsTreeListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.downloadsTreeListView.Location = new System.Drawing.Point(6, 6);
            this.downloadsTreeListView.Name = "downloadsTreeListView";
            this.downloadsTreeListView.ShowGroups = false;
            this.downloadsTreeListView.Size = new System.Drawing.Size(533, 319);
            this.downloadsTreeListView.TabIndex = 0;
            this.downloadsTreeListView.UseCompatibleStateImageBehavior = false;
            this.downloadsTreeListView.View = System.Windows.Forms.View.Details;
            this.downloadsTreeListView.VirtualMode = true;
            // 
            // olvColumn1
            // 
            this.olvColumn1.Text = "Files";
            this.olvColumn1.Width = 369;
            // 
            // olvColumn2
            // 
            this.olvColumn2.Text = "Size";
            // 
            // olvColumn3
            // 
            this.olvColumn3.Text = "Progress";
            this.olvColumn3.Width = 100;
            // 
            // uploadTabPage
            // 
            this.uploadTabPage.Controls.Add(this.uploadsTreeListView);
            this.uploadTabPage.Location = new System.Drawing.Point(4, 22);
            this.uploadTabPage.Name = "uploadTabPage";
            this.uploadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.uploadTabPage.Size = new System.Drawing.Size(545, 331);
            this.uploadTabPage.TabIndex = 2;
            this.uploadTabPage.Text = "Uploads";
            this.uploadTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.sharedGroupBox);
            this.settingsTabPage.Controls.Add(this.networkGroupBox);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(545, 331);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // uploadsTreeListView
            // 
            this.uploadsTreeListView.AllColumns.Add(this.olvColumn4);
            this.uploadsTreeListView.AllColumns.Add(this.olvColumn5);
            this.uploadsTreeListView.AllColumns.Add(this.olvColumn6);
            this.uploadsTreeListView.CellEditUseWholeCell = false;
            this.uploadsTreeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.uploadsTreeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.uploadsTreeListView.FullRowSelect = true;
            this.uploadsTreeListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.uploadsTreeListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.uploadsTreeListView.Location = new System.Drawing.Point(6, 6);
            this.uploadsTreeListView.Name = "uploadsTreeListView";
            this.uploadsTreeListView.ShowGroups = false;
            this.uploadsTreeListView.Size = new System.Drawing.Size(533, 319);
            this.uploadsTreeListView.TabIndex = 1;
            this.uploadsTreeListView.UseCompatibleStateImageBehavior = false;
            this.uploadsTreeListView.View = System.Windows.Forms.View.Details;
            this.uploadsTreeListView.VirtualMode = true;
            // 
            // olvColumn4
            // 
            this.olvColumn4.Text = "Files";
            this.olvColumn4.Width = 369;
            // 
            // olvColumn5
            // 
            this.olvColumn5.Text = "Size";
            // 
            // olvColumn6
            // 
            this.olvColumn6.Text = "Progress";
            this.olvColumn6.Width = 100;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(6, 22);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port:";
            // 
            // networkGroupBox
            // 
            this.networkGroupBox.Controls.Add(this.portLabel);
            this.networkGroupBox.Controls.Add(this.portTextBox);
            this.networkGroupBox.Controls.Add(this.nameLabel);
            this.networkGroupBox.Controls.Add(this.nameTextBox);
            this.networkGroupBox.Location = new System.Drawing.Point(6, 6);
            this.networkGroupBox.Name = "networkGroupBox";
            this.networkGroupBox.Size = new System.Drawing.Size(210, 319);
            this.networkGroupBox.TabIndex = 2;
            this.networkGroupBox.TabStop = false;
            this.networkGroupBox.Text = "Network";
            // 
            // portTextBox
            // 
            this.portTextBox.Enabled = false;
            this.portTextBox.Location = new System.Drawing.Point(62, 19);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(142, 20);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.Text = "51010";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(62, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "...";
            // 
            // sharedGroupBox
            // 
            this.sharedGroupBox.Controls.Add(this.removeSharedButton);
            this.sharedGroupBox.Controls.Add(this.addSharedButton);
            this.sharedGroupBox.Controls.Add(this.sharedDataListView);
            this.sharedGroupBox.Location = new System.Drawing.Point(223, 6);
            this.sharedGroupBox.Name = "sharedGroupBox";
            this.sharedGroupBox.Size = new System.Drawing.Size(316, 319);
            this.sharedGroupBox.TabIndex = 3;
            this.sharedGroupBox.TabStop = false;
            this.sharedGroupBox.Text = "Shared Folders";
            // 
            // sharedDataListView
            // 
            this.sharedDataListView.AllColumns.Add(this.olvColumn10);
            this.sharedDataListView.AllColumns.Add(this.olvColumn11);
            this.sharedDataListView.CellEditUseWholeCell = false;
            this.sharedDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn10,
            this.olvColumn11});
            this.sharedDataListView.DataSource = null;
            this.sharedDataListView.FullRowSelect = true;
            this.sharedDataListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.sharedDataListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.sharedDataListView.Location = new System.Drawing.Point(6, 19);
            this.sharedDataListView.Name = "sharedDataListView";
            this.sharedDataListView.Size = new System.Drawing.Size(304, 264);
            this.sharedDataListView.TabIndex = 0;
            this.sharedDataListView.UseCompatibleStateImageBehavior = false;
            this.sharedDataListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn10
            // 
            this.olvColumn10.Text = "Folder";
            this.olvColumn10.Width = 240;
            // 
            // olvColumn11
            // 
            this.olvColumn11.Text = "Files";
            // 
            // addSharedButton
            // 
            this.addSharedButton.Location = new System.Drawing.Point(6, 289);
            this.addSharedButton.Name = "addSharedButton";
            this.addSharedButton.Size = new System.Drawing.Size(23, 23);
            this.addSharedButton.TabIndex = 1;
            this.addSharedButton.Text = "+";
            this.addSharedButton.UseVisualStyleBackColor = true;
            // 
            // removeSharedButton
            // 
            this.removeSharedButton.Location = new System.Drawing.Point(35, 289);
            this.removeSharedButton.Name = "removeSharedButton";
            this.removeSharedButton.Size = new System.Drawing.Size(23, 23);
            this.removeSharedButton.TabIndex = 2;
            this.removeSharedButton.Text = "-";
            this.removeSharedButton.UseVisualStyleBackColor = true;
            // 
            // logFastObjectListView
            // 
            this.logFastObjectListView.AllColumns.Add(this.olvColumn7);
            this.logFastObjectListView.AllColumns.Add(this.olvColumn8);
            this.logFastObjectListView.AllColumns.Add(this.olvColumn9);
            this.logFastObjectListView.CellEditUseWholeCell = false;
            this.logFastObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn9});
            this.logFastObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.logFastObjectListView.FullRowSelect = true;
            this.logFastObjectListView.GridLines = true;
            this.logFastObjectListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.logFastObjectListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.logFastObjectListView.Location = new System.Drawing.Point(6, 20);
            this.logFastObjectListView.Name = "logFastObjectListView";
            this.logFastObjectListView.ShowGroups = false;
            this.logFastObjectListView.Size = new System.Drawing.Size(748, 142);
            this.logFastObjectListView.TabIndex = 0;
            this.logFastObjectListView.UseCompatibleStateImageBehavior = false;
            this.logFastObjectListView.View = System.Windows.Forms.View.Details;
            this.logFastObjectListView.VirtualMode = true;
            // 
            // olvColumn7
            // 
            this.olvColumn7.Text = "Time";
            this.olvColumn7.Width = 100;
            // 
            // olvColumn8
            // 
            this.olvColumn8.Text = "Severity";
            // 
            // olvColumn9
            // 
            this.olvColumn9.Text = "Description";
            this.olvColumn9.Width = 584;
            // 
            // internetDataListView
            // 
            this.internetDataListView.CellEditUseWholeCell = false;
            this.internetDataListView.DataSource = null;
            this.internetDataListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.internetDataListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.internetDataListView.Location = new System.Drawing.Point(6, 6);
            this.internetDataListView.Name = "internetDataListView";
            this.internetDataListView.Size = new System.Drawing.Size(168, 271);
            this.internetDataListView.TabIndex = 0;
            this.internetDataListView.UseCompatibleStateImageBehavior = false;
            this.internetDataListView.View = System.Windows.Forms.View.Details;
            // 
            // lanDataListView
            // 
            this.lanDataListView.CellEditUseWholeCell = false;
            this.lanDataListView.DataSource = null;
            this.lanDataListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.lanDataListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.lanDataListView.Location = new System.Drawing.Point(6, 6);
            this.lanDataListView.Name = "lanDataListView";
            this.lanDataListView.Size = new System.Drawing.Size(168, 271);
            this.lanDataListView.TabIndex = 1;
            this.lanDataListView.UseCompatibleStateImageBehavior = false;
            this.lanDataListView.View = System.Windows.Forms.View.Details;
            // 
            // browseFolderDataTreeListView
            // 
            this.browseFolderDataTreeListView.CellEditUseWholeCell = false;
            this.browseFolderDataTreeListView.DataSource = null;
            this.browseFolderDataTreeListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.browseFolderDataTreeListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.browseFolderDataTreeListView.Location = new System.Drawing.Point(6, 6);
            this.browseFolderDataTreeListView.Name = "browseFolderDataTreeListView";
            this.browseFolderDataTreeListView.RootKeyValueString = "";
            this.browseFolderDataTreeListView.ShowGroups = false;
            this.browseFolderDataTreeListView.Size = new System.Drawing.Size(185, 319);
            this.browseFolderDataTreeListView.TabIndex = 0;
            this.browseFolderDataTreeListView.UseCompatibleStateImageBehavior = false;
            this.browseFolderDataTreeListView.View = System.Windows.Forms.View.Details;
            this.browseFolderDataTreeListView.VirtualMode = true;
            // 
            // browseFilesDataListView
            // 
            this.browseFilesDataListView.CellEditUseWholeCell = false;
            this.browseFilesDataListView.DataSource = null;
            this.browseFilesDataListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.browseFilesDataListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.browseFilesDataListView.Location = new System.Drawing.Point(198, 6);
            this.browseFilesDataListView.Name = "browseFilesDataListView";
            this.browseFilesDataListView.Size = new System.Drawing.Size(341, 319);
            this.browseFilesDataListView.TabIndex = 1;
            this.browseFilesDataListView.UseCompatibleStateImageBehavior = false;
            this.browseFilesDataListView.View = System.Windows.Forms.View.Details;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.peersGroupBox);
            this.Name = "MainView";
            this.Text = "KKShare v0.1";
            this.peersGroupBox.ResumeLayout(false);
            this.peersTabs.ResumeLayout(false);
            this.lanTabPage.ResumeLayout(false);
            this.internetTabPage.ResumeLayout(false);
            this.logGroupBox.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.browseTabPage.ResumeLayout(false);
            this.downloadTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadsTreeListView)).EndInit();
            this.uploadTabPage.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadsTreeListView)).EndInit();
            this.networkGroupBox.ResumeLayout(false);
            this.networkGroupBox.PerformLayout();
            this.sharedGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logFastObjectListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseFolderDataTreeListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseFilesDataListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox peersGroupBox;
        private System.Windows.Forms.Button RefreshPeersButton;
        private System.Windows.Forms.Button addPeerButton;
        private System.Windows.Forms.Button RemovePeerButton;
        private System.Windows.Forms.TabControl peersTabs;
        private System.Windows.Forms.TabPage lanTabPage;
        private System.Windows.Forms.TabPage internetTabPage;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage browseTabPage;
        private System.Windows.Forms.TabPage downloadTabPage;
        private System.Windows.Forms.TabPage uploadTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private BrightIdeasSoftware.TreeListView downloadsTreeListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.TreeListView uploadsTreeListView;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.DataListView lanDataListView;
        private BrightIdeasSoftware.DataListView internetDataListView;
        private BrightIdeasSoftware.FastObjectListView logFastObjectListView;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private System.Windows.Forms.GroupBox sharedGroupBox;
        private System.Windows.Forms.Button removeSharedButton;
        private System.Windows.Forms.Button addSharedButton;
        private BrightIdeasSoftware.DataListView sharedDataListView;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private System.Windows.Forms.GroupBox networkGroupBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private BrightIdeasSoftware.DataListView browseFilesDataListView;
        private BrightIdeasSoftware.DataTreeListView browseFolderDataTreeListView;
    }
}

