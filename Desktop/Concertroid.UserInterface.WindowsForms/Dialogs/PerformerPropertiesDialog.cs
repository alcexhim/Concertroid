using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Concertroid.ObjectModels.Concert;

namespace Concertroid.Manager.Dialogs
{
    public partial class PerformerPropertiesDialog : Form
    {
        public PerformerPropertiesDialog()
        {
            InitializeComponent();

            base.Font = SystemFonts.MenuFont;
            
            Font miniFont = new Font(base.Font.FontFamily, 7.5f, FontStyle.Regular);
            lblCharacterNameFamily.Font = miniFont;
            lblCharacterNameGiven.Font = miniFont;
            lblListColorBackground.Font = miniFont;
            lblListColorForeground.Font = miniFont;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            foreach (ConcertPerformerCostume costume in mvarCostumes)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = costume.Name;
                if (String.IsNullOrEmpty(costume.SecondaryModelFileName))
                {
                    lvi.SubItems.Add("Replace");
                }
                else
                {
                    lvi.SubItems.Add("Overlay");
                }
                lvi.Tag = costume;
                lvCostumes.Items.Add(lvi);
            }
        }

        private void cmdCostumeAdd_Click(object sender, EventArgs e)
        {
            CostumePropertiesDialog dlg = new CostumePropertiesDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();

                ConcertPerformerCostume costume = new ConcertPerformerCostume();
                costume.Name = dlg.txtCostumeName.Text;
                costume.PrimaryModelFileName = dlg.txtPrimaryModelFileName.Text;
                costume.SecondaryModelFileName = dlg.txtSecondaryModelFileName.Text;

                lvi.Tag = costume;
                lvi.Text = dlg.txtCostumeName.Text;
                if (dlg.optCostumeModeOverlay.Checked)
                {
                    lvi.SubItems.Add("Overlay");
                }
                else if (dlg.optCostumeModeReplace.Checked)
                {
                    lvi.SubItems.Add("Replace");
                }
                lvCostumes.Items.Add(lvi);

                cmdCostumeClear.Enabled = (lvCostumes.Items.Count > 0);

                mvarCostumes.Add(costume);
            }
        }

        private void cmdCostumeModify_Click(object sender, EventArgs e)
        {
            if (lvCostumes.SelectedItems.Count == 1)
            {
                ListViewItem lvi = lvCostumes.SelectedItems[0];
                ConcertPerformerCostume costume = (lvi.Tag as ConcertPerformerCostume);
                
                CostumePropertiesDialog dlg = new CostumePropertiesDialog();
                dlg.txtCostumeName.Text = costume.Name;
                dlg.txtPrimaryModelFileName.Text = costume.PrimaryModelFileName;
                dlg.txtSecondaryModelFileName.Text = costume.SecondaryModelFileName;
                if (!String.IsNullOrEmpty(costume.SecondaryModelFileName))
                {
                    dlg.optCostumeModeOverlay.Checked = true;
                }
                else
                {
                    dlg.optCostumeModeReplace.Checked = true;
                }

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    costume.Name = dlg.txtCostumeName.Text;
                    costume.PrimaryModelFileName = dlg.txtPrimaryModelFileName.Text;
                    costume.SecondaryModelFileName = dlg.txtSecondaryModelFileName.Text;

                    lvi.Text = dlg.txtCostumeName.Text;
                    if (dlg.optCostumeModeOverlay.Checked)
                    {
                        lvi.SubItems[1].Text = "Overlay";
                    }
                    else if (dlg.optCostumeModeReplace.Checked)
                    {
                        lvi.SubItems[1].Text = "Replace";
                    }
                }
            }
        }

        private void cmdCostumeRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected costume?", "Remove Costume", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            while (lvCostumes.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvCostumes.SelectedItems[0];
                ConcertPerformerCostume costume = (lvi.Tag as ConcertPerformerCostume);
                mvarCostumes.Remove(costume);
                lvi.Remove();
            }
        }

        private List<ConcertPerformerCostume> mvarCostumes = new List<ConcertPerformerCostume>();
        public List<ConcertPerformerCostume> Costumes { get { return mvarCostumes; } }

        private void cmdCostumeClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all costumes associated with this character?", "Remove All Costumes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
            while (lvCostumes.Items.Count > 0)
            {
                ConcertPerformerCostume costume = (lvCostumes.SelectedItems[0].Tag as ConcertPerformerCostume);
                mvarCostumes.Remove(costume);
                lvCostumes.Items[0].Remove();
            }
        }

        private void cmdListColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            Panel panel = (sender as Panel);
            dlg.Color = panel.BackColor;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                panel.BackColor = dlg.Color;
            }
        }

        private void lvCostumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdCostumeModify.Enabled = (lvCostumes.SelectedItems.Count == 1);
            cmdCostumeRemove.Enabled = (lvCostumes.SelectedItems.Count > 0);
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGivenName.Text))
            {
                MessageBox.Show("Please enter at least the performer's Given Name.  A Family Name is not required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mvarCostumes.Count == 0)
            {
                MessageBox.Show("Please prepare at least one costume for the performer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
