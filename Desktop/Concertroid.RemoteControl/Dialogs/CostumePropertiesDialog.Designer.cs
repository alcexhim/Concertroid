namespace Concertroid.Manager.Dialogs
{
    partial class CostumePropertiesDialog
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtCostumeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimaryModelFileName = new System.Windows.Forms.TextBox();
            this.cmdBrowsePrimaryModelFile = new System.Windows.Forms.Button();
            this.fraCostumeMode = new System.Windows.Forms.GroupBox();
            this.optCostumeModeReplace = new System.Windows.Forms.RadioButton();
            this.cmdBrowseSecondaryModel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.optCostumeModeOverlay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondaryModelFileName = new System.Windows.Forms.TextBox();
            this.lblSecondaryModelFileName = new System.Windows.Forms.Label();
            this.fraCostumeMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(211, 294);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(292, 294);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // txtCostumeName
            // 
            this.txtCostumeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostumeName.Location = new System.Drawing.Point(103, 12);
            this.txtCostumeName.Name = "txtCostumeName";
            this.txtCostumeName.Size = new System.Drawing.Size(264, 20);
            this.txtCostumeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costume &name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model file:";
            // 
            // txtPrimaryModelFileName
            // 
            this.txtPrimaryModelFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimaryModelFileName.Location = new System.Drawing.Point(103, 38);
            this.txtPrimaryModelFileName.Name = "txtPrimaryModelFileName";
            this.txtPrimaryModelFileName.ReadOnly = true;
            this.txtPrimaryModelFileName.Size = new System.Drawing.Size(264, 20);
            this.txtPrimaryModelFileName.TabIndex = 3;
            // 
            // cmdBrowsePrimaryModelFile
            // 
            this.cmdBrowsePrimaryModelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowsePrimaryModelFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowsePrimaryModelFile.Location = new System.Drawing.Point(292, 64);
            this.cmdBrowsePrimaryModelFile.Name = "cmdBrowsePrimaryModelFile";
            this.cmdBrowsePrimaryModelFile.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowsePrimaryModelFile.TabIndex = 4;
            this.cmdBrowsePrimaryModelFile.Text = "&Browse...";
            this.cmdBrowsePrimaryModelFile.UseVisualStyleBackColor = true;
            this.cmdBrowsePrimaryModelFile.Click += new System.EventHandler(this.cmdBrowseModelFile_Click);
            // 
            // fraCostumeMode
            // 
            this.fraCostumeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraCostumeMode.Controls.Add(this.optCostumeModeReplace);
            this.fraCostumeMode.Controls.Add(this.cmdBrowseSecondaryModel);
            this.fraCostumeMode.Controls.Add(this.label4);
            this.fraCostumeMode.Controls.Add(this.optCostumeModeOverlay);
            this.fraCostumeMode.Controls.Add(this.label3);
            this.fraCostumeMode.Controls.Add(this.txtSecondaryModelFileName);
            this.fraCostumeMode.Controls.Add(this.lblSecondaryModelFileName);
            this.fraCostumeMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fraCostumeMode.Location = new System.Drawing.Point(12, 93);
            this.fraCostumeMode.Name = "fraCostumeMode";
            this.fraCostumeMode.Size = new System.Drawing.Size(355, 195);
            this.fraCostumeMode.TabIndex = 5;
            this.fraCostumeMode.TabStop = false;
            this.fraCostumeMode.Text = "Costume mode";
            // 
            // optCostumeModeReplace
            // 
            this.optCostumeModeReplace.AutoSize = true;
            this.optCostumeModeReplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optCostumeModeReplace.Location = new System.Drawing.Point(26, 137);
            this.optCostumeModeReplace.Name = "optCostumeModeReplace";
            this.optCostumeModeReplace.Size = new System.Drawing.Size(71, 18);
            this.optCostumeModeReplace.TabIndex = 5;
            this.optCostumeModeReplace.TabStop = true;
            this.optCostumeModeReplace.Text = "&Replace";
            this.optCostumeModeReplace.UseVisualStyleBackColor = true;
            this.optCostumeModeReplace.CheckedChanged += new System.EventHandler(this.optCostumeMode_CheckedChanged);
            // 
            // cmdBrowseSecondaryModel
            // 
            this.cmdBrowseSecondaryModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowseSecondaryModel.Enabled = false;
            this.cmdBrowseSecondaryModel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseSecondaryModel.Location = new System.Drawing.Point(274, 110);
            this.cmdBrowseSecondaryModel.Name = "cmdBrowseSecondaryModel";
            this.cmdBrowseSecondaryModel.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseSecondaryModel.TabIndex = 4;
            this.cmdBrowseSecondaryModel.Text = "&Browse...";
            this.cmdBrowseSecondaryModel.UseVisualStyleBackColor = true;
            this.cmdBrowseSecondaryModel.Click += new System.EventHandler(this.cmdBrowseModelFile_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(53, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "The primary character model is the only model in use for this costume.";
            // 
            // optCostumeModeOverlay
            // 
            this.optCostumeModeOverlay.AutoSize = true;
            this.optCostumeModeOverlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optCostumeModeOverlay.Location = new System.Drawing.Point(26, 28);
            this.optCostumeModeOverlay.Name = "optCostumeModeOverlay";
            this.optCostumeModeOverlay.Size = new System.Drawing.Size(67, 18);
            this.optCostumeModeOverlay.TabIndex = 0;
            this.optCostumeModeOverlay.TabStop = true;
            this.optCostumeModeOverlay.Text = "&Overlay";
            this.optCostumeModeOverlay.UseVisualStyleBackColor = true;
            this.optCostumeModeOverlay.CheckedChanged += new System.EventHandler(this.optCostumeMode_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(53, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "The secondary costume model is overlayed with the primary character model.";
            // 
            // txtSecondaryModelFileName
            // 
            this.txtSecondaryModelFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondaryModelFileName.Location = new System.Drawing.Point(114, 84);
            this.txtSecondaryModelFileName.Name = "txtSecondaryModelFileName";
            this.txtSecondaryModelFileName.ReadOnly = true;
            this.txtSecondaryModelFileName.Size = new System.Drawing.Size(235, 20);
            this.txtSecondaryModelFileName.TabIndex = 3;
            // 
            // lblSecondaryModelFileName
            // 
            this.lblSecondaryModelFileName.AutoSize = true;
            this.lblSecondaryModelFileName.Enabled = false;
            this.lblSecondaryModelFileName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSecondaryModelFileName.Location = new System.Drawing.Point(53, 87);
            this.lblSecondaryModelFileName.Name = "lblSecondaryModelFileName";
            this.lblSecondaryModelFileName.Size = new System.Drawing.Size(55, 13);
            this.lblSecondaryModelFileName.TabIndex = 2;
            this.lblSecondaryModelFileName.Text = "Model file:";
            // 
            // CostumePropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.fraCostumeMode);
            this.Controls.Add(this.cmdBrowsePrimaryModelFile);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtPrimaryModelFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCostumeName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CostumePropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Costume Properties";
            this.fraCostumeMode.ResumeLayout(false);
            this.fraCostumeMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.TextBox txtCostumeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtPrimaryModelFileName;
        private System.Windows.Forms.Button cmdBrowsePrimaryModelFile;
        private System.Windows.Forms.GroupBox fraCostumeMode;
        internal System.Windows.Forms.RadioButton optCostumeModeReplace;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.RadioButton optCostumeModeOverlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdBrowseSecondaryModel;
        internal System.Windows.Forms.TextBox txtSecondaryModelFileName;
        private System.Windows.Forms.Label lblSecondaryModelFileName;
    }
}