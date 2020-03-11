using System;
using System.Windows.Forms;
using ServiceStack;

namespace EasyWHRewrite
{
    public partial class MainForm : Form
    {
        public const string VERSION = "newbeta 7";
        public const int VERSIONNUM = 7;
        private int Pokes = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(bool CheckForUpdate)
        {
            InitializeComponent();
            if (CheckForUpdate)
            {
                UpdateCheck();
            }
        }

        private void UpdateCheck()
        {
            //UpdateLabel.Text = "Checking for updates...";

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
                        UpdateLabel.Text = "This version is out-of-date!";
                    }
                    else if (NewestVersionInt < VERSIONNUM)
                    {
                        MessageBox.Show(
                            "Your version of EasyWH may be an in-development build. (version number is higher than on GitHub)",
                            "EasyWH :: Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        UpdateLabel.Text = "This version may be an in-development build.";
                    }
                    else
                    {
                        UpdateLabel.Text = "This version is up to date!";
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = VERSION;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
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
                case 25:
                    MessageBox.Show("wow, ok. keep going.");
                    break;
                case 50:
                    MessageBox.Show("you're doing alright. keep going.");
                    break;
                case 100:
                    MessageBox.Show("you're impressing me... keep going...");
                    break;
                case 199:
                    MessageBox.Show("listen,,, the random chimp event will happen on...");
                    break;
                case 200:
                    Environment.Exit(0);
                    break;
                default:
                    MessageBox.Show("You don't wanna stop? OK.");
                    break;
            }
            #endregion
            Pokes++;
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {
            UpdateCheck();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Visit https://github.com/qeaml/EasyWHRewrite for more information.",
                "EasyWH :: Help",
                MessageBoxButtons.OK
            );
        }
    }
}
