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
    public partial class MainForm : Form
    {
        public const string VERSION = "newbeta 1";
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
    }
}
