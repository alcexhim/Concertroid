namespace Concertroid.Manager.Dialogs
{
    partial class PerformerBrowserDialog
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
            this.fraFilter = new System.Windows.Forms.GroupBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lvPerformers = new System.Windows.Forms.ListView();
            this.chPerformerFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPerformerLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPerformerAuthorization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.chkShowNotAuthorized = new System.Windows.Forms.CheckBox();
            this.fraFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // fraFilter
            // 
            this.fraFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fraFilter.Controls.Add(this.chkShowNotAuthorized);
            this.fraFilter.Controls.Add(this.lblProducer);
            this.fraFilter.Controls.Add(this.lblFilterTitle);
            this.fraFilter.Controls.Add(this.textBox2);
            this.fraFilter.Controls.Add(this.textBox1);
            this.fraFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fraFilter.Location = new System.Drawing.Point(12, 12);
            this.fraFilter.Name = "fraFilter";
            this.fraFilter.Size = new System.Drawing.Size(416, 100);
            this.fraFilter.TabIndex = 0;
            this.fraFilter.TabStop = false;
            this.fraFilter.Text = "Filter";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProducer.Location = new System.Drawing.Point(6, 48);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(59, 13);
            this.lblProducer.TabIndex = 1;
            this.lblProducer.Text = "&Last name:";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFilterTitle.Location = new System.Drawing.Point(6, 22);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(58, 13);
            this.lblFilterTitle.TabIndex = 1;
            this.lblFilterTitle.Text = "&First name:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(71, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(71, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lvPerformers
            // 
            this.lvPerformers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPerformers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPerformerFirstName,
            this.chPerformerLastName,
            this.chPerformerAuthorization});
            this.lvPerformers.FullRowSelect = true;
            this.lvPerformers.GridLines = true;
            this.lvPerformers.HideSelection = false;
            this.lvPerformers.Location = new System.Drawing.Point(12, 118);
            this.lvPerformers.MultiSelect = false;
            this.lvPerformers.Name = "lvPerformers";
            this.lvPerformers.Size = new System.Drawing.Size(416, 135);
            this.lvPerformers.TabIndex = 1;
            this.lvPerformers.UseCompatibleStateImageBehavior = false;
            this.lvPerformers.View = System.Windows.Forms.View.Details;
            // 
            // chPerformerFirstName
            // 
            this.chPerformerFirstName.Text = "First name";
            this.chPerformerFirstName.Width = 180;
            // 
            // chPerformerLastName
            // 
            this.chPerformerLastName.Text = "Last name";
            this.chPerformerLastName.Width = 105;
            // 
            // chPerformerAuthorization
            // 
            this.chPerformerAuthorization.Text = "Auth?";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(353, 259);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(272, 259);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // chkShowNotAuthorized
            // 
            this.chkShowNotAuthorized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowNotAuthorized.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkShowNotAuthorized.Location = new System.Drawing.Point(71, 71);
            this.chkShowNotAuthorized.Name = "chkShowNotAuthorized";
            this.chkShowNotAuthorized.Size = new System.Drawing.Size(339, 23);
            this.chkShowNotAuthorized.TabIndex = 2;
            this.chkShowNotAuthorized.Text = "&Show \"not authorized\" performers";
            this.chkShowNotAuthorized.UseVisualStyleBackColor = true;
            // 
            // PerformerBrowserDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(440, 294);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lvPerformers);
            this.Controls.Add(this.fraFilter);
            this.Name = "PerformerBrowserDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Performer Browser";
            this.fraFilter.ResumeLayout(false);
            this.fraFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fraFilter;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lvPerformers;
        private System.Windows.Forms.ColumnHeader chPerformerFirstName;
        private System.Windows.Forms.ColumnHeader chPerformerLastName;
        private System.Windows.Forms.ColumnHeader chPerformerAuthorization;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.CheckBox chkShowNotAuthorized;
    }
}