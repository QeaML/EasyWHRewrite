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
    public partial class ChatForm : Form
    {
        // WebhookHandler that communicates with the Webhook
        private readonly WebhookHandler WH;
        // Command handler
        private readonly Commands Cmd;

        public ChatForm()
        {
            InitializeComponent();
            WH = new WebhookHandler();
            Cmd = new Commands();
            Cmd.SetWH(WH);
        }

        // Changes OutputLabel.Text to Message
        // Changes to `<empty>` if Message == ""
        public void SetOutput(string Message)
        {
            if (Message == "")
            {
                OutputLabel.Text = "<empty>";
            }
            else
            {
                OutputLabel.Text = Message;
            }
        }

        // Set the info for the Webhook
        public void OpenWH(string URL, string Nick)
        {
            WH.SetInfo(URL, Nick);
        }
        public void OpenWH(string URL, string Nick, string Avatar)
        {
            WH.SetInfo(URL, Nick, Avatar);
        }

        // `Quit` button
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // `Send` button
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (ChatTextBox.Text.StartsWith("/"))
            {
                string C = ChatTextBox.Text.ToLower().Split(' ')[0].Remove(0, 1);
                string[] A = ChatTextBox.Text.Split(' ').Skip(1).ToArray();
                SetOutput(Cmd.Call(C, A));
            }
            else
            {
                SetOutput(WH.Talk(ChatTextBox.Text));
                ChatTextBox.ResetText();
            }
        }
    }
}
