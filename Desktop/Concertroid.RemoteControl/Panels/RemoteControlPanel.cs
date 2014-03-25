using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Net;
using System.Net.Sockets;

using System.Text;
using System.Windows.Forms;

using AwesomeControls.ActionBar;

using Concertroid.ObjectModels.Concert;

using Concertroid.Manager.Dialogs;

using Concertroid.Networking;

namespace Concertroid.Manager.Panels
{
    [DefaultEvent("ClientChanged")]
    public partial class RemoteControlPanel : UserControl
    {
        public RemoteControlPanel()
        {
            InitializeComponent();
            InitializeActionBar();
        }

        #region ActionBar Buttons
        private void InitializeActionBar()
        {
            ActionBarButton abbConnect = new ActionBarButton();
            abbConnect.Name = "abbConnect";
            abbConnect.Text = "&Connect...";
            abbConnect.Click += new EventHandler(abbConnect_Click);
            abbConnect.ToolTipText = "Connect to a rendering server on the local network";
            abbConnect.Visible = false;
            abbConnect.DisplayIndex = 0;
            ab.Items.Add(abbConnect);

            ActionBarButton abbStart = new ActionBarButton();
            abbStart.Name = "abbStart";
            abbStart.Text = "Start Show";
            abbStart.DisplayIndex = 1;
            ab.Items.Add(abbStart);

            ActionBarButton abbSettings = new ActionBarButton();
            abbSettings.Name = "abbSettings";
            abbSettings.Text = "Edit Settings...";
            abbSettings.DisplayIndex = 2;
            abbSettings.Alignment = ContentAlignment.MiddleRight;
            abbSettings.Click += new EventHandler(abbSettings_Click);
            ab.Items.Add(abbSettings);
        }

        private void abbSettings_Click(object sender, EventArgs e)
        {
            ConcertPropertiesDialog dlg = new ConcertPropertiesDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
            }
        }
        private void abbConnect_Click(object sender, EventArgs e)
        {
            ActionBarButton abbConnect = (ab.Items[0] as ActionBarButton);

            if (mvarClient != null)
            {
                mvarClient.Disconnect();
                mvarClient = null;

                txtServerHostName.Text = String.Empty;
                txtServerTitle.Text = String.Empty;
                txtServerVersion.Text = String.Empty;

                abbConnect.Text = "Connect";
                abbConnect.ToolTipText = "Connect to a rendering server on the local network";

                OnClientChanged(EventArgs.Empty);
                return;
            }

			Dialogs.ConnectToServerDialog dlg = new Dialogs.ConnectToServerDialog();
            ignore:
			if (dlg.ShowDialog() == DialogResult.OK)
			{
                mvarClient = new Client();
            retry:
                try
                {
                    mvarClient.Connect(dlg.cboServer.Text, (int)dlg.txtPort.Value);
                }
                catch (SocketException ex)
                {
                    string ErrorMessage = String.Empty;

                    switch (ex.SocketErrorCode)
                    {
                        case SocketError.TimedOut:
                        {
                            ErrorMessage = "The attempt to connect to the rendering server timed out.  Ensure that your network connection is available, the server computer is turned on, and the server software has been started.";
                            break;
                        }
                        case SocketError.ConnectionRefused:
                        {
                            ErrorMessage = "Could not connect to the rendering server.  The rendering server has most likely not been started.  Ensure the server is running, and then try again.";
                            break;
                        }
                        case SocketError.HostNotFound:
                        {
                            ErrorMessage = "Could not find the rendering server named \"" + dlg.cboServer.Text + "\".  Ensure the server computer is turned on and the server software has been started.";
                            break;
                        }
                        default:
                        {
                            ErrorMessage = "Could not connect to the rendering server.  " + ex.Message;
                            break;
                        }
                    }

                    switch (MessageBox.Show(ErrorMessage + "\r\n\r\nIf you continue to experience the problem after taking the appropriate action, please notify the developer.", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error))
                    {
                        case DialogResult.Abort:
                        {
                            return;
                        }
                        case DialogResult.Retry:
                        {
                            goto retry;
                        }
                        case DialogResult.Ignore:
                        {
                            goto ignore;
                        }
                    }
                }

                try
                {
                    // client.Authenticate(dlg.txtUserName.Text, dlg.txtPassword.Text);
                }
                catch
                {
                }

                txtServerTitle.Text = mvarClient.ServerName;
                txtServerVersion.Text = mvarClient.ServerVersion.ToString();

                abbConnect.Text = "Disconnect";
                abbConnect.ToolTipText = "Disconnect from the current rendering server";

                OnClientChanged(EventArgs.Empty);
			}
		}
        private void abbAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by M.Becker", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private ConcertObjectModel mvarConcert = null;
        public ConcertObjectModel Concert { get { return mvarConcert; } set { mvarConcert = value; RefreshEditor(); } }

