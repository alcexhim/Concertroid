namespace Concertroid.Manager.Dialogs
{
    partial class PerformancePropertiesDialog
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lblSong = new System.Windows.Forms.Label();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.cmdBrowseSong = new System.Windows.Forms.Button();
            this.fraPerformers = new System.Windows.Forms.GroupBox();
            this.lvPerformanceCharacters = new System.Windows.Forms.ListView();
            this.chCharacterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCharacterCostume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdSongPerformerClear = new System.Windows.Forms.Button();
            this.cmdSongPerformerRemove = new System.Windows.Forms.Button();
            this.cmdSongPerformerModify = new System.Windows.Forms.Button();
            this.cmdSongPerformerAdd = new System.Windows.Forms.Button();
            this.fraPerformers.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(304, 211);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(223, 211);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSong.Location = new System.Drawing.Point(12, 17);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(35, 13);
            this.lblSong.TabIndex = 0;
            this.lblSong.Text = "&Song:";
            // 
            // txtSong
            // 
            this.txtSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSong.Location = new System.Drawing.Point(74, 14);
            this.txtSong.Name = "txtSong";
            this.txtSong.ReadOnly = true;
            this.txtSong.Size = new System.Drawing.Size(276, 20);
            this.txtSong.TabIndex = 1;
            // 
            // cmdBrowseSong
            // 
            this.cmdBrowseSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowseSong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseSong.Location = new System.Drawing.Point(356, 12);
            this.cmdBrowseSong.Name = "cmdBrowseSong";
            this.cmdBrowseSong.Size = new System.Drawing.Size(23, 23);
            this.cmdBrowseSong.TabIndex = 2;
            this.cmdBrowseSong.Text = "...";
            this.cmdBrowseSong.UseVisualStyleBackColor = true;
            this.cmdBrowseSong.Click += new System.EventHandler(this.cmdBrowseSong_Click);
            // 
            // fraPerformers
            // 
            this.fraPerformers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraPerformers.Controls.Add(this.lvPerformanceCharacters);
            this.fraPerformers.Controls.Add(this.cmdSongPerformerClear);
            this.fraPerformers.Controls.Add(this.cmdSongPerformerRemove);
            this.fraPerformers.Controls.Add(this.cmdSongPerformerModify);
            this.fraPerformers.Controls.Add(this.cmdSongPerformerAdd);
            this.fraPerformers.Location = new System.Drawing.Point(12, 41);
            this.fraPerformers.Name = "fraPerformers";
            this.fraPerformers.Size = new System.Drawing.Size(367, 164);
            this.fraPerformers.TabIndex = 3;
            this.fraPerformers.TabStop = false;
            this.fraPerformers.Text = "Performers";
            // 
            // lvPerformanceCharacters
            // 
            this.lvPerformanceCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPerformanceCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCharacterName,
            this.chCharacterCostume});
            this.lvPerformanceCharacters.FullRowSelect = true;
            this.lvPerformanceCharacters.GridLines = true;
            this.lvPerformanceCharacters.HideSelection = false;
            this.lvPerformanceCharacters.Location = new System.Drawing.Point(6, 48);
            this.lvPerformanceCharacters.Name = "lvPerformanceCharacters";
            this.lvPerformanceCharacters.Size = new System.Drawing.Size(355, 110);
            this.lvPerformanceCharacters.TabIndex = 4;
            this.lvPerformanceCharacters.UseCompatibleStateImageBehavior = false;
            this.lvPerformanceCharacters.View = System.Windows.Forms.View.Details;
            // 
            // chCharacterName
            // 
            this.chCharacterName.Text = "Name";
            this.chCharacterName.Width = 209;
            // 
            // chCharacterCostume
            // 
            this.chCharacterCostume.Text = "Costume";
            this.chCharacterCostume.Width = 135;
            // 
            // cmdSongPerformerClear
            // 
            this.cmdSongPerformerClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSongPerformerClear.Enabled = false;
            this.cmdSongPerformerClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSongPerformerClear.Location = new System.Drawing.Point(286, 19);
            this.cmdSongPerformerClear.Name = "cmdSongPerformerClear";
            this.cmdSongPerformerClear.Size = new System.Drawing.Size(75, 23);
            this.cmdSongPerformerClear.TabIndex = 3;
            this.cmdSongPerformerClear.Text = "&Clear";
            this.cmdSongPerformerClear.UseVisualStyleBackColor = true;
            this.cmdSongPerformerClear.Click += new System.EventHandler(this.cmdSongPerformerClear_Click);
            // 
            // cmdSongPerformerRemove
            // 
            this.cmdSongPerformerRemove.Enabled = false;
            this.cmdSongPerformerRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSongPerformerRemove.Location = new System.Drawing.Point(168, 19);
            this.cmdSongPerformerRemove.Name = "cmdSongPerformerRemove";
            this.cmdSongPerformerRemove.Size = new System.Drawing.Size(75, 23);
            this.cmdSongPerformerRemove.TabIndex = 2;
            this.cmdSongPerformerRemove.Text = "&Remove";
            this.cmdSongPerformerRemove.UseVisualStyleBackColor = true;
            this.cmdSongPerformerRemove.Click += new System.EventHandler(this.cmdSongPerformerRemove_Click);
            // 
            // cmdSongPerformerModify
            // 
            this.cmdSongPerformerModify.Enabled = false;
            this.cmdSongPerformerModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSongPerformerModify.Location = new System.Drawing.Point(87, 19);
            this.cmdSongPerformerModify.Name = "cmdSongPerformerModify";
            this.cmdSongPerformerModify.Size = new System.Drawing.Size(75, 23);
            this.cmdSongPerformerModify.TabIndex = 1;
            this.cmdSongPerformerModify.Text = "&Modify...";
            this.cmdSongPerformerModify.UseVisualStyleBackColor = true;
            this.cmdSongPerformerModify.Click += new System.EventHandler(this.cmdSongPerformerModify_Click);
            // 
            // cmdSongPerformerAdd
            // 
            this.cmdSongPerformerAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSongPerformerAdd.Location = new System.Drawing.Point(6, 19);
            this.cmdSongPerformerAdd.Name = "cmdSongPerformerAdd";
            this.cmdSongPerformerAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdSongPerformerAdd.TabIndex = 0;
            this.cmdSongPerformerAdd.Text = "&Add...";
            this.cmdSongPerformerAdd.UseVisualStyleBackColor = true;
            this.cmdSongPerformerAdd.Click += new System.EventHandler(this.cmdSongPerformerAdd_Click);
            // 
            // PerformancePropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(391, 246);
            this.Controls.Add(this.fraPerformers);
            this.Controls.Add(this.cmdBrowseSong);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Name = "PerformancePropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Performance Properties";
            this.fraPerformers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Button cmdBrowseSong;
        private System.Windows.Forms.GroupBox fraPerformers;
        private System.Windows.Forms.ListView lvPerformanceCharacters;
        private System.Windows.Forms.ColumnHeader chCharacterName;
        private System.Windows.Forms.ColumnHeader chCharacterCostume;
        private System.Windows.Forms.Button cmdSongPerformerAdd;
        private System.Windows.Forms.Button cmdSongPerformerClear;
        private System.Windows.Forms.Button cmdSongPerformerRemove;
        private System.Windows.Forms.Button cmdSongPerformerModify;

    }
}