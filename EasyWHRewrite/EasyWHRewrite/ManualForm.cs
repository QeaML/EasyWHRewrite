using System;
using System.Net;
using System.Windows.Forms;

namespace EasyWHRewrite
{
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(true);
            Environment.Exit(0);
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            // Check if needed textboxes are filled
            if(URLTextBox.Text == "" || NickTextBox.Text == "")
            {
                // Show the user a nice error when they aren't
                MessageBox.Show(
                    "You must specify a Webhook URL and a Name.",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
            }
            else
            {
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
                // Prepare the chat window
                ChatForm C = new ChatForm();
                // Set info for the Webhook
                if (AvatarTextBox.Text == "")
                {
                    C.OpenWH(URLTextBox.Text, NickTextBox.Text);
                }
                else
                {
                    C.OpenWH(URLTextBox.Text, NickTextBox.Text, AvatarTextBox.Text);
                }
                // Show chat window and hide current window
                C.Show();
                C.Activate();
                Hide();
            }
        }
    }
}
