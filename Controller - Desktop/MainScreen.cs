namespace DesktopForm
{
    public partial class MainScreen : Form
    {
        private CMD? selectedCmd;
        bool connected = false;
        CommunicationHandler? handler;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void AddCmdBtn_Click(object sender, EventArgs e)
        {
            // opening new add window
            using (var form = new AddCmdScreen())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // get result and add to items
                    CMD val = form.ReturnValue1;

                    this.CmdSelectBox.Items.Add(val);
                }
            }

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            // if cmd has been selected
            if (selectedCmd == null)
            {
                CmdDialogBox.AppendText(">> choose CMD first\n");
                return;
            }

            // if already connected
            if (connected)
            {
                CmdDialogBox.AppendText(">> you already connected\n");
                return;
            }

            // starting connection
            CmdDialogBox.AppendText(String.Format(">> Connecting to {0}\n", selectedCmd));
            handler = new CommunicationHandler(selectedCmd);
            if (!handler.Connect())
            {
                // there was an error
                CmdDialogBox.AppendText(">> there was an error\n");
                return;
            }

            // connected
            CmdDialogBox.AppendText(">> Connected\n");
            connected = true;
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            // if cmd has been selected
            if (selectedCmd == null)
            {
                CmdDialogBox.AppendText(">> chose CMD first\n");
                return;
            }

            // if not connected
            if (!connected)
            {
                CmdDialogBox.AppendText(">> you are not connected\n");
                return;
            }

            // ending connection
            if (!handler.Disconnect())
            {
                CmdDialogBox.AppendText(">> there was an error\n");
                return;
            }

            CmdDialogBox.AppendText(">> Disconnected\n");
            connected = false;
        }

        private void CmdInpuxBox_KeyDown(object sender, KeyEventArgs e)
        {
            // if enter was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // if not connected:
                if (!connected)
                {
                    CmdDialogBox.AppendText(">> Connect to CMD first\n");
                    CmdInpuxBox.Clear();
                    return;
                }

                // connected:
                // display and clear input
                var message = CmdInpuxBox.Text;
                CmdDialogBox.AppendText(String.Concat(">> ", message, "\n"));
                CmdInpuxBox.Clear();

                // send message
                handler.Send(message);

                // receiving message
                var received = handler.Receive();
                CmdDialogBox.AppendText(String.Concat("<< ", received, "\n"));
            }
        }

        private void CmdInpuxBox_Enter(object sender, EventArgs e)
        {
            if (CmdInpuxBox.Text == "Input Text")
            {
                CmdInpuxBox.Clear();
            }
        }

        private void CmdInpuxBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CmdInpuxBox.Text))
            {
                CmdInpuxBox.Text = "Input Text";
            }
        }

        private void CmdSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCmd = (CMD)CmdSelectBox.SelectedItem;
        }
    }
}