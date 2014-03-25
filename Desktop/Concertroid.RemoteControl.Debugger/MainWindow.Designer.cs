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
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvMessageLog);
			this.groupBox1.Location = new System.Drawing.Point(12, 223);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(556, 178);
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
			this.lvMessageLog.Location = new System.Drawing.Point(6, 19);
			this.lvMessageLog.Name = "lvMessageLog";
			this.lvMessageLog.Size = new System.Drawing.Size(544, 153);
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
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 413);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainWindow";
			this.Text = "Concertroid Remote Debugger";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvMessageLog;
		private System.Windows.Forms.ColumnHeader chMessageSeverity;
		private System.Windows.Forms.ColumnHeader chMessageContent;
	}
}

