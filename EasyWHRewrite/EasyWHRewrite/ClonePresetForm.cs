using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyWHRewrite
{
    public partial class ClonePresetForm : Form
    {
        private readonly PresetsForm Form;
        private readonly PresetManager Manager;
        private readonly Preset Preset;
        public ClonePresetForm(PresetsForm F, PresetManager M, string ID)
        {
            InitializeComponent();

            Form = F;
            Manager = M;

            Preset = Manager.GetPreset(ID);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Goodbye!
            Hide();
            Dispose(true);
            // Tell the new presets form we're done
            Form.Show();
            Form.RefreshItems();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            // Check if needed textboxes are filled
            if (IDTextBox.Text == "")
            {
                // Show the user a nice error when they aren't
                MessageBox.Show(
                     "You must specify a unique Preset ID.",
                     "EasyWH :: Error",
                     MessageBoxButtons.OK
                );
                return;
            }
            // check if preset already exists
            if (Manager.PresetExists(IDTextBox.Text))
            {
                MessageBox.Show(
                    "That preset already exists.",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
                return;
            }
            // Save preset
            if (Preset.Avatar == null)
                Manager.SavePreset(IDTextBox.Text, Preset.URL, Preset.Nick);
            else
                Manager.SavePreset(IDTextBox.Text, Preset.URL, Preset.Nick, Preset.Avatar);
            // Goodbye!
            Hide();
            // Tell the new presets form we're done
            Form.Show();
            Form.RefreshItems();
        }
    }
}
