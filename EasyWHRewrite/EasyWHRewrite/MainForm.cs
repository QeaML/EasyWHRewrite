using System;
using System.Windows.Forms;

namespace EasyWHRewrite
{
    public partial class MainForm : Form
    {
        public const string VERSION = "newbeta 2";
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
            PresetsForm Login = new EasyWHRewrite.PresetsForm();
            // Show log-in window and hide current one
            Login.Show();
            Login.Activate();
            Hide();
        }
    }
}
