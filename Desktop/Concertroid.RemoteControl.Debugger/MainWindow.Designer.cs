namespace Concertroid.RemoteControl
{
	partial class MainWindow
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvMessageLog = new System.Windows.Forms.ListView();
			this.chMessageSeverity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMessageContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fraSetList = new System.Windows.Forms.GroupBox();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openSequenceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDebugStart = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDebugSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuDebugStepInto = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDebugStepOver = new System.Windows.Forms.ToolStripMenuItem();
			this.lvSetList = new System.Windows.Forms.ListView();
			this.chSetListSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chSetListProducers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chSetListPerformers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileDisconnect = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.fraSetList.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvMessageLog);
			this.groupBox1.Location = new System.Drawing.Point(3, 304);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(705, 137);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Messages";
			// 
			// lvMessageLog
			// 
			this.lvMessageLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvMessageLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMessageSeverity,
            this.chMessageContent});
			this.lvMessageLog.FullRowSelect = true;
			this.lvMessageLog.GridLines = true;
			this.lvMessageLog.HideSelection = false;
			this.lvMessageLog.Location = new System.Drawing.Point(9, 19);
			this.lvMessageLog.Name = "lvMessageLog";
			this.lvMessageLog.Size = new System.Drawing.Size(690, 112);
			this.lvMessageLog.TabIndex = 0;
			this.lvMessageLog.UseCompatibleStateImageBehavior = false;
			this.lvMessageLog.View = System.Windows.Forms.View.Details;
			// 
			// chMessageSeverity
			// 
			this.chMessageSeverity.Text = "Severity";
			// 
			// chMessageContent
			// 
			this.chMessageContent.Text = "Message";
			// 
			// fraSetList
			// 
			this.fraSetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fraSetList.Controls.Add(this.lvSetList);
			this.fraSetList.Location = new System.Drawing.Point(3, 138);
			this.fraSetList.Name = "fraSetList";
			this.fraSetList.Size = new System.Drawing.Size(705, 160);
			this.fraSetList.TabIndex = 1;
			this.fraSetList.TabStop = false;
			this.fraSetList.Text = "Set List";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.fraSetList);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(711, 444);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(711, 468);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(711, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileConnect,
            this.mnuFileDisconnect,
            this.toolStripSeparator1,
            this.openSequenceFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openSequenceFileToolStripMenuItem
			// 
			this.openSequenceFileToolStripMenuItem.Name = "openSequenceFileToolStripMenuItem";
			this.openSequenceFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openSequenceFileToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.openSequenceFileToolStripMenuItem.Text = "&Open Sequence File (CSQ)...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// debugToolStripMenuItem
			// 
			this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDebugStart,
            this.mnuDebugSep1,
            this.mnuDebugStepInto,
            this.mnuDebugStepOver});
			this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
			this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.debugToolStripMenuItem.Text = "&Debug";
			// 
			// mnuDebugStart
			// 
			this.mnuDebugStart.Name = "mnuDebugStart";
			this.mnuDebugStart.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.mnuDebugStart.Size = new System.Drawing.Size(179, 22);
			this.mnuDebugStart.Text = "&Start Debugging";
			// 
			// mnuDebugSep1
			// 
			this.mnuDebugSep1.Name = "mnuDebugSep1";
			this.mnuDebugSep1.Size = new System.Drawing.Size(176, 6);
			// 
			// mnuDebugStepInto
			// 
			this.mnuDebugStepInto.Name = "mnuDebugStepInto";
			this.mnuDebugStepInto.ShortcutKeys = System.Windows.Forms.Keys.F11;
			this.mnuDebugStepInto.Size = new System.Drawing.Size(179, 22);
			this.mnuDebugStepInto.Text = "Step &Into";
			// 
			// mnuDebugStepOver
			// 
			this.mnuDebugStepOver.Name = "mnuDebugStepOver";
			this.mnuDebugStepOver.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.mnuDebugStepOver.Size = new System.Drawing.Size(179, 22);
			this.mnuDebugStepOver.Text = "Step &Over";
			// 
			// lvSetList
			// 
			this.lvSetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvSetList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSetListSong,
            this.chSetListProducers,
            this.chSetListPerformers});
			this.lvSetList.FullRowSelect = true;
			this.lvSetList.GridLines = true;
			this.lvSetList.HideSelection = false;
			this.lvSetList.Location = new System.Drawing.Point(9, 19);
			this.lvSetList.Name = "lvSetList";
			this.lvSetList.Size = new System.Drawing.Size(690, 135);
			this.lvSetList.TabIndex = 0;
			this.lvSetList.UseCompatibleStateImageBehavior = false;
			this.lvSetList.View = System.Windows.Forms.View.Details;
			// 
			// chSetListSong
			// 
			this.chSetListSong.Text = "Song";
			this.chSetListSong.Width = 244;
			// 
			// chSetListProducers
			// 
			this.chSetListProducers.Text = "Producer(s)";
			this.chSetListProducers.Width = 155;
			// 
			// chSetListPerformers
			// 
			this.chSetListPerformers.Text = "Performer(s)";
			this.chSetListPerformers.Width = 153;
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// mnuHelpAbout
			// 
			this.mnuHelpAbout.Name = "mnuHelpAbout";
			this.mnuHelpAbout.Size = new System.Drawing.Size(272, 22);
			this.mnuHelpAbout.Text = "&About Concertroid Remote Debugger";
			this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
			// 
			// mnuFileConnect
			// 
			this.mnuFileConnect.Name = "mnuFileConnect";
			this.mnuFileConnect.Size = new System.Drawing.Size(264, 22);
			this.mnuFileConnect.Text = "&Connect...";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
			// 
			// mnuFileDisconnect
			// 
			this.mnuFileDisconnect.Enabled = false;
			this.mnuFileDisconnect.Name = "mnuFileDisconnect";
			this.mnuFileDisconnect.Size = new System.Drawing.Size(264, 22);
			this.mnuFileDisconnect.Text = "&Disconnect";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(711, 468);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.Text = "Concertroid Remote Debugger";
			this.groupBox1.ResumeLayout(false);
			this.fraSetList.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvMessageLog;
		private System.Windows.Forms.ColumnHeader chMessageSeverity;
		private System.Windows.Forms.ColumnHeader chMessageContent;
		private System.Windows.Forms.GroupBox fraSetList;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openSequenceFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuDebugStart;
		private System.Windows.Forms.ToolStripSeparator mnuDebugSep1;
		private System.Windows.Forms.ToolStripMenuItem mnuDebugStepInto;
		private System.Windows.Forms.ToolStripMenuItem mnuDebugStepOver;
		private System.Windows.Forms.ListView lvSetList;
		private System.Windows.Forms.ColumnHeader chSetListSong;
		private System.Windows.Forms.ColumnHeader chSetListProducers;
		private System.Windows.Forms.ColumnHeader chSetListPerformers;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuFileConnect;
		private System.Windows.Forms.ToolStripMenuItem mnuFileDisconnect;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

