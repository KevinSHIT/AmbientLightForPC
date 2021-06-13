using System;
using System.Windows.Forms;
using AmbientLightForPC.Library;
using AmbientLightForPC.Library.Controller;
using AmbientLightForPC.Plugin;

namespace AmbientLightForPC.Desktop.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tkbBrightness_Scroll(object sender, EventArgs e)
        {
            numBrightness.Value = tkbBrightness.Value;
        }

        bool hasShowedWarning = false;

        private void numBrightness_ValueChanged(object sender, EventArgs e)
        {
            tkbBrightness.Value = (int) numBrightness.Value;

            if (ckbAutoApply.Checked)
                Apply();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbBrightnessController.Items.Add(Factory.CreateController<DefaultBrightnessController>());
            cmbBrightnessController.Items.Add(Factory.CreateController<GammaBrightnessController>());
            cmbBrightnessController.SelectedIndex = 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void cmbBrightnessController_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected = cmbBrightnessController.SelectedItem;
            if (selected == null)
                return;
            BrightnessControllerBase bcb = (BrightnessControllerBase) selected;

            tkbBrightness.Value = (int) (numBrightness.Value = bcb.TryGetBrightness());
        }

        private void Apply()
        {
            object selected = cmbBrightnessController.SelectedItem;
            if (selected == null)
                return;
            BrightnessControllerBase bcb = (BrightnessControllerBase) selected;
            bcb.TrySetBrightness((byte) tkbBrightness.Value);
        }

        private void ckbAutoApply_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = !ckbAutoApply.Checked;
        }

        private void ckbOverNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOverNormal.Checked)
            {
                if (MessageBox.Show(
                    "Over 100 value may cause display unproperly! Are you sure you want to do this?",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    ckbOverNormal.Checked = false;
                }
            }

            tkbBrightness.Maximum = (int) (numBrightness.Maximum = ckbOverNormal.Checked ? 255 : 100);
        }
    }
}