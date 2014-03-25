namespace Concertroid.Manager.Dialogs
{
    partial class CostumeTransitionPropertiesDialog
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
            this.cmdBrowseCostume = new System.Windows.Forms.Button();
            this.txtCostume = new System.Windows.Forms.TextBox();
            this.txtTransition = new System.Windows.Forms.TextBox();
            this.cmdBrowseTransition = new System.Windows.Forms.Button();
            this.fraTime = new System.Windows.Forms.GroupBox();
            this.sldTime = new System.Windows.Forms.TrackBar();
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.fraTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sldTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBrowseCostume
            // 
            this.cmdBrowseCostume.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseCostume.Location = new System.Drawing.Point(12, 12);
            this.cmdBrowseCostume.Name = "cmdBrowseCostume";
            this.cmdBrowseCostume.Size = new System.Drawing.Size(78, 22);
            this.cmdBrowseCostume.TabIndex = 0;
            this.cmdBrowseCostume.Text = "&Costume";
            this.cmdBrowseCostume.UseVisualStyleBackColor = true;
            // 
            // txtCostume
            // 
            this.txtCostume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostume.Location = new System.Drawing.Point(96, 14);
            this.txtCostume.Name = "txtCostume";
            this.txtCostume.ReadOnly = true;
            this.txtCostume.Size = new System.Drawing.Size(278, 20);
            this.txtCostume.TabIndex = 1;
            // 
            // txtTransition
            // 
            this.txtTransition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransition.Location = new System.Drawing.Point(96, 42);
            this.txtTransition.Name = "txtTransition";
            this.txtTransition.ReadOnly = true;
            this.txtTransition.Size = new System.Drawing.Size(278, 20);
            this.txtTransition.TabIndex = 3;
            // 
            // cmdBrowseTransition
            // 
            this.cmdBrowseTransition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseTransition.Location = new System.Drawing.Point(12, 40);
            this.cmdBrowseTransition.Name = "cmdBrowseTransition";
            this.cmdBrowseTransition.Size = new System.Drawing.Size(78, 22);
            this.cmdBrowseTransition.TabIndex = 2;
            this.cmdBrowseTransition.Text = "&Transition";
            this.cmdBrowseTransition.UseVisualStyleBackColor = true;
            // 
            // fraTime
            // 
            this.fraTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraTime.Controls.Add(this.cmdPlay);
            this.fraTime.Controls.Add(this.txtTime);
            this.fraTime.Controls.Add(this.sldTime);
            this.fraTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fraTime.Location = new System.Drawing.Point(12, 68);
            this.fraTime.Name = "fraTime";
            this.fraTime.Size = new System.Drawing.Size(362, 73);
            this.fraTime.TabIndex = 4;
            this.fraTime.TabStop = false;
            this.fraTime.Text = "Time";
            // 
            // sldTime
            // 
            this.sldTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sldTime.Location = new System.Drawing.Point(6, 15);
            this.sldTime.Maximum = 240;
            this.sldTime.Name = "sldTime";
            this.sldTime.Size = new System.Drawing.Size(287, 42);
            this.sldTime.TabIndex = 0;
            this.sldTime.TickFrequency = 60;
            this.sldTime.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.Location = new System.Drawing.Point(299, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(57, 20);
            this.txtTime.TabIndex = 1;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdPlay.Location = new System.Drawing.Point(299, 37);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(57, 23);
            this.cmdPlay.TabIndex = 2;
            this.cmdPlay.Text = "&Play";
            this.cmdPlay.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(299, 147);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(218, 147);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 5;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // CostumeTransitionPropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(386, 182);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.fraTime);
            this.Controls.Add(this.cmdBrowseTransition);
            this.Controls.Add(this.txtTransition);
            this.Controls.Add(this.cmdBrowseCostume);
            this.Controls.Add(this.txtCostume);
            this.Name = "CostumeTransitionPropertiesDialog";
            this.Text = "Costume Transition Properties";
            this.fraTime.ResumeLayout(false);
            this.fraTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sldTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBrowseCostume;
        private System.Windows.Forms.TextBox txtCostume;
        private System.Windows.Forms.TextBox txtTransition;
        private System.Windows.Forms.Button cmdBrowseTransition;
        private System.Windows.Forms.GroupBox fraTime;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.NumericUpDown txtTime;
        private System.Windows.Forms.TrackBar sldTime;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
    }
}