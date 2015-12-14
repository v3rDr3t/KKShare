using System;

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
            this.editPeersButton = new System.Windows.Forms.Button();
            this.addPeerButton = new System.Windows.Forms.Button();
            this.RemovePeerButton = new System.Windows.Forms.Button();
            this.refreshPeersButton = new System.Windows.Forms.Button();
            this.peersTabs = new System.Windows.Forms.TabControl();
            this.lanTabPage = new System.Windows.Forms.TabPage();
            this.lanDataListView = new BrightIdeasSoftware.DataListView();
            this.internetTabPage = new System.Windows.Forms.TabPage();
            this.internetDataListView = new BrightIdeasSoftware.DataListView();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logFastObjectListView = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.browseTabPage = new System.Windows.Forms.TabPage();
            this.browseFilesDataListView = new BrightIdeasSoftware.DataListView();
            this.browseFolderDataTreeListView = new BrightIdeasSoftware.DataTreeListView();
            this.shareTabPage = new System.Windows.Forms.TabPage();
            this.sharedDataListView = new BrightIdeasSoftware.DataListView();
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.editSharedButton = new System.Windows.Forms.Button();
            this.addSharedButton = new System.Windows.Forms.Button();
            this.removeSharedButton = new System.Windows.Forms.Button();
            this.downloadTabPage = new System.Windows.Forms.TabPage();
            this.downloadsTreeListView = new BrightIdeasSoftware.TreeListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.uploadTabPage = new System.Windows.Forms.TabPage();
            this.uploadsTreeListView = new BrightIdeasSoftware.TreeListView();
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.downloadsGroupBox = new System.Windows.Forms.GroupBox();
            this.downloadsTextBox = new System.Windows.Forms.TextBox();
            this.browseDownloadsButton = new System.Windows.Forms.Button();
            this.netGroupBox = new System.Windows.Forms.GroupBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inputErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.peersGroupBox.SuspendLayout();
            this.peersTabs.SuspendLayout();
            this.lanTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lanDataListView)).BeginInit();
            this.internetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetDataListView)).BeginInit();
            this.logGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logFastObjectListView)).BeginInit();
            this.mainTabs.SuspendLayout();
            this.browseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browseFilesDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseFolderDataTreeListView)).BeginInit();
            this.shareTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataListView)).BeginInit();
            this.downloadTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadsTreeListView)).BeginInit();
            this.uploadTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadsTreeListView)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            this.downloadsGroupBox.SuspendLayout();
            this.netGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // peersGroupBox
            // 
            this.peersGroupBox.Controls.Add(this.editPeersButton);
            this.peersGroupBox.Controls.Add(this.addPeerButton);
            this.peersGroupBox.Controls.Add(this.RemovePeerButton);
            this.peersGroupBox.Controls.Add(this.refreshPeersButton);
            this.peersGroupBox.Controls.Add(this.peersTabs);
            this.peersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.peersGroupBox.Name = "peersGroupBox";
            this.peersGroupBox.Size = new System.Drawing.Size(200, 363);
            this.peersGroupBox.TabIndex = 0;
            this.peersGroupBox.TabStop = false;
            this.peersGroupBox.Text = "Peers";
            // 
            // editPeersButton
            // 
            this.editPeersButton.Location = new System.Drawing.Point(74, 334);
            this.editPeersButton.Name = "editPeersButton";
            this.editPeersButton.Size = new System.Drawing.Size(23, 23);
            this.editPeersButton.TabIndex = 4;
            this.editPeersButton.Text = "E";
            this.editPeersButton.UseVisualStyleBackColor = true;
            // 
            // addPeerButton
            // 
            this.addPeerButton.Location = new System.Drawing.Point(16, 334);
            this.addPeerButton.Name = "addPeerButton";
            this.addPeerButton.Size = new System.Drawing.Size(23, 23);
            this.addPeerButton.TabIndex = 1;
            this.addPeerButton.Text = "+";
            this.addPeerButton.UseVisualStyleBackColor = true;
            // 
            // RemovePeerButton
            // 
            this.RemovePeerButton.Location = new System.Drawing.Point(45, 334);
            this.RemovePeerButton.Name = "RemovePeerButton";
            this.RemovePeerButton.Size = new System.Drawing.Size(23, 23);
            this.RemovePeerButton.TabIndex = 2;
            this.RemovePeerButton.Text = "-";
            this.RemovePeerButton.UseVisualStyleBackColor = true;
            // 
            // refreshPeersButton
            // 
            this.refreshPeersButton.Location = new System.Drawing.Point(161, 334);
            this.refreshPeersButton.Name = "refreshPeersButton";
            this.refreshPeersButton.Size = new System.Drawing.Size(23, 23);
            this.refreshPeersButton.TabIndex = 3;
            this.refreshPeersButton.Text = "R";
            this.refreshPeersButton.UseVisualStyleBackColor = true;
            this.refreshPeersButton.Click += new System.EventHandler(this.refreshPeersButton_Click);
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
            // logGroupBox
            // 
            this.logGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logGroupBox.Controls.Add(this.logFastObjectListView);
            this.logGroupBox.Location = new System.Drawing.Point(12, 381);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(760, 168);
            this.logGroupBox.TabIndex = 2;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // logFastObjectListView
            // 
            this.logFastObjectListView.AllColumns.Add(this.olvColumn7);
            this.logFastObjectListView.AllColumns.Add(this.olvColumn8);
            this.logFastObjectListView.AllColumns.Add(this.olvColumn9);
            this.logFastObjectListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.logFastObjectListView.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.Log_ItemsChanged);
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Time";
            this.olvColumn7.Text = "Time";
            this.olvColumn7.Width = 120;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Severity";
            this.olvColumn8.Text = "Severity";
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Description";
            this.olvColumn9.Text = "Description";
            this.olvColumn9.Width = 560;
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.browseTabPage);
            this.mainTabs.Controls.Add(this.shareTabPage);
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
            // shareTabPage
            // 
            this.shareTabPage.Controls.Add(this.sharedDataListView);
            this.shareTabPage.Controls.Add(this.editSharedButton);
            this.shareTabPage.Controls.Add(this.addSharedButton);
            this.shareTabPage.Controls.Add(this.removeSharedButton);
            this.shareTabPage.Location = new System.Drawing.Point(4, 22);
            this.shareTabPage.Name = "shareTabPage";
            this.shareTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shareTabPage.Size = new System.Drawing.Size(545, 331);
            this.shareTabPage.TabIndex = 4;
            this.shareTabPage.Text = "Share";
            this.shareTabPage.UseVisualStyleBackColor = true;
            // 
            // sharedDataListView
            // 
            this.sharedDataListView.AllColumns.Add(this.olvColumn10);
            this.sharedDataListView.AllColumns.Add(this.olvColumn11);
            this.sharedDataListView.CellEditUseWholeCell = false;
            this.sharedDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn10,
            this.olvColumn11});
            this.sharedDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.sharedDataListView.DataSource = null;
            this.sharedDataListView.FullRowSelect = true;
            this.sharedDataListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.sharedDataListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.sharedDataListView.Location = new System.Drawing.Point(6, 6);
            this.sharedDataListView.Name = "sharedDataListView";
            this.sharedDataListView.Size = new System.Drawing.Size(533, 294);
            this.sharedDataListView.TabIndex = 0;
            this.sharedDataListView.UseCompatibleStateImageBehavior = false;
            this.sharedDataListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn10
            // 
            this.olvColumn10.Text = "Folder";
            this.olvColumn10.Width = 465;
            // 
            // olvColumn11
            // 
            this.olvColumn11.Text = "Files";
            // 
            // editSharedButton
            // 
            this.editSharedButton.Location = new System.Drawing.Point(64, 306);
            this.editSharedButton.Name = "editSharedButton";
            this.editSharedButton.Size = new System.Drawing.Size(23, 23);
            this.editSharedButton.TabIndex = 5;
            this.editSharedButton.Text = "E";
            this.editSharedButton.UseVisualStyleBackColor = true;
            // 
            // addSharedButton
            // 
            this.addSharedButton.Location = new System.Drawing.Point(6, 306);
            this.addSharedButton.Name = "addSharedButton";
            this.addSharedButton.Size = new System.Drawing.Size(23, 23);
            this.addSharedButton.TabIndex = 1;
            this.addSharedButton.Text = "+";
            this.addSharedButton.UseVisualStyleBackColor = true;
            // 
            // removeSharedButton
            // 
            this.removeSharedButton.Location = new System.Drawing.Point(35, 306);
            this.removeSharedButton.Name = "removeSharedButton";
            this.removeSharedButton.Size = new System.Drawing.Size(23, 23);
            this.removeSharedButton.TabIndex = 2;
            this.removeSharedButton.Text = "-";
            this.removeSharedButton.UseVisualStyleBackColor = true;
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
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.downloadsGroupBox);
            this.settingsTabPage.Controls.Add(this.netGroupBox);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(545, 331);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // downloadsGroupBox
            // 
            this.downloadsGroupBox.Controls.Add(this.downloadsTextBox);
            this.downloadsGroupBox.Controls.Add(this.browseDownloadsButton);
            this.downloadsGroupBox.Location = new System.Drawing.Point(6, 93);
            this.downloadsGroupBox.Name = "downloadsGroupBox";
            this.downloadsGroupBox.Size = new System.Drawing.Size(533, 54);
            this.downloadsGroupBox.TabIndex = 5;
            this.downloadsGroupBox.TabStop = false;
            this.downloadsGroupBox.Text = "Downloads";
            // 
            // downloadsTextBox
            // 
            this.downloadsTextBox.Location = new System.Drawing.Point(9, 20);
            this.downloadsTextBox.Name = "downloadsTextBox";
            this.downloadsTextBox.Size = new System.Drawing.Size(482, 20);
            this.downloadsTextBox.TabIndex = 1;
            // 
            // browseDownloadsButton
            // 
            this.browseDownloadsButton.Location = new System.Drawing.Point(497, 19);
            this.browseDownloadsButton.Name = "browseDownloadsButton";
            this.browseDownloadsButton.Size = new System.Drawing.Size(30, 22);
            this.browseDownloadsButton.TabIndex = 0;
            this.browseDownloadsButton.Text = "...";
            this.browseDownloadsButton.UseVisualStyleBackColor = true;
            // 
            // netGroupBox
            // 
            this.netGroupBox.Controls.Add(this.portTextBox);
            this.netGroupBox.Controls.Add(this.portLabel);
            this.netGroupBox.Controls.Add(this.nameTextBox);
            this.netGroupBox.Controls.Add(this.nameLabel);
            this.netGroupBox.Location = new System.Drawing.Point(6, 6);
            this.netGroupBox.Name = "netGroupBox";
            this.netGroupBox.Size = new System.Drawing.Size(533, 81);
            this.netGroupBox.TabIndex = 4;
            this.netGroupBox.TabStop = false;
            this.netGroupBox.Text = "Network";
            // 
            // portTextBox
            // 
            this.portTextBox.Enabled = false;
            this.portTextBox.Location = new System.Drawing.Point(70, 19);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(142, 20);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.Text = "51010";
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(70, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "...";
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxName_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // inputErrorProvider
            // 
            this.inputErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.inputErrorProvider.ContainerControl = this;
            this.inputErrorProvider.RightToLeft = true;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_Closing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.peersGroupBox.ResumeLayout(false);
            this.peersTabs.ResumeLayout(false);
            this.lanTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lanDataListView)).EndInit();
            this.internetTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.internetDataListView)).EndInit();
            this.logGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logFastObjectListView)).EndInit();
            this.mainTabs.ResumeLayout(false);
            this.browseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browseFilesDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseFolderDataTreeListView)).EndInit();
            this.shareTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataListView)).EndInit();
            this.downloadTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadsTreeListView)).EndInit();
            this.uploadTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadsTreeListView)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.downloadsGroupBox.ResumeLayout(false);
            this.downloadsGroupBox.PerformLayout();
            this.netGroupBox.ResumeLayout(false);
            this.netGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox peersGroupBox;
        private System.Windows.Forms.Button refreshPeersButton;
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
        private System.Windows.Forms.Button removeSharedButton;
        private System.Windows.Forms.Button addSharedButton;
        private BrightIdeasSoftware.DataListView sharedDataListView;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private BrightIdeasSoftware.DataListView browseFilesDataListView;
        private BrightIdeasSoftware.DataTreeListView browseFolderDataTreeListView;
        private System.Windows.Forms.ErrorProvider inputErrorProvider;
        private System.Windows.Forms.Button editPeersButton;
        private System.Windows.Forms.TabPage shareTabPage;
        private System.Windows.Forms.Button editSharedButton;
        private System.Windows.Forms.GroupBox downloadsGroupBox;
        private System.Windows.Forms.TextBox downloadsTextBox;
        private System.Windows.Forms.Button browseDownloadsButton;
        private System.Windows.Forms.GroupBox netGroupBox;
    }
}

