namespace Concertroid.Manager.Editors
{
	partial class AnimationEditor
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.toolbox = new AwesomeControls.Toolbox.ToolboxControl();
			this.timeline = new AwesomeControls.Timeline.TimelineControl();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.toolbox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(731, 452);
			this.splitContainer1.SplitterDistance = 195;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.timeline);
			this.splitContainer2.Size = new System.Drawing.Size(532, 452);
			this.splitContainer2.SplitterDistance = 320;
			this.splitContainer2.TabIndex = 0;
			// 
			// toolbox
			// 
			this.toolbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolbox.Location = new System.Drawing.Point(0, 0);
			this.toolbox.Name = "toolbox";
			this.toolbox.Size = new System.Drawing.Size(195, 452);
			this.toolbox.TabIndex = 0;
			// 
			// timeline
			// 
			this.timeline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeline.EntryContextMenuStrip = null;
			this.timeline.EntryQuantization = 8;
			this.timeline.GroupContextMenuStrip = null;
			this.timeline.Location = new System.Drawing.Point(0, 0);
			this.timeline.Name = "timeline";
			this.timeline.Size = new System.Drawing.Size(532, 128);
			this.timeline.TabIndex = 0;
			// 
			// AnimationEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "AnimationEditor";
			this.Size = new System.Drawing.Size(731, 452);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private AwesomeControls.Toolbox.ToolboxControl toolbox;
		private AwesomeControls.Timeline.TimelineControl timeline;
	}
}
