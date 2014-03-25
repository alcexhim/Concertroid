namespace Concertroid.Manager.Dialogs
{
    partial class SongPerformerPropertiesDialog
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
            this.cmdBrowseCharacter = new System.Windows.Forms.Button();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.txtCostume = new System.Windows.Forms.TextBox();
            this.cmdBrowseMotion = new System.Windows.Forms.Button();
            this.txtMotion = new System.Windows.Forms.TextBox();
            this.fraAfterPerformance = new System.Windows.Forms.GroupBox();
            this.optAfterPerformanceLightsOff = new System.Windows.Forms.RadioButton();
            this.optAfterPerformanceLightsOn = new System.Windows.Forms.RadioButton();
            this.optAfterPerformanceDismissCharacter = new System.Windows.Forms.RadioButton();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdBrowseCostume = new System.Windows.Forms.Button();
            this.tbsTabs = new System.Windows.Forms.TabControl();
            this.tabAppearance = new System.Windows.Forms.TabPage();
            this.tabTransitions = new System.Windows.Forms.TabPage();
            this.fraCostumeTransitions = new System.Windows.Forms.GroupBox();
            this.cmdTransitionClear = new System.Windows.Forms.Button();
            this.cmdTransitionRemove = new System.Windows.Forms.Button();
            this.cmdTransitionModify = new System.Windows.Forms.Button();
            this.cmdTransitionAdd = new System.Windows.Forms.Button();
            this.lvCostumeTransitions = new System.Windows.Forms.ListView();
            this.chCostumeTransitionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCostumeTransitionCostume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fraAfterPerformance.SuspendLayout();
            this.tbsTabs.SuspendLayout();
            this.tabAppearance.SuspendLayout();
            this.tabTransitions.SuspendLayout();
            this.fraCostumeTransitions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBrowseCharacter
            // 
            this.cmdBrowseCharacter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseCharacter.Location = new System.Drawing.Point(6, 6);
            this.cmdBrowseCharacter.Name = "cmdBrowseCharacter";
            this.cmdBrowseCharacter.Size = new System.Drawing.Size(78, 22);
            this.cmdBrowseCharacter.TabIndex = 0;
            this.cmdBrowseCharacter.Text = "&Character";
            this.cmdBrowseCharacter.UseVisualStyleBackColor = true;
            // 
            // txtCharacter
            // 
            this.txtCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharacter.Location = new System.Drawing.Point(90, 8);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.ReadOnly = true;
            this.txtCharacter.Size = new System.Drawing.Size(260, 20);
            this.txtCharacter.TabIndex = 1;
            // 
            // txtCostume
            // 
            this.txtCostume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostume.Location = new System.Drawing.Point(90, 36);
            this.txtCostume.Name = "txtCostume";
            this.txtCostume.ReadOnly = true;
            this.txtCostume.Size = new System.Drawing.Size(260, 20);
            this.txtCostume.TabIndex = 3;
            // 
            // cmdBrowseMotion
            // 
            this.cmdBrowseMotion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseMotion.Location = new System.Drawing.Point(6, 62);
            this.cmdBrowseMotion.Name = "cmdBrowseMotion";
            this.cmdBrowseMotion.Size = new System.Drawing.Size(78, 22);
            this.cmdBrowseMotion.TabIndex = 4;
            this.cmdBrowseMotion.Text = "&Motion";
            this.cmdBrowseMotion.UseVisualStyleBackColor = true;
            // 
            // txtMotion
            // 
            this.txtMotion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotion.Location = new System.Drawing.Point(90, 64);
            this.txtMotion.Name = "txtMotion";
            this.txtMotion.ReadOnly = true;
            this.txtMotion.Size = new System.Drawing.Size(260, 20);
            this.txtMotion.TabIndex = 5;
            // 
            // fraAfterPerformance
            // 
            this.fraAfterPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraAfterPerformance.Controls.Add(this.optAfterPerformanceLightsOff);
            this.fraAfterPerformance.Controls.Add(this.optAfterPerformanceLightsOn);
            this.fraAfterPerformance.Controls.Add(this.optAfterPerformanceDismissCharacter);
            this.fraAfterPerformance.Location = new System.Drawing.Point(6, 92);
            this.fraAfterPerformance.Name = "fraAfterPerformance";
            this.fraAfterPerformance.Size = new System.Drawing.Size(344, 100);
            this.fraAfterPerformance.TabIndex = 6;
            this.fraAfterPerformance.TabStop = false;
            this.fraAfterPerformance.Text = "After performance";
            // 
            // optAfterPerformanceLightsOff
            // 
            this.optAfterPerformanceLightsOff.Location = new System.Drawing.Point(34, 71);
            this.optAfterPerformanceLightsOff.Name = "optAfterPerformanceLightsOff";
            this.optAfterPerformanceLightsOff.Size = new System.Drawing.Size(304, 20);
            this.optAfterPerformanceLightsOff.TabIndex = 2;
            this.optAfterPerformanceLightsOff.Text = "Turn lights &off but leave character on stage";
            this.optAfterPerformanceLightsOff.UseVisualStyleBackColor = true;
            // 
            // optAfterPerformanceLightsOn
            // 
            this.optAfterPerformanceLightsOn.Location = new System.Drawing.Point(34, 45);
            this.optAfterPerformanceLightsOn.Name = "optAfterPerformanceLightsOn";
            this.optAfterPerformanceLightsOn.Size = new System.Drawing.Size(304, 20);
            this.optAfterPerformanceLightsOn.TabIndex = 1;
            this.optAfterPerformanceLightsOn.Text = "&Leave character on stage with the lights on";
            this.optAfterPerformanceLightsOn.UseVisualStyleBackColor = true;
            // 
            // optAfterPerformanceDismissCharacter
            // 
            this.optAfterPerformanceDismissCharacter.Location = new System.Drawing.Point(34, 19);
            this.optAfterPerformanceDismissCharacter.Name = "optAfterPerformanceDismissCharacter";
            this.optAfterPerformanceDismissCharacter.Size = new System.Drawing.Size(304, 20);
            this.optAfterPerformanceDismissCharacter.TabIndex = 0;
            this.optAfterPerformanceDismissCharacter.Text = "&Dismiss character from stage";
            this.optAfterPerformanceDismissCharacter.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(220, 268);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(301, 268);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdBrowseCostume
            // 
            this.cmdBrowseCostume.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowseCostume.Location = new System.Drawing.Point(6, 34);
            this.cmdBrowseCostume.Name = "cmdBrowseCostume";
            this.cmdBrowseCostume.Size = new System.Drawing.Size(78, 22);
            this.cmdBrowseCostume.TabIndex = 2;
            this.cmdBrowseCostume.Text = "Co&stume";
            this.cmdBrowseCostume.UseVisualStyleBackColor = true;
            // 
            // tbsTabs
            // 
            this.tbsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsTabs.Controls.Add(this.tabAppearance);
            this.tbsTabs.Controls.Add(this.tabTransitions);
            this.tbsTabs.Location = new System.Drawing.Point(12, 12);
            this.tbsTabs.Name = "tbsTabs";
            this.tbsTabs.SelectedIndex = 0;
            this.tbsTabs.Size = new System.Drawing.Size(364, 250);
            this.tbsTabs.TabIndex = 0;
            // 
            // tabAppearance
            // 
            this.tabAppearance.Controls.Add(this.cmdBrowseCharacter);
            this.tabAppearance.Controls.Add(this.txtCharacter);
            this.tabAppearance.Controls.Add(this.cmdBrowseCostume);
            this.tabAppearance.Controls.Add(this.fraAfterPerformance);
            this.tabAppearance.Controls.Add(this.txtCostume);
            this.tabAppearance.Controls.Add(this.cmdBrowseMotion);
            this.tabAppearance.Controls.Add(this.txtMotion);
            this.tabAppearance.Location = new System.Drawing.Point(4, 22);
            this.tabAppearance.Name = "tabAppearance";
            this.tabAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppearance.Size = new System.Drawing.Size(356, 224);
            this.tabAppearance.TabIndex = 0;
            this.tabAppearance.Text = "Appearance";
            this.tabAppearance.UseVisualStyleBackColor = true;
            // 
            // tabTransitions
            // 
            this.tabTransitions.Controls.Add(this.fraCostumeTransitions);
            this.tabTransitions.Controls.Add(this.button2);
            this.tabTransitions.Controls.Add(this.textBox2);
            this.tabTransitions.Controls.Add(this.button1);
            this.tabTransitions.Controls.Add(this.textBox1);
            this.tabTransitions.Location = new System.Drawing.Point(4, 22);
            this.tabTransitions.Name = "tabTransitions";
            this.tabTransitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransitions.Size = new System.Drawing.Size(356, 224);
            this.tabTransitions.TabIndex = 1;
            this.tabTransitions.Text = "Transitions";
            this.tabTransitions.UseVisualStyleBackColor = true;
            // 
            // fraCostumeTransitions
            // 
            this.fraCostumeTransitions.Controls.Add(this.cmdTransitionClear);
            this.fraCostumeTransitions.Controls.Add(this.cmdTransitionRemove);
            this.fraCostumeTransitions.Controls.Add(this.cmdTransitionModify);
            this.fraCostumeTransitions.Controls.Add(this.cmdTransitionAdd);
            this.fraCostumeTransitions.Controls.Add(this.lvCostumeTransitions);
            this.fraCostumeTransitions.Location = new System.Drawing.Point(6, 62);
            this.fraCostumeTransitions.Name = "fraCostumeTransitions";
            this.fraCostumeTransitions.Size = new System.Drawing.Size(344, 156);
            this.fraCostumeTransitions.TabIndex = 4;
            this.fraCostumeTransitions.TabStop = false;
            this.fraCostumeTransitions.Text = "Costume transitions";
            // 
            // cmdTransitionClear
            // 
            this.cmdTransitionClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTransitionClear.Location = new System.Drawing.Point(263, 19);
            this.cmdTransitionClear.Name = "cmdTransitionClear";
            this.cmdTransitionClear.Size = new System.Drawing.Size(75, 23);
            this.cmdTransitionClear.TabIndex = 3;
            this.cmdTransitionClear.Text = "&Clear";
            this.cmdTransitionClear.UseVisualStyleBackColor = true;
            // 
            // cmdTransitionRemove
            // 
            this.cmdTransitionRemove.Location = new System.Drawing.Point(168, 19);
            this.cmdTransitionRemove.Name = "cmdTransitionRemove";
            this.cmdTransitionRemove.Size = new System.Drawing.Size(75, 23);
            this.cmdTransitionRemove.TabIndex = 2;
            this.cmdTransitionRemove.Text = "&Remove";
            this.cmdTransitionRemove.UseVisualStyleBackColor = true;
            // 
            // cmdTransitionModify
            // 
            this.cmdTransitionModify.Location = new System.Drawing.Point(87, 19);
            this.cmdTransitionModify.Name = "cmdTransitionModify";
            this.cmdTransitionModify.Size = new System.Drawing.Size(75, 23);
            this.cmdTransitionModify.TabIndex = 1;
            this.cmdTransitionModify.Text = "&Modify...";
            this.cmdTransitionModify.UseVisualStyleBackColor = true;
            // 
            // cmdTransitionAdd
            // 
            this.cmdTransitionAdd.Location = new System.Drawing.Point(6, 19);
            this.cmdTransitionAdd.Name = "cmdTransitionAdd";
            this.cmdTransitionAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdTransitionAdd.TabIndex = 0;
            this.cmdTransitionAdd.Text = "&Add...";
            this.cmdTransitionAdd.UseVisualStyleBackColor = true;
            // 
            // lvCostumeTransitions
            // 
            this.lvCostumeTransitions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCostumeTransitions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCostumeTransitionTime,
            this.chCostumeTransitionCostume});
            this.lvCostumeTransitions.FullRowSelect = true;
            this.lvCostumeTransitions.GridLines = true;
            this.lvCostumeTransitions.HideSelection = false;
            this.lvCostumeTransitions.Location = new System.Drawing.Point(6, 48);
            this.lvCostumeTransitions.Name = "lvCostumeTransitions";
            this.lvCostumeTransitions.Size = new System.Drawing.Size(332, 102);
            this.lvCostumeTransitions.TabIndex = 4;
            this.lvCostumeTransitions.UseCompatibleStateImageBehavior = false;
            this.lvCostumeTransitions.View = System.Windows.Forms.View.Details;
            // 
            // chCostumeTransitionTime
            // 
            this.chCostumeTransitionTime.Text = "Time";
            // 
            // chCostumeTransitionCostume
            // 
            this.chCostumeTransitionCostume.Text = "Costume";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(6, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Dismissal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(90, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Introduction";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(90, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            // 
            // SongPerformerPropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(388, 303);
            this.Controls.Add(this.tbsTabs);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.MinimumSize = new System.Drawing.Size(396, 311);
            this.Name = "SongPerformerPropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Performer Properties";
            this.fraAfterPerformance.ResumeLayout(false);
            this.tbsTabs.ResumeLayout(false);
            this.tabAppearance.ResumeLayout(false);
            this.tabAppearance.PerformLayout();
            this.tabTransitions.ResumeLayout(false);
            this.tabTransitions.PerformLayout();
            this.fraCostumeTransitions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrowseCharacter;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.TextBox txtCostume;
        private System.Windows.Forms.Button cmdBrowseMotion;
        private System.Windows.Forms.TextBox txtMotion;
        private System.Windows.Forms.GroupBox fraAfterPerformance;
        private System.Windows.Forms.RadioButton optAfterPerformanceLightsOff;
        private System.Windows.Forms.RadioButton optAfterPerformanceLightsOn;
        private System.Windows.Forms.RadioButton optAfterPerformanceDismissCharacter;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdBrowseCostume;
        private System.Windows.Forms.TabControl tbsTabs;
        private System.Windows.Forms.TabPage tabAppearance;
        private System.Windows.Forms.TabPage tabTransitions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox fraCostumeTransitions;
        private System.Windows.Forms.Button cmdTransitionClear;
        private System.Windows.Forms.Button cmdTransitionRemove;
        private System.Windows.Forms.Button cmdTransitionModify;
        private System.Windows.Forms.Button cmdTransitionAdd;
        private System.Windows.Forms.ListView lvCostumeTransitions;
        private System.Windows.Forms.ColumnHeader chCostumeTransitionTime;
        private System.Windows.Forms.ColumnHeader chCostumeTransitionCostume;
    }
}