        #region Events
        #region Client Changed
        public event EventHandler ClientChanged;
        protected virtual void OnClientChanged(EventArgs e)
        {
            if (ClientChanged != null) ClientChanged(this, e);
        }
        #endregion
        #endregion

        private Client mvarClient = null;
        public Client Client { get { return mvarClient; } }

        private void mnuContext_Opening(object sender, CancelEventArgs e)
        {
            if (lvSongs.Focused)
            {
                mnuContextAddNew.Text = "Add Ne&w Song...";
                mnuContextAddExisting.Text = "Add Existin&g Song...";

                mnuContextActivateNow.Visible = true;
                mnuContextActivateNext.Visible = true;

                mnuContextActivateNow.Enabled = (lvSongs.SelectedItems.Count == 1);
                mnuContextActivateNext.Enabled = (lvSongs.SelectedItems.Count == 1);

                mnuContextActivateNow.Text = "Play &Now";
                mnuContextActivateNext.Text = "Play Ne&xt";

                mnuContextCut.Enabled = (lvSongs.SelectedItems.Count > 0);
                mnuContextCopy.Enabled = (lvSongs.SelectedItems.Count > 0);
                mnuContextDelete.Enabled = (lvSongs.SelectedItems.Count > 0);

                mnuContextProperties.Enabled = (lvSongs.SelectedItems.Count == 1);

                mnuContextMoveDown.Visible = true;
                mnuContextMoveUp.Visible = true;
                mnuContextSep3.Visible = true;

                mnuContextMoveUp.Enabled = (lvSongs.SelectedItems.Count > 0);
                mnuContextMoveDown.Enabled = (lvSongs.SelectedItems.Count > 0);

                mnuContextSep2.Visible = true;
            }
            else if (lvCostumes.Focused)
            {
                mnuContextAddNew.Text = "Add Ne&w Costume...";
                mnuContextAddExisting.Text = "Add Existin&g Costume...";

                mnuContextActivateNow.Visible = true;
                mnuContextActivateNext.Visible = true;

                mnuContextActivateNow.Enabled = (lvCostumes.SelectedItems.Count == 1);
                mnuContextActivateNext.Enabled = (lvCostumes.SelectedItems.Count == 1);

                mnuContextActivateNow.Text = "Change Into &Now";
                mnuContextActivateNext.Text = "Change Into Ne&xt";

                mnuContextCut.Enabled = (lvCostumes.SelectedItems.Count > 0);
                mnuContextCopy.Enabled = (lvCostumes.SelectedItems.Count > 0);
                mnuContextDelete.Enabled = (lvCostumes.SelectedItems.Count > 0);

                mnuContextProperties.Enabled = (lvCostumes.SelectedItems.Count == 1);

                mnuContextMoveDown.Visible = false;
                mnuContextMoveUp.Visible = false;
                mnuContextSep3.Visible = false;

                mnuContextSep2.Visible = true;
            }
            else if (lvPerformers.Focused)
            {
                mnuContextAddNew.Text = "Add Ne&w Performer...";
                mnuContextAddExisting.Text = "Add Existin&g Performer...";

                mnuContextActivateNow.Visible = true;
                mnuContextActivateNext.Visible = true;

                mnuContextActivateNow.Enabled = (lvPerformers.SelectedItems.Count == 1);
                mnuContextActivateNext.Enabled = (lvPerformers.SelectedItems.Count == 1);

                mnuContextActivateNow.Text = "Switch To &Now";
                mnuContextActivateNext.Text = "Switch To Ne&xt";

                mnuContextCut.Enabled = (lvPerformers.SelectedItems.Count > 0);
                mnuContextCopy.Enabled = (lvPerformers.SelectedItems.Count > 0);
                mnuContextDelete.Enabled = (lvPerformers.SelectedItems.Count > 0);

                mnuContextProperties.Enabled = (lvPerformers.SelectedItems.Count == 1);

                mnuContextMoveDown.Visible = false;
                mnuContextMoveUp.Visible = false;
                mnuContextSep3.Visible = false;

                mnuContextSep2.Visible = true;
            }
            else if (lvPerformances.Focused)
            {
                mnuContextAddNew.Text = "Add Ne&w Performance...";
                mnuContextAddExisting.Text = "Add Existin&g Performance...";

                mnuContextActivateNow.Visible = true;
                mnuContextActivateNext.Visible = true;

                mnuContextActivateNow.Enabled = (lvPerformances.SelectedItems.Count == 1);
                mnuContextActivateNext.Enabled = (lvPerformances.SelectedItems.Count == 1);

                mnuContextActivateNow.Text = "Play &Now";
                mnuContextActivateNext.Text = "Play Ne&xt";

                mnuContextCut.Enabled = (lvPerformances.SelectedItems.Count > 0);
                mnuContextCopy.Enabled = (lvPerformances.SelectedItems.Count > 0);
                mnuContextDelete.Enabled = (lvPerformances.SelectedItems.Count > 0);

                mnuContextProperties.Enabled = (lvPerformances.SelectedItems.Count == 1);

                mnuContextMoveDown.Visible = true;
                mnuContextMoveUp.Visible = true;

                mnuContextMoveUp.Enabled = (lvPerformances.SelectedItems.Count > 0);
                mnuContextMoveDown.Enabled = (lvPerformances.SelectedItems.Count > 0);
                mnuContextSep3.Visible = true;

                mnuContextSep2.Visible = true;
            }
            else
            {
                mnuContextActivateNow.Visible = false;
                mnuContextActivateNext.Visible = false;
                mnuContextSep2.Visible = false;
            }
        }

