namespace Concertroid.Manager.Panels
{
    partial class RemoteControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbl1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbsTabsPerformers = new System.Windows.Forms.TabControl();
            this.tabPerformers = new System.Windows.Forms.TabPage();
            this.lvCostumes = new System.Windows.Forms.ListView();
            this.chCostumeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuContext = new AwesomeControls.CommandBars.CBContextMenu(this.components);
            this.mnuContextAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextAddExisting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextActivateNow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextActivateNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPerformers = new System.Windows.Forms.ListView();
            this.chCharacterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.chSongName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSongProducers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSongTempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuthorized = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ab = new AwesomeControls.ActionBar.ActionBarControl();
            this.tbsMode = new System.Windows.Forms.TabControl();
            this.tabPerformance = new System.Windows.Forms.TabPage();
            this.lvPerformances = new System.Windows.Forms.ListView();
            this.chPerformanceSongTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPerformanceSongComposers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPerformanceSongPerformers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAssets = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fraServerInformation = new System.Windows.Forms.GroupBox();
            this.txtServerHostName = new System.Windows.Forms.TextBox();
            this.lblServerHostName = new System.Windows.Forms.Label();
            this.txtServerVersion = new System.Windows.Forms.TextBox();
            this.lblServerEngineVersion = new System.Windows.Forms.Label();
            this.txtServerTitle = new System.Windows.Forms.TextBox();
            this.lblServerTitle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbl1.SuspendLayout();
            this.tbsTabsPerformers.SuspendLayout();
            this.tabPerformers.SuspendLayout();
            this.mnuContext.SuspendLayout();
            this.tbs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbsMode.SuspendLayout();
            this.tabPerformance.SuspendLayout();
            this.tabAssets.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.fraServerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl1
            // 
            this.tbl1.ColumnCount = 1;
            this.tbl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl1.Controls.Add(this.tbsTabsPerformers, 0, 0);
            this.tbl1.Controls.Add(this.tbs, 0, 1);
            this.tbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl1.Location = new System.Drawing.Point(0, 0);
            this.tbl1.Name = "tbl1";
            this.tbl1.RowCount = 2;
            this.tbl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl1.Size = new System.Drawing.Size(465, 212);
            this.tbl1.TabIndex = 13;
            // 
            // tbsTabsPerformers
            // 
            this.tbsTabsPerformers.Controls.Add(this.tabPerformers);
            this.tbsTabsPerformers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbsTabsPerformers.Location = new System.Drawing.Point(3, 3);
            this.tbsTabsPerformers.Name = "tbsTabsPerformers";
            this.tbsTabsPerformers.SelectedIndex = 0;
            this.tbsTabsPerformers.Size = new System.Drawing.Size(459, 100);
            this.tbsTabsPerformers.TabIndex = 5;
            // 
            // tabPerformers
            // 
            this.tabPerformers.Controls.Add(this.lvCostumes);
            this.tabPerformers.Controls.Add(this.lvPerformers);
            this.tabPerformers.Location = new System.Drawing.Point(4, 22);
            this.tabPerformers.Name = "tabPerformers";
            this.tabPerformers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerformers.Size = new System.Drawing.Size(451, 74);
            this.tabPerformers.TabIndex = 1;
            this.tabPerformers.Text = "Performers";
            this.tabPerformers.UseVisualStyleBackColor = true;
            // 
            // lvCostumes
            // 
            this.lvCostumes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCostumes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCostumeName});
            this.lvCostumes.ContextMenuStrip = this.mnuContext;
            this.lvCostumes.FullRowSelect = true;
            this.lvCostumes.GridLines = true;
            this.lvCostumes.HideSelection = false;
            this.lvCostumes.Location = new System.Drawing.Point(330, 0);
            this.lvCostumes.Name = "lvCostumes";
            this.lvCostumes.Size = new System.Drawing.Size(121, 74);
            this.lvCostumes.TabIndex = 0;
            this.lvCostumes.UseCompatibleStateImageBehavior = false;
            this.lvCostumes.View = System.Windows.Forms.View.Details;
            // 
            // chCostumeName
            // 
            this.chCostumeName.Text = "Costume";
            this.chCostumeName.Width = 114;
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextAddNew,
            this.mnuContextAddExisting,
            this.mnuContextSep1,
            this.mnuContextActivateNow,
            this.mnuContextActivateNext,
            this.mnuContextSep2,
            this.mnuContextMoveUp,
            this.mnuContextMoveDown,
            this.mnuContextSep3,
            this.mnuContextCut,
            this.mnuContextCopy,
            this.mnuContextPaste,
            this.mnuContextDelete,
            this.mnuContextSep4,
            this.mnuContextProperties});
            this.mnuContext.Name = "mnuContextCharacterList";
            this.mnuContext.Size = new System.Drawing.Size(233, 270);
            this.mnuContext.Opening += new System.ComponentModel.CancelEventHandler(this.mnuContext_Opening);
            // 
            // mnuContextAddNew
            // 
            this.mnuContextAddNew.Name = "mnuContextAddNew";
            this.mnuContextAddNew.ShortcutKeyDisplayString = "Ins";
            this.mnuContextAddNew.Size = new System.Drawing.Size(232, 22);
            this.mnuContextAddNew.Text = "Add Ne&w Song...";
            this.mnuContextAddNew.Click += new System.EventHandler(this.mnuContextAddNew_Click);
            // 
            // mnuContextAddExisting
            // 
            this.mnuContextAddExisting.Name = "mnuContextAddExisting";
            this.mnuContextAddExisting.ShortcutKeyDisplayString = "Shift+Ins";
            this.mnuContextAddExisting.Size = new System.Drawing.Size(232, 22);
            this.mnuContextAddExisting.Text = "Add Existin&g Song...";
            this.mnuContextAddExisting.Click += new System.EventHandler(this.mnuContextAddExisting_Click);
            // 
            // mnuContextSep1
            // 
            this.mnuContextSep1.Name = "mnuContextSep1";
            this.mnuContextSep1.Size = new System.Drawing.Size(229, 6);
            // 
            // mnuContextActivateNow
            // 
            this.mnuContextActivateNow.Name = "mnuContextActivateNow";
            this.mnuContextActivateNow.ShortcutKeyDisplayString = "Enter";
            this.mnuContextActivateNow.Size = new System.Drawing.Size(232, 22);
            this.mnuContextActivateNow.Text = "Play &Now";
            // 
            // mnuContextActivateNext
            // 
            this.mnuContextActivateNext.Name = "mnuContextActivateNext";
            this.mnuContextActivateNext.ShortcutKeyDisplayString = "Shift+Enter";
            this.mnuContextActivateNext.Size = new System.Drawing.Size(232, 22);
            this.mnuContextActivateNext.Text = "Play Ne&xt";
            // 
            // mnuContextSep2
            // 
            this.mnuContextSep2.Name = "mnuContextSep2";
            this.mnuContextSep2.Size = new System.Drawing.Size(229, 6);
            // 
            // mnuContextMoveUp
            // 
            this.mnuContextMoveUp.Name = "mnuContextMoveUp";
            this.mnuContextMoveUp.Size = new System.Drawing.Size(232, 22);
            this.mnuContextMoveUp.Text = "Move &Up";
            // 
            // mnuContextMoveDown
            // 
            this.mnuContextMoveDown.Name = "mnuContextMoveDown";
            this.mnuContextMoveDown.Size = new System.Drawing.Size(232, 22);
            this.mnuContextMoveDown.Text = "Move &Down";
            // 
            // mnuContextSep3
            // 
            this.mnuContextSep3.Name = "mnuContextSep3";
            this.mnuContextSep3.Size = new System.Drawing.Size(229, 6);
            // 
            // mnuContextCut
            // 
            this.mnuContextCut.Name = "mnuContextCut";
            this.mnuContextCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.mnuContextCut.Size = new System.Drawing.Size(232, 22);
            this.mnuContextCut.Text = "Cu&t";
            // 
            // mnuContextCopy
            // 
            this.mnuContextCopy.Name = "mnuContextCopy";
            this.mnuContextCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.mnuContextCopy.Size = new System.Drawing.Size(232, 22);
            this.mnuContextCopy.Text = "&Copy";
            // 
            // mnuContextPaste
            // 
            this.mnuContextPaste.Name = "mnuContextPaste";
            this.mnuContextPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.mnuContextPaste.Size = new System.Drawing.Size(232, 22);
            this.mnuContextPaste.Text = "&Paste";
            // 
            // mnuContextDelete
            // 
            this.mnuContextDelete.Name = "mnuContextDelete";
            this.mnuContextDelete.ShortcutKeyDisplayString = "Del";
            this.mnuContextDelete.Size = new System.Drawing.Size(232, 22);
            this.mnuContextDelete.Text = "&Delete";
            // 
            // mnuContextSep4
            // 
            this.mnuContextSep4.Name = "mnuContextSep4";
            this.mnuContextSep4.Size = new System.Drawing.Size(229, 6);
            // 
            // mnuContextProperties
            // 
            this.mnuContextProperties.Name = "mnuContextProperties";
            this.mnuContextProperties.ShortcutKeyDisplayString = "Alt+Enter";
            this.mnuContextProperties.Size = new System.Drawing.Size(232, 22);
            this.mnuContextProperties.Text = "P&roperties...";
            this.mnuContextProperties.Click += new System.EventHandler(this.mnuContextProperties_Click);
            // 
            // lvPerformers
            // 
            this.lvPerformers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPerformers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCharacterName});
            this.lvPerformers.ContextMenuStrip = this.mnuContext;
            this.lvPerformers.FullRowSelect = true;
            this.lvPerformers.GridLines = true;
            this.lvPerformers.HideSelection = false;
            this.lvPerformers.Location = new System.Drawing.Point(0, 0);
            this.lvPerformers.Name = "lvPerformers";
            this.lvPerformers.Size = new System.Drawing.Size(324, 74);
            this.lvPerformers.TabIndex = 0;
            this.lvPerformers.UseCompatibleStateImageBehavior = false;
            this.lvPerformers.View = System.Windows.Forms.View.Details;
            this.lvPerformers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPerformers_MouseDoubleClick);
            // 
            // chCharacterName
            // 
            this.chCharacterName.Text = "Name";
            this.chCharacterName.Width = 311;
            // 
            // tbs
            // 
            this.tbs.Controls.Add(this.tabPage1);
            this.tbs.Controls.Add(this.tabPage2);
            this.tbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbs.Location = new System.Drawing.Point(3, 109);
            this.tbs.Name = "tbs";
            this.tbs.SelectedIndex = 0;
            this.tbs.Size = new System.Drawing.Size(459, 100);
            this.tbs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvSongs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Songs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvSongs
            // 
            this.lvSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSongName,
            this.chSongProducers,
            this.chSongTempo,
            this.chAuthorized});
            this.lvSongs.ContextMenuStrip = this.mnuContext;
            this.lvSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSongs.FullRowSelect = true;
            this.lvSongs.GridLines = true;
            this.lvSongs.HideSelection = false;
            this.lvSongs.Location = new System.Drawing.Point(3, 3);
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.Size = new System.Drawing.Size(445, 68);
            this.lvSongs.TabIndex = 1;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.Details;
            this.lvSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSongs_MouseDoubleClick);
            // 
            // chSongName
            // 
            this.chSongName.Text = "Name";
            this.chSongName.Width = 187;
            // 
            // chSongProducers
            // 
            this.chSongProducers.Text = "Producer(s)";
            this.chSongProducers.Width = 145;
            // 
            // chSongTempo
            // 
            this.chSongTempo.Text = "Tempo";
            // 
            // chAuthorized
            // 
            this.chAuthorized.Text = "Auth?";
            this.chAuthorized.Width = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ab
            // 
            this.ab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ab.Location = new System.Drawing.Point(0, 0);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(479, 31);
            this.ab.TabIndex = 14;
            this.ab.Text = "ActionBar";
            // 
            // tbsMode
            // 
            this.tbsMode.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbsMode.Controls.Add(this.tabPerformance);
            this.tbsMode.Controls.Add(this.tabAssets);
            this.tbsMode.Controls.Add(this.tabPage3);
            this.tbsMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbsMode.Location = new System.Drawing.Point(3, 84);
            this.tbsMode.Name = "tbsMode";
            this.tbsMode.SelectedIndex = 0;
            this.tbsMode.Size = new System.Drawing.Size(473, 241);
            this.tbsMode.TabIndex = 15;
            // 
            // tabPerformance
            // 
            this.tabPerformance.Controls.Add(this.lvPerformances);
            this.tabPerformance.Location = new System.Drawing.Point(4, 25);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.Size = new System.Drawing.Size(465, 212);
            this.tabPerformance.TabIndex = 1;
            this.tabPerformance.Text = "Performance/Automation";
            this.tabPerformance.UseVisualStyleBackColor = true;
            // 
            // lvPerformances
            // 
            this.lvPerformances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPerformanceSongTitle,
            this.chPerformanceSongComposers,
            this.chPerformanceSongPerformers});
            this.lvPerformances.ContextMenuStrip = this.mnuContext;
            this.lvPerformances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPerformances.FullRowSelect = true;
            this.lvPerformances.GridLines = true;
            this.lvPerformances.HideSelection = false;
            this.lvPerformances.Location = new System.Drawing.Point(0, 0);
            this.lvPerformances.Name = "lvPerformances";
            this.lvPerformances.Size = new System.Drawing.Size(465, 212);
            this.lvPerformances.TabIndex = 16;
            this.lvPerformances.UseCompatibleStateImageBehavior = false;
            this.lvPerformances.View = System.Windows.Forms.View.Details;
            // 
            // chPerformanceSongTitle
            // 
            this.chPerformanceSongTitle.Text = "Song";
            this.chPerformanceSongTitle.Width = 173;
            // 
            // chPerformanceSongComposers
            // 
            this.chPerformanceSongComposers.Text = "Composer(s)";
            this.chPerformanceSongComposers.Width = 151;
            // 
            // chPerformanceSongPerformers
            // 
            this.chPerformanceSongPerformers.Text = "Performer(s)";
            this.chPerformanceSongPerformers.Width = 130;
            // 
            // tabAssets
            // 
            this.tabAssets.Controls.Add(this.tbl1);
            this.tabAssets.Location = new System.Drawing.Point(4, 25);
            this.tabAssets.Name = "tabAssets";
            this.tabAssets.Size = new System.Drawing.Size(465, 212);
            this.tabAssets.TabIndex = 0;
            this.tabAssets.Text = "Assets/Manual Control";
            this.tabAssets.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbsMode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fraServerInformation, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 328);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // fraServerInformation
            // 
            this.fraServerInformation.Controls.Add(this.txtServerHostName);
            this.fraServerInformation.Controls.Add(this.lblServerHostName);
            this.fraServerInformation.Controls.Add(this.txtServerVersion);
            this.fraServerInformation.Controls.Add(this.lblServerEngineVersion);
            this.fraServerInformation.Controls.Add(this.txtServerTitle);
            this.fraServerInformation.Controls.Add(this.lblServerTitle);
            this.fraServerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fraServerInformation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fraServerInformation.Location = new System.Drawing.Point(3, 3);
            this.fraServerInformation.Name = "fraServerInformation";
            this.fraServerInformation.Size = new System.Drawing.Size(473, 75);
            this.fraServerInformation.TabIndex = 16;
            this.fraServerInformation.TabStop = false;
            this.fraServerInformation.Text = "Server Information";
            // 
            // txtServerHostName
            // 
            this.txtServerHostName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerHostName.Location = new System.Drawing.Point(265, 45);
            this.txtServerHostName.Name = "txtServerHostName";
            this.txtServerHostName.ReadOnly = true;
            this.txtServerHostName.Size = new System.Drawing.Size(202, 20);
            this.txtServerHostName.TabIndex = 1;
            // 
            // lblServerHostName
            // 
            this.lblServerHostName.AutoSize = true;
            this.lblServerHostName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServerHostName.Location = new System.Drawing.Point(201, 48);
            this.lblServerHostName.Name = "lblServerHostName";
            this.lblServerHostName.Size = new System.Drawing.Size(58, 13);
            this.lblServerHostName.TabIndex = 0;
            this.lblServerHostName.Text = "Hostname:";
            // 
            // txtServerVersion
            // 
            this.txtServerVersion.Location = new System.Drawing.Point(108, 45);
            this.txtServerVersion.Name = "txtServerVersion";
            this.txtServerVersion.ReadOnly = true;
            this.txtServerVersion.Size = new System.Drawing.Size(87, 20);
            this.txtServerVersion.TabIndex = 1;
            // 
            // lblServerEngineVersion
            // 
            this.lblServerEngineVersion.AutoSize = true;
            this.lblServerEngineVersion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServerEngineVersion.Location = new System.Drawing.Point(22, 48);
            this.lblServerEngineVersion.Name = "lblServerEngineVersion";
            this.lblServerEngineVersion.Size = new System.Drawing.Size(80, 13);
            this.lblServerEngineVersion.TabIndex = 0;
            this.lblServerEngineVersion.Text = "Engine version:";
            // 
            // txtServerTitle
            // 
            this.txtServerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerTitle.Location = new System.Drawing.Point(109, 19);
            this.txtServerTitle.Name = "txtServerTitle";
            this.txtServerTitle.ReadOnly = true;
            this.txtServerTitle.Size = new System.Drawing.Size(358, 20);
            this.txtServerTitle.TabIndex = 1;
            // 
            // lblServerTitle
            // 
            this.lblServerTitle.AutoSize = true;
            this.lblServerTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServerTitle.Location = new System.Drawing.Point(23, 22);
            this.lblServerTitle.Name = "lblServerTitle";
            this.lblServerTitle.Size = new System.Drawing.Size(30, 13);
            this.lblServerTitle.TabIndex = 0;
            this.lblServerTitle.Text = "Title:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(465, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Concert Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RemoteControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ab);
            this.Name = "RemoteControlPanel";
            this.Size = new System.Drawing.Size(479, 359);
            this.tbl1.ResumeLayout(false);
            this.tbsTabsPerformers.ResumeLayout(false);
            this.tabPerformers.ResumeLayout(false);
            this.mnuContext.ResumeLayout(false);
            this.tbs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbsMode.ResumeLayout(false);
            this.tabPerformance.ResumeLayout(false);
            this.tabAssets.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.fraServerInformation.ResumeLayout(false);
            this.fraServerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl1;
        private System.Windows.Forms.TabControl tbsTabsPerformers;
        private System.Windows.Forms.TabPage tabPerformers;
        private System.Windows.Forms.ListView lvCostumes;
        private System.Windows.Forms.ColumnHeader chCostumeName;
        private System.Windows.Forms.ListView lvPerformers;
        private System.Windows.Forms.ColumnHeader chCharacterName;
        private System.Windows.Forms.TabControl tbs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.ColumnHeader chSongName;
        private System.Windows.Forms.TabPage tabPage2;
        private AwesomeControls.ActionBar.ActionBarControl ab;
        private AwesomeControls.CommandBars.CBContextMenu mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuContextAddNew;
        private System.Windows.Forms.ToolStripMenuItem mnuContextAddExisting;
        private System.Windows.Forms.ToolStripSeparator mnuContextSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuContextMoveDown;
        private System.Windows.Forms.ToolStripSeparator mnuContextSep3;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCut;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuContextPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuContextDelete;
        private System.Windows.Forms.ToolStripSeparator mnuContextSep4;
        private System.Windows.Forms.ToolStripMenuItem mnuContextProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuContextActivateNow;
        private System.Windows.Forms.ToolStripMenuItem mnuContextActivateNext;
        private System.Windows.Forms.ToolStripSeparator mnuContextSep2;
        private System.Windows.Forms.TabControl tbsMode;
        private System.Windows.Forms.TabPage tabAssets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox fraServerInformation;
        private System.Windows.Forms.TextBox txtServerVersion;
        private System.Windows.Forms.Label lblServerEngineVersion;
        private System.Windows.Forms.TextBox txtServerTitle;
        private System.Windows.Forms.Label lblServerTitle;
        private System.Windows.Forms.TextBox txtServerHostName;
        private System.Windows.Forms.Label lblServerHostName;
        private System.Windows.Forms.ColumnHeader chSongProducers;
        private System.Windows.Forms.ColumnHeader chSongTempo;
        private System.Windows.Forms.ColumnHeader chAuthorized;
        private System.Windows.Forms.TabPage tabPerformance;
        private System.Windows.Forms.ListView lvPerformances;
        private System.Windows.Forms.ColumnHeader chPerformanceSongTitle;
        private System.Windows.Forms.ColumnHeader chPerformanceSongPerformers;
        private System.Windows.Forms.ColumnHeader chPerformanceSongComposers;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
