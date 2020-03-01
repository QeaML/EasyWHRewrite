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
    public partial class NewPresetForm : Form
    {
        private readonly PresetsForm Form;
        private readonly PresetManager Manager;
        public NewPresetForm(PresetsForm F, PresetManager M)
        {
            InitializeComponent();
            Form = F;
            Manager = M;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            // Check if needed textboxes are filled
            if (IDTextBox.Text == "" || URLTextBox.Text == "" || NickTextBox.Text == "")
            {
                // Show the user a nice error when they aren't
                ErrorForm E = new ErrorForm("RequiredTextboxMissing", "You must specify a unique Preset ID, a Webhook URL and a Name.");
                E.Show();
                E.Activate();
            }
            else
            {
                // Save preset
                if(AvatarTextBox.Text == "")
                    Manager.SavePreset(IDTextBox.Text, URLTextBox.Text, NickTextBox.Text);
                else
                    Manager.SavePreset(IDTextBox.Text, URLTextBox.Text, NickTextBox.Text, AvatarTextBox.Text);
                // Goodbye!
                Hide();
                // Tell the new presets form we're done
                Form.Show();
                Form.RefreshItems();
            }
        }
    }
}
