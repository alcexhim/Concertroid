namespace Concertroid.Manager.Dialogs
{
    partial class ConcertPropertiesDialog
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
            this.lblConcertName = new System.Windows.Forms.Label();
            this.txtConcertName = new System.Windows.Forms.TextBox();
            this.fraSplashScreen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSplashScreenSetting = new System.Windows.Forms.ComboBox();
            this.chkSplashScreenEnabled = new System.Windows.Forms.CheckBox();
            this.txtImageFileName = new System.Windows.Forms.TextBox();
            this.cmdBrowseImageFileName = new System.Windows.Forms.Button();
            this.txtAudioFileName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.fraSplashScreenIntervals = new System.Windows.Forms.GroupBox();
            this.cmdSplashScreenIntervalAdd = new System.Windows.Forms.Button();
            this.cmdSplashScreenIntervalModify = new System.Windows.Forms.Button();
            this.cmdSplashScreenIntervalRemove = new System.Windows.Forms.Button();
            this.cmdSplashScreenIntervalClear = new System.Windows.Forms.Button();
            this.lvSplashScreenIntervals = new System.Windows.Forms.ListView();
            this.chSplashScreenIntervalBegin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSplashScreenIntervalEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSplashScreenIntervalVideoFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSplashScreenIntervalAudioFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSplashScreenIntervalAudioMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fraSplashScreen.SuspendLayout();
            this.fraSplashScreenIntervals.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(465, 321);
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
            this.cmdOK.Location = new System.Drawing.Point(384, 321);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // lblConcertName
            // 
            this.lblConcertName.AutoSize = true;
            this.lblConcertName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblConcertName.Location = new System.Drawing.Point(12, 15);
            this.lblConcertName.Name = "lblConcertName";
            this.lblConcertName.Size = new System.Drawing.Size(76, 13);
            this.lblConcertName.TabIndex = 0;
            this.lblConcertName.Text = "Concert &name:";
            // 
            // txtConcertName
            // 
            this.txtConcertName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcertName.Location = new System.Drawing.Point(94, 12);
            this.txtConcertName.Name = "txtConcertName";
            this.txtConcertName.Size = new System.Drawing.Size(446, 20);
            this.txtConcertName.TabIndex = 1;
            // 
            // fraSplashScreen
            // 
            this.fraSplashScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fraSplashScreen.Controls.Add(this.fraSplashScreenIntervals);
            this.fraSplashScreen.Controls.Add(this.txtAudioFileName);
            this.fraSplashScreen.Controls.Add(this.txtImageFileName);
            this.fraSplashScreen.Controls.Add(this.chkSplashScreenEnabled);
            this.fraSplashScreen.Controls.Add(this.button3);
            this.fraSplashScreen.Controls.Add(this.cmdBrowseImageFileName);
            this.fraSplashScreen.Controls.Add(this.cboSplashScreenSetting);
            this.fraSplashScreen.Controls.Add(this.label1);
            this.fraSplashScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fraSplashScreen.Location = new System.Drawing.Point(12, 38);
            this.fraSplashScreen.Name = "fraSplashScreen";
            this.fraSplashScreen.Size = new System.Drawing.Size(528, 277);
            this.fraSplashScreen.TabIndex = 2;
            this.fraSplashScreen.TabStop = false;
            this.fraSplashScreen.Text = "Splash screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change settings &for:";
            // 
            // cboSplashScreenSetting
            // 
            this.cboSplashScreenSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSplashScreenSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSplashScreenSetting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSplashScreenSetting.FormattingEnabled = true;
            this.cboSplashScreenSetting.Items.AddRange(new object[] {
            "Introduction",
            "Conclusion"});
            this.cboSplashScreenSetting.Location = new System.Drawing.Point(155, 19);
            this.cboSplashScreenSetting.Name = "cboSplashScreenSetting";
            this.cboSplashScreenSetting.Size = new System.Drawing.Size(290, 21);
            this.cboSplashScreenSetting.TabIndex = 1;
            // 
            // chkSplashScreenEnabled
            // 
            this.chkSplashScreenEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSplashScreenEnabled.AutoSize = true;
            this.chkSplashScreenEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSplashScreenEnabled.Location = new System.Drawing.Point(451, 20);
            this.chkSplashScreenEnabled.Name = "chkSplashScreenEnabled";
            this.chkSplashScreenEnabled.Size = new System.Drawing.Size(71, 18);
            this.chkSplashScreenEnabled.TabIndex = 2;
            this.chkSplashScreenEnabled.Text = "&Enabled";
            this.chkSplashScreenEnabled.UseVisualStyleBackColor = true;
            // 
            // txtImageFileName
            // 
            this.txtImageFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageFileName.Location = new System.Drawing.Point(155, 46);
            this.txtImageFileName.Name = "txtImageFileName";
            this.txtImageFileName.ReadOnly = true;
            this.txtImageFileName.Size = new System.Drawing.Size(367, 20);
            this.txtImageFileName.TabIndex = 4;
            // 
            // cmdBrowseImageFileName
            // 
            this.cmdBrowseImageFileName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseImageFileName.Location = new System.Drawing.Point(26, 44);
            this.cmdBrowseImageFileName.Name = "cmdBrowseImageFileName";
            this.cmdBrowseImageFileName.Size = new System.Drawing.Size(123, 23);
            this.cmdBrowseImageFileName.TabIndex = 3;
            this.cmdBrowseImageFileName.Text = "Image/&video filename";
            this.cmdBrowseImageFileName.UseVisualStyleBackColor = true;
            // 
            // txtAudioFileName
            // 
            this.txtAudioFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAudioFileName.Location = new System.Drawing.Point(155, 75);
            this.txtAudioFileName.Name = "txtAudioFileName";
            this.txtAudioFileName.ReadOnly = true;
            this.txtAudioFileName.Size = new System.Drawing.Size(367, 20);
            this.txtAudioFileName.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(26, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "&Audio filename";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fraSplashScreenIntervals
            // 
            this.fraSplashScreenIntervals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fraSplashScreenIntervals.Controls.Add(this.lvSplashScreenIntervals);
            this.fraSplashScreenIntervals.Controls.Add(this.cmdSplashScreenIntervalClear);
            this.fraSplashScreenIntervals.Controls.Add(this.cmdSplashScreenIntervalRemove);
            this.fraSplashScreenIntervals.Controls.Add(this.cmdSplashScreenIntervalModify);
            this.fraSplashScreenIntervals.Controls.Add(this.cmdSplashScreenIntervalAdd);
            this.fraSplashScreenIntervals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fraSplashScreenIntervals.Location = new System.Drawing.Point(26, 102);
            this.fraSplashScreenIntervals.Name = "fraSplashScreenIntervals";
            this.fraSplashScreenIntervals.Size = new System.Drawing.Size(496, 169);
            this.fraSplashScreenIntervals.TabIndex = 7;
            this.fraSplashScreenIntervals.TabStop = false;
            this.fraSplashScreenIntervals.Text = "Intervals";
            // 
            // cmdSplashScreenIntervalAdd
            // 
            this.cmdSplashScreenIntervalAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSplashScreenIntervalAdd.Location = new System.Drawing.Point(6, 19);
            this.cmdSplashScreenIntervalAdd.Name = "cmdSplashScreenIntervalAdd";
            this.cmdSplashScreenIntervalAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdSplashScreenIntervalAdd.TabIndex = 0;
            this.cmdSplashScreenIntervalAdd.Text = "Add";
            this.cmdSplashScreenIntervalAdd.UseVisualStyleBackColor = true;
            // 
            // cmdSplashScreenIntervalModify
            // 
            this.cmdSplashScreenIntervalModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSplashScreenIntervalModify.Location = new System.Drawing.Point(87, 19);
            this.cmdSplashScreenIntervalModify.Name = "cmdSplashScreenIntervalModify";
            this.cmdSplashScreenIntervalModify.Size = new System.Drawing.Size(75, 23);
            this.cmdSplashScreenIntervalModify.TabIndex = 1;
            this.cmdSplashScreenIntervalModify.Text = "Modify";
            this.cmdSplashScreenIntervalModify.UseVisualStyleBackColor = true;
            // 
            // cmdSplashScreenIntervalRemove
            // 
            this.cmdSplashScreenIntervalRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSplashScreenIntervalRemove.Location = new System.Drawing.Point(168, 19);
            this.cmdSplashScreenIntervalRemove.Name = "cmdSplashScreenIntervalRemove";
            this.cmdSplashScreenIntervalRemove.Size = new System.Drawing.Size(75, 23);
            this.cmdSplashScreenIntervalRemove.TabIndex = 2;
            this.cmdSplashScreenIntervalRemove.Text = "Remove";
            this.cmdSplashScreenIntervalRemove.UseVisualStyleBackColor = true;
            // 
            // cmdSplashScreenIntervalClear
            // 
            this.cmdSplashScreenIntervalClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSplashScreenIntervalClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSplashScreenIntervalClear.Location = new System.Drawing.Point(415, 19);
            this.cmdSplashScreenIntervalClear.Name = "cmdSplashScreenIntervalClear";
            this.cmdSplashScreenIntervalClear.Size = new System.Drawing.Size(75, 23);
            this.cmdSplashScreenIntervalClear.TabIndex = 3;
            this.cmdSplashScreenIntervalClear.Text = "Clear";
            this.cmdSplashScreenIntervalClear.UseVisualStyleBackColor = true;
            // 
            // lvSplashScreenIntervals
            // 
            this.lvSplashScreenIntervals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSplashScreenIntervals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSplashScreenIntervalBegin,
            this.chSplashScreenIntervalEndTime,
            this.chSplashScreenIntervalVideoFileName,
            this.chSplashScreenIntervalAudioFileName,
            this.chSplashScreenIntervalAudioMode});
            this.lvSplashScreenIntervals.FullRowSelect = true;
            this.lvSplashScreenIntervals.GridLines = true;
            this.lvSplashScreenIntervals.HideSelection = false;
            this.lvSplashScreenIntervals.Location = new System.Drawing.Point(6, 48);
            this.lvSplashScreenIntervals.Name = "lvSplashScreenIntervals";
            this.lvSplashScreenIntervals.Size = new System.Drawing.Size(484, 115);
            this.lvSplashScreenIntervals.TabIndex = 4;
            this.lvSplashScreenIntervals.UseCompatibleStateImageBehavior = false;
            this.lvSplashScreenIntervals.View = System.Windows.Forms.View.Details;
            // 
            // chSplashScreenIntervalBegin
            // 
            this.chSplashScreenIntervalBegin.Text = "Begin time";
            this.chSplashScreenIntervalBegin.Width = 70;
            // 
            // chSplashScreenIntervalEndTime
            // 
            this.chSplashScreenIntervalEndTime.Text = "End time";
            // 
            // chSplashScreenIntervalVideoFileName
            // 
            this.chSplashScreenIntervalVideoFileName.Text = "Image/video file";
            this.chSplashScreenIntervalVideoFileName.Width = 138;
            // 
            // chSplashScreenIntervalAudioFileName
            // 
            this.chSplashScreenIntervalAudioFileName.Text = "Audio file";
            this.chSplashScreenIntervalAudioFileName.Width = 125;
            // 
            // chSplashScreenIntervalAudioMode
            // 
            this.chSplashScreenIntervalAudioMode.Text = "Audio mode";
            this.chSplashScreenIntervalAudioMode.Width = 84;
            // 
            // ConcertPropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(552, 356);
            this.Controls.Add(this.fraSplashScreen);
            this.Controls.Add(this.txtConcertName);
            this.Controls.Add(this.lblConcertName);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Name = "ConcertPropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Concert Properties";
            this.fraSplashScreen.ResumeLayout(false);
            this.fraSplashScreen.PerformLayout();
            this.fraSplashScreenIntervals.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label lblConcertName;
        private System.Windows.Forms.TextBox txtConcertName;
        private System.Windows.Forms.GroupBox fraSplashScreen;
        private System.Windows.Forms.CheckBox chkSplashScreenEnabled;
        private System.Windows.Forms.ComboBox cboSplashScreenSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImageFileName;
        private System.Windows.Forms.Button cmdBrowseImageFileName;
        private System.Windows.Forms.TextBox txtAudioFileName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox fraSplashScreenIntervals;
        private System.Windows.Forms.ListView lvSplashScreenIntervals;
        private System.Windows.Forms.ColumnHeader chSplashScreenIntervalBegin;
        private System.Windows.Forms.ColumnHeader chSplashScreenIntervalEndTime;
        private System.Windows.Forms.ColumnHeader chSplashScreenIntervalVideoFileName;
        private System.Windows.Forms.ColumnHeader chSplashScreenIntervalAudioFileName;
        private System.Windows.Forms.ColumnHeader chSplashScreenIntervalAudioMode;
        private System.Windows.Forms.Button cmdSplashScreenIntervalClear;
        private System.Windows.Forms.Button cmdSplashScreenIntervalRemove;
        private System.Windows.Forms.Button cmdSplashScreenIntervalModify;
        private System.Windows.Forms.Button cmdSplashScreenIntervalAdd;
    }
}