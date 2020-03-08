using System;
using System.Windows.Forms;
using ServiceStack;

namespace EasyWHRewrite
{
    public partial class MainForm : Form
    {
        public const string VERSION = "newbeta 6";
        public const int VERSIONNUM = 6;
        private int Pokes = 0;
        public MainForm()
        {
            string NewestVersionString;
            try
            {
                NewestVersionString = "https://raw.githubusercontent.com/QeaML/EasyWHRewrite/master/VERSION".GetStringFromUrl();

                if (NewestVersionString != null)
                {
                    int NewestVersionInt = int.Parse(NewestVersionString);
                    if (NewestVersionInt > VERSIONNUM)
                    {
                        MessageBox.Show(
                            "Your version of EasyWH is out-of-date!",
                            "EasyWH :: Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else if (NewestVersionInt < VERSIONNUM)
                    {
                        MessageBox.Show(
                            "Your version of EasyWH may be an in-development build. (version number is higher than on GitHub)",
                            "EasyWH :: Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Could not check for updates.",
                        "EasyWH :: Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show(
                    "Could not check for updates.",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = VERSION;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(true);
            Environment.Exit(0);
        }

        private void ManualButton_Click(object sender, EventArgs e)
        {
            // Create a Log-in window
            ManualForm Login = new ManualForm();
            // Show log-in window and hide current one
            Login.Show();
            Login.Activate();
            Hide();
        }

        private void PresetsButton_Click(object sender, EventArgs e)
        {
            // Create a Log-in window
            PresetsForm Login = new PresetsForm();
            // Show log-in window and hide current one
            Login.Show();
            Login.Activate();
            Hide();
        }

        private void LogoLabel_Click(object sender, EventArgs e)
        {
            #region Pokes
            switch (Pokes)
            {
                case 0:
                    MessageBox.Show("Hello");
                    break;
                case 1:
                    MessageBox.Show("Hi");
                    break;
                case 2:
                    MessageBox.Show("Sup");
                    break;
                case 3:
                    MessageBox.Show("HELLO?");
                    break;
                case 4:
                    MessageBox.Show("H E L L O ?!?!");
                    break;
                case 5:
                    MessageBox.Show("can you stop");
                    break;
                case 6:
                    MessageBox.Show("stop");
                    break;
                case 7:
                    MessageBox.Show("Really, stop.");
                    break;
                case 8:
                    MessageBox.Show("I'm not kidding. Actually stop.");
                    break;
                case 9:
                    MessageBox.Show("This isn't funny. Stop.");
                    break;
                case 10:
                    MessageBox.Show("I SAID STOP.");
                    break;
                default:
                    MessageBox.Show("You don't wanna stop? OK.");
                    break;
            }
            #endregion
            Pokes++;
        }
    }
}