        #region Context Menu
        private void mnuContextAddNew_Click(object sender, EventArgs e)
        {
            if (lvPerformances.Focused)
            {
                // add new performance
                PerformancePropertiesDialog dlg = new PerformancePropertiesDialog();
                dlg.Concert = mvarConcert;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else if (lvPerformers.Focused)
            {
                // add new character
                ConcertPerformer performer = CreatePerformer();
                if (performer != null)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = performer.FullName;
                    lvi.Tag = performer;
                    lvPerformers.Items.Add(lvi);
                }
            }
        }
        private void mnuContextAddExisting_Click(object sender, EventArgs e)
        {

        }
        private void mnuContextProperties_Click(object sender, EventArgs e)
        {
            if (lvPerformers.Focused && lvPerformers.SelectedItems.Count == 1)
            {
                ListViewItem lvi = (lvPerformers.SelectedItems[0]);
                EditPerformer(ref lvi);
            }
        }
        #endregion

        #region Performer
        #region Creating
        private ConcertPerformer CreatePerformer()
        {
            PerformerPropertiesDialog dlg = new PerformerPropertiesDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ConcertPerformer performer = new ConcertPerformer();
                performer.ID = Guid.NewGuid();
                performer.GivenName = dlg.txtGivenName.Text;
                performer.FamilyName = dlg.txtFamilyName.Text;

                foreach (ConcertPerformerCostume costume in dlg.Costumes)
                {
                    performer.Costumes.Add(costume);
                }
                return performer;
            }
            return null;
        }
        #endregion
        #region Editing
        private void EditPerformer(ref ConcertPerformer performer)
        {
            PerformerPropertiesDialog dlg = new PerformerPropertiesDialog();
            dlg.txtGivenName.Text = performer.GivenName;
            dlg.txtFamilyName.Text = performer.FamilyName;
            foreach (ConcertPerformerCostume costume in performer.Costumes)
            {
                dlg.Costumes.Add(costume);
            }
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                performer.GivenName = dlg.txtGivenName.Text;
                performer.FamilyName = dlg.txtFamilyName.Text;

                performer.Costumes.Clear();
                foreach (ConcertPerformerCostume costume in dlg.Costumes)
                {
                    performer.Costumes.Add(costume);
                }
            }
        }
        private void EditPerformer(ref ListViewItem lvi)
        {
            if (lvi != null)
            {
                ConcertPerformer performer = (lvi.Tag as ConcertPerformer);
                if (performer != null)
                {
                    EditPerformer(ref performer);

                    lvi.Text = performer.FullName;
                }
            }
        }
        private void lvPerformers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvi = (lvPerformers.HitTest(e.Location).Item);
            EditPerformer(ref lvi);
        }
        #endregion
        #endregion
        #region Performance
        #region Creating
        private ConcertPerformance CreatePerformance()
        {
            PerformancePropertiesDialog dlg = new PerformancePropertiesDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ConcertPerformance performance = new ConcertPerformance();
                return performance;
            }
            return null;
        }
        #endregion
        #region Editing
        private void EditPerformance(ref ConcertPerformance performance)
        {
            PerformancePropertiesDialog dlg = new PerformancePropertiesDialog();
            dlg.Concert = mvarConcert;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        private void EditPerformance(ref ListViewItem lvi)
        {
            if (lvi == null) return;

            ConcertPerformance performance = (lvi.Tag as ConcertPerformance);
            if (performance != null)
            {
                EditPerformance(ref performance);
            }
        }
        private void lvPerformances_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvi = lvPerformances.HitTest(e.Location).Item;
            EditPerformance(ref lvi);
        }
        #endregion
        #endregion
        #region Songs
        #region Creating
        private ConcertSong CreateSong()
        {
            SongPropertiesDialog dlg = new SongPropertiesDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ConcertSong song = new ConcertSong();
                return song;
            }
            return null;
        }
        #endregion
        #region Editing
        private void EditSong(ref ConcertSong song)
        {
            SongPropertiesDialog dlg = new SongPropertiesDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void EditSong(ref ListViewItem lvi)
        {
            if (lvi == null) return;

            ConcertSong song = (lvi.Tag as ConcertSong);
            if (song != null)
            {
                EditSong(ref song);
            }
        }
        private void lvSongs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvi = lvSongs.HitTest(e.Location).Item;
            EditSong(ref lvi);
        }
        #endregion
        #endregion

        public void RefreshEditor()
        {
            lvPerformances.Items.Clear();

            if (mvarConcert == null) return;

            foreach (ConcertPerformance perf in mvarConcert.Performances)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = perf.Song.Title;
                lvi.SubItems.Add(String.Empty);
                StringBuilder sb = new StringBuilder();
                foreach (ConcertSongPerformer performer in perf.Performers)
                {
                    sb.Append(performer.Performer.FullName);
                    sb.Append(" (");
                    sb.Append(performer.Costume.Name);
                    sb.Append(")");
                    if (perf.Performers.IndexOf(performer) < perf.Performers.Count - 1)
                    {
                        sb.Append("; ");
                    }
                }
                lvi.SubItems.Add(sb.ToString());

                lvPerformances.Items.Add(lvi);
            }
            foreach (ConcertMusician musician in mvarConcert.BandMusicians)
            {
            }
        }
    }
}
