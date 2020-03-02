using System;
using System.Windows.Forms;

namespace EasyWHRewrite
{
    public partial class MainForm : Form
    {
        public const string VERSION = "newbeta 2";
        private int Pokes = 0;
        public MainForm()
        {
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
