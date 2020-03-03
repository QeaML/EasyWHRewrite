using System;
using System.Net;
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
                MessageBox.Show(
                     "You must specify a unique Preset ID, a Webhook URL and a Name.",
                     "EasyWH :: Error",
                     MessageBoxButtons.OK
                );
                return;
            }
            // check if preset already exists
            if(Manager.PresetExists(IDTextBox.Text))
            {
                MessageBox.Show(
                    "That preset already exists.",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
                return;
            }
            // check URL validity
            try
            {
                new Uri(URLTextBox.Text);
            }
            catch (UriFormatException)
            {
                MessageBox.Show(
                    "You must specify a valid Webhook URL.",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
                return;
            }
            // check URL reachability
            bool URLReachable;
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(URLTextBox.Text);
            Req.Timeout = 1000;
            Req.Method = "HEAD";
            try
            {
                using (HttpWebResponse Res = (HttpWebResponse)Req.GetResponse())
                {
                    URLReachable = Res.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
                URLReachable = false;
            }
            if (!URLReachable)
            {
                MessageBox.Show(
                    "The Webhook URL is unreachable.",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
                return;
            }
            // Save preset
            if (AvatarTextBox.Text == "")
                Manager.SavePreset(IDTextBox.Text, URLTextBox.Text, NickTextBox.Text);
            else
                Manager.SavePreset(IDTextBox.Text, URLTextBox.Text, NickTextBox.Text, AvatarTextBox.Text);
            // Goodbye!
            Hide();
            // Tell the new presets form we're done
            Form.Show();
            Form.RefreshItems();
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
    }
}
