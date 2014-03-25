namespace Concertroid.Manager.Dialogs
{
    partial class SongPropertiesDialog
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
            this.fraAuthorizationStatus = new System.Windows.Forms.GroupBox();
            this.optAuthorizationStatusAuthorized = new System.Windows.Forms.RadioButton();
            this.optAuthorizationStatusImplicit = new System.Windows.Forms.RadioButton();
            this.optAuthorizationStatusNotAuthorized = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.lblProducers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdSelectProducers = new System.Windows.Forms.Button();
            this.fraAuthorizationStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // fraAuthorizationStatus
            // 
            this.fraAuthorizationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraAuthorizationStatus.Controls.Add(this.optAuthorizationStatusAuthorized);
            this.fraAuthorizationStatus.Controls.Add(this.optAuthorizationStatusImplicit);
            this.fraAuthorizationStatus.Controls.Add(this.optAuthorizationStatusNotAuthorized);
            this.fraAuthorizationStatus.Location = new System.Drawing.Point(12, 93);
            this.fraAuthorizationStatus.Name = "fraAuthorizationStatus";
            this.fraAuthorizationStatus.Size = new System.Drawing.Size(453, 113);
            this.fraAuthorizationStatus.TabIndex = 5;
            this.fraAuthorizationStatus.TabStop = false;
            this.fraAuthorizationStatus.Text = "Authorization status";
            // 
            // optAuthorizationStatusAuthorized
            // 
            this.optAuthorizationStatusAuthorized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optAuthorizationStatusAuthorized.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optAuthorizationStatusAuthorized.Location = new System.Drawing.Point(26, 49);
            this.optAuthorizationStatusAuthorized.Name = "optAuthorizationStatusAuthorized";
            this.optAuthorizationStatusAuthorized.Size = new System.Drawing.Size(421, 24);
            this.optAuthorizationStatusAuthorized.TabIndex = 1;
            this.optAuthorizationStatusAuthorized.TabStop = true;
            this.optAuthorizationStatusAuthorized.Text = "&Authorized (song producers have given permission to use)";
            this.optAuthorizationStatusAuthorized.UseVisualStyleBackColor = true;
            // 
            // optAuthorizationStatusImplicit
            // 
            this.optAuthorizationStatusImplicit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optAuthorizationStatusImplicit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optAuthorizationStatusImplicit.Location = new System.Drawing.Point(26, 79);
            this.optAuthorizationStatusImplicit.Name = "optAuthorizationStatusImplicit";
            this.optAuthorizationStatusImplicit.Size = new System.Drawing.Size(421, 24);
            this.optAuthorizationStatusImplicit.TabIndex = 2;
            this.optAuthorizationStatusImplicit.TabStop = true;
            this.optAuthorizationStatusImplicit.Text = "&Implicit (song does not require authorization)";
            this.optAuthorizationStatusImplicit.UseVisualStyleBackColor = true;
            // 
            // optAuthorizationStatusNotAuthorized
            // 
            this.optAuthorizationStatusNotAuthorized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optAuthorizationStatusNotAuthorized.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optAuthorizationStatusNotAuthorized.Location = new System.Drawing.Point(26, 19);
            this.optAuthorizationStatusNotAuthorized.Name = "optAuthorizationStatusNotAuthorized";
            this.optAuthorizationStatusNotAuthorized.Size = new System.Drawing.Size(421, 24);
            this.optAuthorizationStatusNotAuthorized.TabIndex = 0;
            this.optAuthorizationStatusNotAuthorized.TabStop = true;
            this.optAuthorizationStatusNotAuthorized.Text = "&Not authorized (permission has not been obtained from song producers)";
            this.optAuthorizationStatusNotAuthorized.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(390, 215);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(309, 215);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song &title:";
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSongTitle.Location = new System.Drawing.Point(82, 12);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(383, 20);
            this.txtSongTitle.TabIndex = 1;
            // 
            // lblProducers
            // 
            this.lblProducers.AutoSize = true;
            this.lblProducers.Location = new System.Drawing.Point(12, 41);
            this.lblProducers.Name = "lblProducers";
            this.lblProducers.Size = new System.Drawing.Size(64, 13);
            this.lblProducers.TabIndex = 2;
            this.lblProducers.Text = "&Producer(s):";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(82, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 20);
            this.textBox1.TabIndex = 3;
            // 
            // cmdSelectProducers
            // 
            this.cmdSelectProducers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectProducers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSelectProducers.Location = new System.Drawing.Point(390, 64);
            this.cmdSelectProducers.Name = "cmdSelectProducers";
            this.cmdSelectProducers.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectProducers.TabIndex = 4;
            this.cmdSelectProducers.Text = "&Select...";
            this.cmdSelectProducers.UseVisualStyleBackColor = true;
            // 
            // SongPropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(477, 250);
            this.Controls.Add(this.cmdSelectProducers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProducers);
            this.Controls.Add(this.txtSongTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.fraAuthorizationStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SongPropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Song Properties";
            this.fraAuthorizationStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fraAuthorizationStatus;
        private System.Windows.Forms.RadioButton optAuthorizationStatusAuthorized;
        private System.Windows.Forms.RadioButton optAuthorizationStatusImplicit;
        private System.Windows.Forms.RadioButton optAuthorizationStatusNotAuthorized;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Label lblProducers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdSelectProducers;
    }
}