using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopForm
{
    public partial class AddCmdScreen : Form
    {
        public CMD ReturnValue1;

        public AddCmdScreen()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // clear all text boxes
            NameInputBox.Clear();
            IpInputBox.Clear();
            PortInputBox.ResetText();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // get value from numarical
            int value = Convert.ToInt32(Math.Round(PortInputBox.Value, 0));

            // save value
            this.ReturnValue1 = new CMD(NameInputBox.Text, IpInputBox.Text, value);

            // closing
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
