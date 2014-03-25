using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using UniversalEditor.ObjectModels.Multimedia3D.Model;

namespace Concertroid.Manager.Dialogs
{
    public partial class CostumePropertiesDialog : Form
    {
        public CostumePropertiesDialog()
        {
            InitializeComponent();
            base.Font = SystemFonts.MenuFont;
        }

        private void optCostumeMode_CheckedChanged(object sender, EventArgs e)
        {
            lblSecondaryModelFileName.Enabled = optCostumeModeOverlay.Checked;
            cmdBrowseSecondaryModel.Enabled = optCostumeModeOverlay.Checked;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCostumeName.Text))
            {
                MessageBox.Show("Please enter a name for this costume.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!optCostumeModeOverlay.Checked && !optCostumeModeReplace.Checked)
            {
                MessageBox.Show("Please select a costume mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtPrimaryModelFileName.Text))
            {
                MessageBox.Show("Please select a primary costume model file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (optCostumeModeOverlay.Checked && String.IsNullOrEmpty(txtSecondaryModelFileName.Text))
            {
                MessageBox.Show("Please select a secondary costume, or set Costume Mode to &quot;Replace&quot;.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private static ModelObjectModel dummy = new ModelObjectModel();
        private void cmdBrowseModelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = UniversalEditor.Common.Dialog.GetCommonDialogFilter(dummy.MakeReference());
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sender == cmdBrowsePrimaryModelFile)
                {
                    txtPrimaryModelFileName.Text = ofd.FileName;
                }
                else if (sender == cmdBrowseSecondaryModel)
                {
                    txtSecondaryModelFileName.Text = ofd.FileName;
                }
            }
        }
    }
}
