namespace Concertroid.Manager.Dialogs
{
    partial class PerformerPropertiesDialog
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
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.fraCostumes = new System.Windows.Forms.GroupBox();
            this.lvCostumes = new System.Windows.Forms.ListView();
            this.chCostumeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCostumeMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdCostumeClear = new System.Windows.Forms.Button();
            this.cmdCostumeRemove = new System.Windows.Forms.Button();
            this.cmdCostumeModify = new System.Windows.Forms.Button();
            this.cmdCostumeAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.lblCharacterNameGiven = new System.Windows.Forms.Label();
            this.lblCharacterNameFamily = new System.Windows.Forms.Label();
            this.lblListColor = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblListColorBackground = new System.Windows.Forms.Label();
            this.lblListColorForeground = new System.Windows.Forms.Label();
            this.cmdListColorBackground = new System.Windows.Forms.Button();
            this.cmdListColorForeground = new System.Windows.Forms.Button();
            this.fraCostumes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCharacterName.Location = new System.Drawing.Point(12, 15);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(84, 13);
            this.lblCharacterName.TabIndex = 0;
            this.lblCharacterName.Text = "Performer name:";
            // 
            // txtGivenName
            // 
            this.txtGivenName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGivenName.Location = new System.Drawing.Point(3, 3);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(144, 20);
            this.txtGivenName.TabIndex = 1;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(329, 247);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(248, 247);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // fraCostumes
            // 
            this.fraCostumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fraCostumes.Controls.Add(this.lvCostumes);
            this.fraCostumes.Controls.Add(this.cmdCostumeClear);
            this.fraCostumes.Controls.Add(this.cmdCostumeRemove);
            this.fraCostumes.Controls.Add(this.cmdCostumeModify);
            this.fraCostumes.Controls.Add(this.cmdCostumeAdd);
            this.fraCostumes.Location = new System.Drawing.Point(12, 119);
            this.fraCostumes.Name = "fraCostumes";
            this.fraCostumes.Size = new System.Drawing.Size(392, 122);
            this.fraCostumes.TabIndex = 2;
            this.fraCostumes.TabStop = false;
            this.fraCostumes.Text = "Costumes";
            // 
            // lvCostumes
            // 
            this.lvCostumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCostumes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCostumeName,
            this.chCostumeMode});
            this.lvCostumes.FullRowSelect = true;
            this.lvCostumes.GridLines = true;
            this.lvCostumes.HideSelection = false;
            this.lvCostumes.Location = new System.Drawing.Point(6, 48);
            this.lvCostumes.Name = "lvCostumes";
            this.lvCostumes.Size = new System.Drawing.Size(380, 68);
            this.lvCostumes.TabIndex = 4;
            this.lvCostumes.UseCompatibleStateImageBehavior = false;
            this.lvCostumes.View = System.Windows.Forms.View.Details;
            this.lvCostumes.SelectedIndexChanged += new System.EventHandler(this.lvCostumes_SelectedIndexChanged);
            // 
            // chCostumeName
            // 
            this.chCostumeName.Text = "Name";
            this.chCostumeName.Width = 288;
            // 
            // chCostumeMode
            // 
            this.chCostumeMode.Text = "Mode";
            this.chCostumeMode.Width = 84;
            // 
            // cmdCostumeClear
            // 
            this.cmdCostumeClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCostumeClear.Enabled = false;
            this.cmdCostumeClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCostumeClear.Location = new System.Drawing.Point(311, 19);
            this.cmdCostumeClear.Name = "cmdCostumeClear";
            this.cmdCostumeClear.Size = new System.Drawing.Size(75, 23);
            this.cmdCostumeClear.TabIndex = 3;
            this.cmdCostumeClear.Text = "&Clear";
            this.cmdCostumeClear.UseVisualStyleBackColor = true;
            this.cmdCostumeClear.Click += new System.EventHandler(this.cmdCostumeClear_Click);
            // 
            // cmdCostumeRemove
            // 
            this.cmdCostumeRemove.Enabled = false;
            this.cmdCostumeRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCostumeRemove.Location = new System.Drawing.Point(168, 19);
            this.cmdCostumeRemove.Name = "cmdCostumeRemove";
            this.cmdCostumeRemove.Size = new System.Drawing.Size(75, 23);
            this.cmdCostumeRemove.TabIndex = 2;
            this.cmdCostumeRemove.Text = "&Remove";
            this.cmdCostumeRemove.UseVisualStyleBackColor = true;
            this.cmdCostumeRemove.Click += new System.EventHandler(this.cmdCostumeRemove_Click);
            // 
            // cmdCostumeModify
            // 
            this.cmdCostumeModify.Enabled = false;
            this.cmdCostumeModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCostumeModify.Location = new System.Drawing.Point(87, 19);
            this.cmdCostumeModify.Name = "cmdCostumeModify";
            this.cmdCostumeModify.Size = new System.Drawing.Size(75, 23);
            this.cmdCostumeModify.TabIndex = 1;
            this.cmdCostumeModify.Text = "&Modify...";
            this.cmdCostumeModify.UseVisualStyleBackColor = true;
            this.cmdCostumeModify.Click += new System.EventHandler(this.cmdCostumeModify_Click);
            // 
            // cmdCostumeAdd
            // 
            this.cmdCostumeAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCostumeAdd.Location = new System.Drawing.Point(6, 19);
            this.cmdCostumeAdd.Name = "cmdCostumeAdd";
            this.cmdCostumeAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdCostumeAdd.TabIndex = 0;
            this.cmdCostumeAdd.Text = "&Add...";
            this.cmdCostumeAdd.UseVisualStyleBackColor = true;
            this.cmdCostumeAdd.Click += new System.EventHandler(this.cmdCostumeAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtGivenName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFamilyName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCharacterNameGiven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCharacterNameFamily, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(103, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 45);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFamilyName.Location = new System.Drawing.Point(153, 3);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(145, 20);
            this.txtFamilyName.TabIndex = 3;
            // 
            // lblCharacterNameGiven
            // 
            this.lblCharacterNameGiven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCharacterNameGiven.AutoSize = true;
            this.lblCharacterNameGiven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCharacterNameGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblCharacterNameGiven.Location = new System.Drawing.Point(57, 29);
            this.lblCharacterNameGiven.Name = "lblCharacterNameGiven";
            this.lblCharacterNameGiven.Size = new System.Drawing.Size(35, 13);
            this.lblCharacterNameGiven.TabIndex = 0;
            this.lblCharacterNameGiven.Text = "&Given";
            // 
            // lblCharacterNameFamily
            // 
            this.lblCharacterNameFamily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCharacterNameFamily.AutoSize = true;
            this.lblCharacterNameFamily.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCharacterNameFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblCharacterNameFamily.Location = new System.Drawing.Point(207, 29);
            this.lblCharacterNameFamily.Name = "lblCharacterNameFamily";
            this.lblCharacterNameFamily.Size = new System.Drawing.Size(36, 13);
            this.lblCharacterNameFamily.TabIndex = 2;
            this.lblCharacterNameFamily.Text = "&Family";
            // 
            // lblListColor
            // 
            this.lblListColor.AutoSize = true;
            this.lblListColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblListColor.Location = new System.Drawing.Point(12, 66);
            this.lblListColor.Name = "lblListColor";
            this.lblListColor.Size = new System.Drawing.Size(52, 13);
            this.lblListColor.TabIndex = 0;
            this.lblListColor.Text = "List color:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmdListColorForeground, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblListColorBackground, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblListColorForeground, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmdListColorBackground, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.77778F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblListColorBackground
            // 
            this.lblListColorBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListColorBackground.AutoSize = true;
            this.lblListColorBackground.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblListColorBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblListColorBackground.Location = new System.Drawing.Point(43, 34);
            this.lblListColorBackground.Name = "lblListColorBackground";
            this.lblListColorBackground.Size = new System.Drawing.Size(63, 13);
            this.lblListColorBackground.TabIndex = 0;
            this.lblListColorBackground.Text = "Background";
            // 
            // lblListColorForeground
            // 
            this.lblListColorForeground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListColorForeground.AutoSize = true;
            this.lblListColorForeground.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblListColorForeground.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblListColorForeground.Location = new System.Drawing.Point(195, 34);
            this.lblListColorForeground.Name = "lblListColorForeground";
            this.lblListColorForeground.Size = new System.Drawing.Size(61, 13);
            this.lblListColorForeground.TabIndex = 2;
            this.lblListColorForeground.Text = "Foreground";
            // 
            // cmdListColorBackground
            // 
            this.cmdListColorBackground.BackColor = System.Drawing.SystemColors.Window;
            this.cmdListColorBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdListColorBackground.Location = new System.Drawing.Point(3, 3);
            this.cmdListColorBackground.Name = "cmdListColorBackground";
            this.cmdListColorBackground.Size = new System.Drawing.Size(144, 25);
            this.cmdListColorBackground.TabIndex = 5;
            this.cmdListColorBackground.UseVisualStyleBackColor = false;
            this.cmdListColorBackground.Click += new System.EventHandler(this.cmdListColor_Click);
            // 
            // cmdListColorForeground
            // 
            this.cmdListColorForeground.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmdListColorForeground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdListColorForeground.Location = new System.Drawing.Point(153, 3);
            this.cmdListColorForeground.Name = "cmdListColorForeground";
            this.cmdListColorForeground.Size = new System.Drawing.Size(145, 25);
            this.cmdListColorForeground.TabIndex = 6;
            this.cmdListColorForeground.UseVisualStyleBackColor = false;
            this.cmdListColorForeground.Click += new System.EventHandler(this.cmdListColor_Click);
            // 
            // PerformerPropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(416, 282);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.fraCostumes);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lblListColor);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lblCharacterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PerformerPropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Performer Properties";
            this.fraCostumes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.GroupBox fraCostumes;
        private System.Windows.Forms.ListView lvCostumes;
        private System.Windows.Forms.ColumnHeader chCostumeName;
        private System.Windows.Forms.Button cmdCostumeClear;
        private System.Windows.Forms.Button cmdCostumeRemove;
        private System.Windows.Forms.Button cmdCostumeModify;
        private System.Windows.Forms.Button cmdCostumeAdd;
        private System.Windows.Forms.ColumnHeader chCostumeMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Label lblCharacterNameGiven;
        private System.Windows.Forms.Label lblCharacterNameFamily;
        internal System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.Label lblListColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblListColorBackground;
        private System.Windows.Forms.Label lblListColorForeground;
        private System.Windows.Forms.Button cmdListColorBackground;
        private System.Windows.Forms.Button cmdListColorForeground;
    }
}