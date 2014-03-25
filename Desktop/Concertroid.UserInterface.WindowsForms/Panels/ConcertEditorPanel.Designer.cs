namespace Concertroid.Manager.Panels
{
    partial class ConcertEditorPanel
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
            this.tbsTabs = new System.Windows.Forms.TabControl();
            this.tabConcert = new System.Windows.Forms.TabPage();
            this.tabBand = new System.Windows.Forms.TabPage();
            this.tabGuests = new System.Windows.Forms.TabPage();
            this.tabPerformers = new System.Windows.Forms.TabPage();
            this.tabSongs = new System.Windows.Forms.TabPage();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.chSongTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSongProducers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSongPerformers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSongAuthorized = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPerformers = new System.Windows.Forms.ListView();
            this.chPerformerGivenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPerformerFamilyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGuests = new System.Windows.Forms.ListView();
            this.chGuestGivenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGuestFamilyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGuestInstrument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblBandTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lvBandMusicians = new System.Windows.Forms.ListView();
            this.chBandGivenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBandFamilyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBandInstrument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBandTitle = new System.Windows.Forms.TextBox();
            this.lblBandTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtConcertTitle = new System.Windows.Forms.TextBox();
            this.lblConcertTitle = new System.Windows.Forms.Label();
            this.tbsTabs.SuspendLayout();
            this.tabConcert.SuspendLayout();
            this.tabBand.SuspendLayout();
            this.tabGuests.SuspendLayout();
            this.tabPerformers.SuspendLayout();
            this.tabSongs.SuspendLayout();
            this.tblBandTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbsTabs
            // 
            this.tbsTabs.Controls.Add(this.tabConcert);
            this.tbsTabs.Controls.Add(this.tabBand);
            this.tbsTabs.Controls.Add(this.tabGuests);
            this.tbsTabs.Controls.Add(this.tabPerformers);
            this.tbsTabs.Controls.Add(this.tabSongs);
            this.tbsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbsTabs.Location = new System.Drawing.Point(0, 0);
            this.tbsTabs.Name = "tbsTabs";
            this.tbsTabs.SelectedIndex = 0;
            this.tbsTabs.Size = new System.Drawing.Size(492, 295);
            this.tbsTabs.TabIndex = 0;
            // 
            // tabConcert
            // 
            this.tabConcert.Controls.Add(this.tableLayoutPanel1);
            this.tabConcert.Location = new System.Drawing.Point(4, 22);
            this.tabConcert.Name = "tabConcert";
            this.tabConcert.Padding = new System.Windows.Forms.Padding(3);
            this.tabConcert.Size = new System.Drawing.Size(484, 269);
            this.tabConcert.TabIndex = 0;
            this.tabConcert.Text = "Concert";
            this.tabConcert.UseVisualStyleBackColor = true;
            // 
            // tabBand
            // 
            this.tabBand.Controls.Add(this.lvBandMusicians);
            this.tabBand.Controls.Add(this.tblBandTitle);
            this.tabBand.Location = new System.Drawing.Point(4, 22);
            this.tabBand.Name = "tabBand";
            this.tabBand.Padding = new System.Windows.Forms.Padding(3);
            this.tabBand.Size = new System.Drawing.Size(484, 269);
            this.tabBand.TabIndex = 1;
            this.tabBand.Text = "Band";
            this.tabBand.UseVisualStyleBackColor = true;
            // 
            // tabGuests
            // 
            this.tabGuests.Controls.Add(this.lvGuests);
            this.tabGuests.Location = new System.Drawing.Point(4, 22);
            this.tabGuests.Name = "tabGuests";
            this.tabGuests.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuests.Size = new System.Drawing.Size(484, 269);
            this.tabGuests.TabIndex = 2;
            this.tabGuests.Text = "Guests";
            this.tabGuests.UseVisualStyleBackColor = true;
            // 
            // tabPerformers
            // 
            this.tabPerformers.Controls.Add(this.lvPerformers);
            this.tabPerformers.Location = new System.Drawing.Point(4, 22);
            this.tabPerformers.Name = "tabPerformers";
            this.tabPerformers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerformers.Size = new System.Drawing.Size(484, 269);
            this.tabPerformers.TabIndex = 3;
            this.tabPerformers.Text = "Performers";
            this.tabPerformers.UseVisualStyleBackColor = true;
            // 
            // tabSongs
            // 
            this.tabSongs.Controls.Add(this.lvSongs);
            this.tabSongs.Location = new System.Drawing.Point(4, 22);
            this.tabSongs.Name = "tabSongs";
            this.tabSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabSongs.Size = new System.Drawing.Size(484, 269);
            this.tabSongs.TabIndex = 4;
            this.tabSongs.Text = "Songs";
            this.tabSongs.UseVisualStyleBackColor = true;
            // 
            // lvSongs
            // 
            this.lvSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSongTitle,
            this.chSongProducers,
            this.chSongPerformers,
            this.chSongAuthorized});
            this.lvSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSongs.FullRowSelect = true;
            this.lvSongs.GridLines = true;
            this.lvSongs.HideSelection = false;
            this.lvSongs.Location = new System.Drawing.Point(3, 3);
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.Size = new System.Drawing.Size(478, 263);
            this.lvSongs.TabIndex = 0;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.Details;
            // 
            // chSongTitle
            // 
            this.chSongTitle.Text = "Title";
            this.chSongTitle.Width = 196;
            // 
            // chSongProducers
            // 
            this.chSongProducers.Text = "Producer(s)";
            this.chSongProducers.Width = 118;
            // 
            // chSongPerformers
            // 
            this.chSongPerformers.Text = "Performer(s)";
            this.chSongPerformers.Width = 102;
            // 
            // chSongAuthorized
            // 
            this.chSongAuthorized.Text = "Auth?";
            this.chSongAuthorized.Width = 44;
            // 
            // lvPerformers
            // 
            this.lvPerformers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPerformerGivenName,
            this.chPerformerFamilyName});
            this.lvPerformers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPerformers.FullRowSelect = true;
            this.lvPerformers.GridLines = true;
            this.lvPerformers.HideSelection = false;
            this.lvPerformers.Location = new System.Drawing.Point(3, 3);
            this.lvPerformers.Name = "lvPerformers";
            this.lvPerformers.Size = new System.Drawing.Size(478, 263);
            this.lvPerformers.TabIndex = 1;
            this.lvPerformers.UseCompatibleStateImageBehavior = false;
            this.lvPerformers.View = System.Windows.Forms.View.Details;
            // 
            // chPerformerGivenName
            // 
            this.chPerformerGivenName.Text = "Given name";
            this.chPerformerGivenName.Width = 196;
            // 
            // chPerformerFamilyName
            // 
            this.chPerformerFamilyName.Text = "Family name";
            this.chPerformerFamilyName.Width = 118;
            // 
            // lvGuests
            // 
            this.lvGuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGuestGivenName,
            this.chGuestFamilyName,
            this.chGuestInstrument});
            this.lvGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGuests.FullRowSelect = true;
            this.lvGuests.GridLines = true;
            this.lvGuests.HideSelection = false;
            this.lvGuests.Location = new System.Drawing.Point(3, 3);
            this.lvGuests.Name = "lvGuests";
            this.lvGuests.Size = new System.Drawing.Size(478, 263);
            this.lvGuests.TabIndex = 2;
            this.lvGuests.UseCompatibleStateImageBehavior = false;
            this.lvGuests.View = System.Windows.Forms.View.Details;
            // 
            // chGuestGivenName
            // 
            this.chGuestGivenName.Text = "Given name";
            this.chGuestGivenName.Width = 196;
            // 
            // chGuestFamilyName
            // 
            this.chGuestFamilyName.Text = "Family name";
            this.chGuestFamilyName.Width = 118;
            // 
            // chGuestInstrument
            // 
            this.chGuestInstrument.Text = "Instrument";
            this.chGuestInstrument.Width = 122;
            // 
            // tblBandTitle
            // 
            this.tblBandTitle.ColumnCount = 2;
            this.tblBandTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblBandTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBandTitle.Controls.Add(this.txtBandTitle, 1, 0);
            this.tblBandTitle.Controls.Add(this.lblBandTitle, 0, 0);
            this.tblBandTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBandTitle.Location = new System.Drawing.Point(3, 3);
            this.tblBandTitle.Name = "tblBandTitle";
            this.tblBandTitle.RowCount = 1;
            this.tblBandTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBandTitle.Size = new System.Drawing.Size(478, 29);
            this.tblBandTitle.TabIndex = 0;
            // 
            // lvBandMusicians
            // 
            this.lvBandMusicians.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBandGivenName,
            this.chBandFamilyName,
            this.chBandInstrument});
            this.lvBandMusicians.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBandMusicians.FullRowSelect = true;
            this.lvBandMusicians.GridLines = true;
            this.lvBandMusicians.HideSelection = false;
            this.lvBandMusicians.Location = new System.Drawing.Point(3, 32);
            this.lvBandMusicians.Name = "lvBandMusicians";
            this.lvBandMusicians.Size = new System.Drawing.Size(478, 234);
            this.lvBandMusicians.TabIndex = 2;
            this.lvBandMusicians.UseCompatibleStateImageBehavior = false;
            this.lvBandMusicians.View = System.Windows.Forms.View.Details;
            // 
            // chBandGivenName
            // 
            this.chBandGivenName.Text = "Given name";
            this.chBandGivenName.Width = 196;
            // 
            // chBandFamilyName
            // 
            this.chBandFamilyName.Text = "Family name";
            this.chBandFamilyName.Width = 118;
            // 
            // chBandInstrument
            // 
            this.chBandInstrument.Text = "Instrument";
            this.chBandInstrument.Width = 127;
            // 
            // txtBandTitle
            // 
            this.txtBandTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBandTitle.Location = new System.Drawing.Point(75, 4);
            this.txtBandTitle.Name = "txtBandTitle";
            this.txtBandTitle.Size = new System.Drawing.Size(400, 20);
            this.txtBandTitle.TabIndex = 0;
            // 
            // lblBandTitle
            // 
            this.lblBandTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBandTitle.AutoSize = true;
            this.lblBandTitle.Location = new System.Drawing.Point(3, 8);
            this.lblBandTitle.Name = "lblBandTitle";
            this.lblBandTitle.Size = new System.Drawing.Size(54, 13);
            this.lblBandTitle.TabIndex = 1;
            this.lblBandTitle.Text = "Band &title:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtConcertTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblConcertTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 29);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtConcertTitle
            // 
            this.txtConcertTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcertTitle.Location = new System.Drawing.Point(75, 4);
            this.txtConcertTitle.Name = "txtConcertTitle";
            this.txtConcertTitle.Size = new System.Drawing.Size(400, 20);
            this.txtConcertTitle.TabIndex = 0;
            // 
            // lblConcertTitle
            // 
            this.lblConcertTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConcertTitle.AutoSize = true;
            this.lblConcertTitle.Location = new System.Drawing.Point(3, 8);
            this.lblConcertTitle.Name = "lblConcertTitle";
            this.lblConcertTitle.Size = new System.Drawing.Size(66, 13);
            this.lblConcertTitle.TabIndex = 1;
            this.lblConcertTitle.Text = "Concert &title:";
            // 
            // ConcertEditorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbsTabs);
            this.Name = "ConcertEditorPanel";
            this.Size = new System.Drawing.Size(492, 295);
            this.tbsTabs.ResumeLayout(false);
            this.tabConcert.ResumeLayout(false);
            this.tabBand.ResumeLayout(false);
            this.tabGuests.ResumeLayout(false);
            this.tabPerformers.ResumeLayout(false);
            this.tabSongs.ResumeLayout(false);
            this.tblBandTitle.ResumeLayout(false);
            this.tblBandTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbsTabs;
        private System.Windows.Forms.TabPage tabConcert;
        private System.Windows.Forms.TabPage tabBand;
        private System.Windows.Forms.TabPage tabGuests;
        private System.Windows.Forms.TabPage tabPerformers;
        private System.Windows.Forms.TabPage tabSongs;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.ColumnHeader chSongTitle;
        private System.Windows.Forms.ColumnHeader chSongProducers;
        private System.Windows.Forms.ColumnHeader chSongPerformers;
        private System.Windows.Forms.ColumnHeader chSongAuthorized;
        private System.Windows.Forms.ListView lvPerformers;
        private System.Windows.Forms.ColumnHeader chPerformerGivenName;
        private System.Windows.Forms.ColumnHeader chPerformerFamilyName;
        private System.Windows.Forms.ListView lvGuests;
        private System.Windows.Forms.ColumnHeader chGuestGivenName;
        private System.Windows.Forms.ColumnHeader chGuestFamilyName;
        private System.Windows.Forms.ColumnHeader chGuestInstrument;
        private System.Windows.Forms.ListView lvBandMusicians;
        private System.Windows.Forms.ColumnHeader chBandGivenName;
        private System.Windows.Forms.ColumnHeader chBandFamilyName;
        private System.Windows.Forms.ColumnHeader chBandInstrument;
        private System.Windows.Forms.TableLayoutPanel tblBandTitle;
        private System.Windows.Forms.TextBox txtBandTitle;
        private System.Windows.Forms.Label lblBandTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtConcertTitle;
        private System.Windows.Forms.Label lblConcertTitle;
    }
}
