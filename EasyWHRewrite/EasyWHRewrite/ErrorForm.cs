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
    public partial class ErrorForm : Form
    {
        public ErrorForm(string Name, string Message)
        {
            InitializeComponent();
            Text = "EasyWH :: Error :: " + Name;
            ErrorLabel.Text = Message;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
