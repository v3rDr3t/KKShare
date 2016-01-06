using System;
using System.Collections.Generic;

namespace KKShare.View
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
            this.peersTabs = new System.Windows.Forms.TabControl();
            this.lanTabPage = new System.Windows.Forms.TabPage();
            this.lanOLV = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.internetTabPage = new System.Windows.Forms.TabPage();
            this.internetOLV = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logFOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.browseTabPage = new System.Windows.Forms.TabPage();
            this.browseTabs = new System.Windows.Forms.TabControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.searchTLV = new BrightIdeasSoftware.TreeListView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.shareTabPage = new System.Windows.Forms.TabPage();
            this.sharesOLV = new BrightIdeasSoftware.ObjectListView();
            this.shareFolderOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.shareFilesOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.shareSizeOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.downloadsLabel = new System.Windows.Forms.Label();
            this.downloadsTB = new System.Windows.Forms.TextBox();
            this.browseDownloadsButton = new System.Windows.Forms.Button();
            this.netGroupBox = new System.Windows.Forms.GroupBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sharesCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sharesCMSAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.sharesCMSRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.sharesCMSClear = new System.Windows.Forms.ToolStripMenuItem();
            this.peersGroupBox.SuspendLayout();
            this.peersTabs.SuspendLayout();
            this.lanTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lanOLV)).BeginInit();
            this.internetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetOLV)).BeginInit();
            this.logGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logFOLV)).BeginInit();
            this.mainTabs.SuspendLayout();
            this.browseTabPage.SuspendLayout();
            this.browseTabs.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTLV)).BeginInit();
            this.shareTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharesOLV)).BeginInit();
            this.downloadTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadsTreeListView)).BeginInit();
            this.uploadTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadsTreeListView)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            this.downloadsGroupBox.SuspendLayout();
            this.netGroupBox.SuspendLayout();
            this.sharesCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // peersGroupBox
            // 
            this.peersGroupBox.Controls.Add(this.peersTabs);
            this.peersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.peersGroupBox.Name = "peersGroupBox";
            this.peersGroupBox.Size = new System.Drawing.Size(200, 363);
            this.peersGroupBox.TabIndex = 0;
            this.peersGroupBox.TabStop = false;
            this.peersGroupBox.Text = "Peers";
            // 
            // peersTabs
            // 
            this.peersTabs.Controls.Add(this.lanTabPage);
            this.peersTabs.Controls.Add(this.internetTabPage);
            this.peersTabs.Location = new System.Drawing.Point(6, 19);
            this.peersTabs.Name = "peersTabs";
            this.peersTabs.SelectedIndex = 0;
            this.peersTabs.Size = new System.Drawing.Size(188, 338);
            this.peersTabs.TabIndex = 1;
            // 
            // lanTabPage
            // 
            this.lanTabPage.Controls.Add(this.lanOLV);
            this.lanTabPage.Location = new System.Drawing.Point(4, 22);
            this.lanTabPage.Name = "lanTabPage";
            this.lanTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lanTabPage.Size = new System.Drawing.Size(180, 312);
            this.lanTabPage.TabIndex = 0;
            this.lanTabPage.Text = "LAN";
            this.lanTabPage.UseVisualStyleBackColor = true;
            // 
            // lanOLV
            // 
            this.lanOLV.AllColumns.Add(this.olvColumn12);
            this.lanOLV.CellEditUseWholeCell = false;
            this.lanOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn12});
            this.lanOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.lanOLV.FullRowSelect = true;
            this.lanOLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lanOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.lanOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.lanOLV.Location = new System.Drawing.Point(6, 6);
            this.lanOLV.Name = "lanOLV";
            this.lanOLV.ShowGroups = false;
            this.lanOLV.Size = new System.Drawing.Size(168, 300);
            this.lanOLV.TabIndex = 2;
            this.lanOLV.UseCompatibleStateImageBehavior = false;
            this.lanOLV.View = System.Windows.Forms.View.Details;
            this.lanOLV.ItemActivate += new System.EventHandler(this.onPeer_DoubleClick);
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "Name";
            this.olvColumn12.FillsFreeSpace = true;
            this.olvColumn12.Text = "PC Name";
            this.olvColumn12.Width = 100;
            // 
            // internetTabPage
            // 
            this.internetTabPage.Controls.Add(this.internetOLV);
            this.internetTabPage.Location = new System.Drawing.Point(4, 22);
            this.internetTabPage.Name = "internetTabPage";
            this.internetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.internetTabPage.Size = new System.Drawing.Size(180, 312);
            this.internetTabPage.TabIndex = 1;
            this.internetTabPage.Text = "Internet";
            this.internetTabPage.UseVisualStyleBackColor = true;
            // 
            // internetOLV
            // 
            this.internetOLV.AllColumns.Add(this.olvColumn13);
            this.internetOLV.CellEditUseWholeCell = false;
            this.internetOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn13});
            this.internetOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.internetOLV.Enabled = false;
            this.internetOLV.FullRowSelect = true;
            this.internetOLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.internetOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.internetOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.internetOLV.Location = new System.Drawing.Point(6, 6);
            this.internetOLV.Name = "internetOLV";
            this.internetOLV.ShowGroups = false;
            this.internetOLV.Size = new System.Drawing.Size(168, 271);
            this.internetOLV.TabIndex = 3;
            this.internetOLV.UseCompatibleStateImageBehavior = false;
            this.internetOLV.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "Name";
            this.olvColumn13.FillsFreeSpace = true;
            this.olvColumn13.Text = "PC Name";
            this.olvColumn13.Width = 100;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logGroupBox.Controls.Add(this.logFOLV);
            this.logGroupBox.Location = new System.Drawing.Point(12, 381);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(760, 168);
            this.logGroupBox.TabIndex = 2;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // logFOLV
            // 
            this.logFOLV.AllColumns.Add(this.olvColumn7);
            this.logFOLV.AllColumns.Add(this.olvColumn8);
            this.logFOLV.AllColumns.Add(this.olvColumn9);
            this.logFOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logFOLV.CellEditUseWholeCell = false;
            this.logFOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn9});
            this.logFOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.logFOLV.FullRowSelect = true;
            this.logFOLV.GridLines = true;
            this.logFOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.logFOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.logFOLV.Location = new System.Drawing.Point(6, 20);
            this.logFOLV.Name = "logFOLV";
            this.logFOLV.ShowGroups = false;
            this.logFOLV.Size = new System.Drawing.Size(748, 142);
            this.logFOLV.TabIndex = 0;
            this.logFOLV.UseCompatibleStateImageBehavior = false;
            this.logFOLV.View = System.Windows.Forms.View.Details;
            this.logFOLV.VirtualMode = true;
            this.logFOLV.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.onLogView_ItemsChanged);
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
            this.browseTabPage.Controls.Add(this.browseTabs);
            this.browseTabPage.Location = new System.Drawing.Point(4, 22);
            this.browseTabPage.Name = "browseTabPage";
            this.browseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.browseTabPage.Size = new System.Drawing.Size(545, 331);
            this.browseTabPage.TabIndex = 0;
            this.browseTabPage.Text = "Browse";
            this.browseTabPage.UseVisualStyleBackColor = true;
            // 
            // browseTabs
            // 
            this.browseTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseTabs.Controls.Add(this.searchTabPage);
            this.browseTabs.Location = new System.Drawing.Point(6, 6);
            this.browseTabs.Name = "browseTabs";
            this.browseTabs.SelectedIndex = 0;
            this.browseTabs.Size = new System.Drawing.Size(533, 319);
            this.browseTabs.TabIndex = 2;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchTLV);
            this.searchTabPage.Controls.Add(this.searchButton);
            this.searchTabPage.Controls.Add(this.searchTextBox);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(525, 293);
            this.searchTabPage.TabIndex = 0;
            this.searchTabPage.Text = "Search";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // searchTLV
            // 
            this.searchTLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTLV.CellEditUseWholeCell = false;
            this.searchTLV.Enabled = false;
            this.searchTLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.searchTLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.searchTLV.Location = new System.Drawing.Point(6, 32);
            this.searchTLV.Name = "searchTLV";
            this.searchTLV.ShowGroups = false;
            this.searchTLV.Size = new System.Drawing.Size(513, 255);
            this.searchTLV.TabIndex = 6;
            this.searchTLV.UseCompatibleStateImageBehavior = false;
            this.searchTLV.View = System.Windows.Forms.View.Details;
            this.searchTLV.VirtualMode = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(490, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 22);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "S";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Enabled = false;
            this.searchTextBox.Location = new System.Drawing.Point(6, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(478, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // shareTabPage
            // 
            this.shareTabPage.Controls.Add(this.sharesOLV);
            this.shareTabPage.Location = new System.Drawing.Point(4, 22);
            this.shareTabPage.Name = "shareTabPage";
            this.shareTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shareTabPage.Size = new System.Drawing.Size(545, 331);
            this.shareTabPage.TabIndex = 4;
            this.shareTabPage.Text = "Share";
            this.shareTabPage.UseVisualStyleBackColor = true;
            // 
            // sharesOLV
            // 
            this.sharesOLV.AllColumns.Add(this.shareFolderOLVCol);
            this.sharesOLV.AllColumns.Add(this.shareFilesOLVCol);
            this.sharesOLV.AllColumns.Add(this.shareSizeOLVCol);
            this.sharesOLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sharesOLV.BackColor = System.Drawing.SystemColors.Window;
            this.sharesOLV.CellEditUseWholeCell = false;
            this.sharesOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.shareFolderOLVCol,
            this.shareFilesOLVCol,
            this.shareSizeOLVCol});
            this.sharesOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.sharesOLV.FullRowSelect = true;
            this.sharesOLV.HasCollapsibleGroups = false;
            this.sharesOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.sharesOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.sharesOLV.Location = new System.Drawing.Point(6, 6);
            this.sharesOLV.Name = "sharesOLV";
            this.sharesOLV.Size = new System.Drawing.Size(533, 319);
            this.sharesOLV.TabIndex = 6;
            this.sharesOLV.UseCompatibleStateImageBehavior = false;
            this.sharesOLV.View = System.Windows.Forms.View.Details;
            this.sharesOLV.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.onShares_OpenContext);
            // 
            // shareFolderOLVCol
            // 
            this.shareFolderOLVCol.AspectName = "DirPath";
            this.shareFolderOLVCol.Groupable = false;
            this.shareFolderOLVCol.HeaderImageKey = "";
            this.shareFolderOLVCol.Text = "Folder";
            this.shareFolderOLVCol.Width = 364;
            // 
            // shareFilesOLVCol
            // 
            this.shareFilesOLVCol.AspectName = "GetFilesOnlyCount";
            this.shareFilesOLVCol.Groupable = false;
            this.shareFilesOLVCol.Text = "Files";
            this.shareFilesOLVCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shareFilesOLVCol.Width = 80;
            // 
            // shareSizeOLVCol
            // 
            this.shareSizeOLVCol.AspectName = "GetSize";
            this.shareSizeOLVCol.FillsFreeSpace = true;
            this.shareSizeOLVCol.Groupable = false;
            this.shareSizeOLVCol.Text = "Size";
            this.shareSizeOLVCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shareSizeOLVCol.Width = 84;
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
            this.downloadsTreeListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadsTreeListView.CellEditUseWholeCell = false;
            this.downloadsTreeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.downloadsTreeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.downloadsTreeListView.Enabled = false;
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
            this.uploadsTreeListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.downloadsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadsGroupBox.Controls.Add(this.downloadsLabel);
            this.downloadsGroupBox.Controls.Add(this.downloadsTB);
            this.downloadsGroupBox.Controls.Add(this.browseDownloadsButton);
            this.downloadsGroupBox.Location = new System.Drawing.Point(6, 93);
            this.downloadsGroupBox.Name = "downloadsGroupBox";
            this.downloadsGroupBox.Size = new System.Drawing.Size(533, 54);
            this.downloadsGroupBox.TabIndex = 5;
            this.downloadsGroupBox.TabStop = false;
            this.downloadsGroupBox.Text = "Misc";
            // 
            // downloadsLabel
            // 
            this.downloadsLabel.AutoSize = true;
            this.downloadsLabel.Location = new System.Drawing.Point(6, 23);
            this.downloadsLabel.Name = "downloadsLabel";
            this.downloadsLabel.Size = new System.Drawing.Size(63, 13);
            this.downloadsLabel.TabIndex = 4;
            this.downloadsLabel.Text = "Downloads:";
            // 
            // downloadsTB
            // 
            this.downloadsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadsTB.Location = new System.Drawing.Point(75, 20);
            this.downloadsTB.Name = "downloadsTB";
            this.downloadsTB.Size = new System.Drawing.Size(416, 20);
            this.downloadsTB.TabIndex = 1;
            this.downloadsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onDownloadsTB_KeyPress);
            this.downloadsTB.Validating += new System.ComponentModel.CancelEventHandler(this.onDownloadsTB_Validating);
            // 
            // browseDownloadsButton
            // 
            this.browseDownloadsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseDownloadsButton.Location = new System.Drawing.Point(497, 19);
            this.browseDownloadsButton.Name = "browseDownloadsButton";
            this.browseDownloadsButton.Size = new System.Drawing.Size(30, 22);
            this.browseDownloadsButton.TabIndex = 0;
            this.browseDownloadsButton.Text = "...";
            this.browseDownloadsButton.UseVisualStyleBackColor = true;
            this.browseDownloadsButton.Click += new System.EventHandler(this.onDownloadsBrowseBtn_Click);
            // 
            // netGroupBox
            // 
            this.netGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netGroupBox.Controls.Add(this.portTextBox);
            this.netGroupBox.Controls.Add(this.portLabel);
            this.netGroupBox.Controls.Add(this.nameTB);
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
            this.portTextBox.Location = new System.Drawing.Point(75, 19);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(137, 20);
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
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(75, 45);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(137, 20);
            this.nameTB.TabIndex = 3;
            this.nameTB.Text = "...";
            this.nameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onNameTB_KeyPress);
            this.nameTB.Validating += new System.ComponentModel.CancelEventHandler(this.onNameTB_Validating);
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
            // sharesCMS
            // 
            this.sharesCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sharesCMSAdd,
            this.sharesCMSRemove,
            this.sharesCMSClear});
            this.sharesCMS.Name = "sharedItemCMS";
            this.sharesCMS.Size = new System.Drawing.Size(118, 70);
            // 
            // sharesCMSAdd
            // 
            this.sharesCMSAdd.Name = "sharesCMSAdd";
            this.sharesCMSAdd.Size = new System.Drawing.Size(117, 22);
            this.sharesCMSAdd.Text = "Add";
            this.sharesCMSAdd.Click += new System.EventHandler(this.onSharesCMSAdd_Click);
            // 
            // sharesCMSRemove
            // 
            this.sharesCMSRemove.Name = "sharesCMSRemove";
            this.sharesCMSRemove.Size = new System.Drawing.Size(117, 22);
            this.sharesCMSRemove.Text = "Remove";
            this.sharesCMSRemove.Click += new System.EventHandler(this.onSharesCMSRemove_Click);
            // 
            // sharesCMSClear
            // 
            this.sharesCMSClear.Name = "sharesCMSClear";
            this.sharesCMSClear.Size = new System.Drawing.Size(117, 22);
            this.sharesCMSClear.Text = "Clear";
            this.sharesCMSClear.Click += new System.EventHandler(this.onSharesCMSClear_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onMainView_Close);
            this.Shown += new System.EventHandler(this.onMainView_Show);
            this.peersGroupBox.ResumeLayout(false);
            this.peersTabs.ResumeLayout(false);
            this.lanTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lanOLV)).EndInit();
            this.internetTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.internetOLV)).EndInit();
            this.logGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logFOLV)).EndInit();
            this.mainTabs.ResumeLayout(false);
            this.browseTabPage.ResumeLayout(false);
            this.browseTabs.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.searchTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTLV)).EndInit();
            this.shareTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sharesOLV)).EndInit();
            this.downloadTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadsTreeListView)).EndInit();
            this.uploadTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadsTreeListView)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.downloadsGroupBox.ResumeLayout(false);
            this.downloadsGroupBox.PerformLayout();
            this.netGroupBox.ResumeLayout(false);
            this.netGroupBox.PerformLayout();
            this.sharesCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox peersGroupBox;
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
        private BrightIdeasSoftware.FastObjectListView logFOLV;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TabPage shareTabPage;
        private System.Windows.Forms.GroupBox downloadsGroupBox;
        private System.Windows.Forms.TextBox downloadsTB;
        private System.Windows.Forms.Button browseDownloadsButton;
        private System.Windows.Forms.GroupBox netGroupBox;
        private BrightIdeasSoftware.ObjectListView lanOLV;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private System.Windows.Forms.TabControl browseTabs;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private BrightIdeasSoftware.ObjectListView internetOLV;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private BrightIdeasSoftware.ObjectListView sharesOLV;
        private BrightIdeasSoftware.OLVColumn shareFolderOLVCol;
        private BrightIdeasSoftware.OLVColumn shareFilesOLVCol;
        private BrightIdeasSoftware.TreeListView searchTLV;
        private System.Windows.Forms.ContextMenuStrip sharesCMS;
        private System.Windows.Forms.ToolStripMenuItem sharesCMSAdd;
        private System.Windows.Forms.ToolStripMenuItem sharesCMSRemove;
        private System.Windows.Forms.ToolStripMenuItem sharesCMSClear;
        private BrightIdeasSoftware.OLVColumn shareSizeOLVCol;
        private System.Windows.Forms.Label downloadsLabel;
    }
}

