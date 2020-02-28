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
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            // Check if needed textboxes are filled
            if(URLTextBox.Text == "" || NickTextBox.Text == "")
            {
                // Show the user a nice error when they aren't
                ErrorForm E = new ErrorForm("NoURLOrName", "You must specify a Webhook URL and a Name.");
                E.Show();
                E.Activate();
            }
            else
            {
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
