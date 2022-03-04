namespace DesktopForm
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.CmdSelectBox = new System.Windows.Forms.ComboBox();
            this.AddCmdBtn = new System.Windows.Forms.Button();
            this.CmdInpuxBox = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.CmdDialogBox = new System.Windows.Forms.RichTextBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdSelectBox
            // 
            this.CmdSelectBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmdSelectBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmdSelectBox.FormattingEnabled = true;
            this.CmdSelectBox.Location = new System.Drawing.Point(470, 12);
            this.CmdSelectBox.Name = "CmdSelectBox";
            this.CmdSelectBox.Size = new System.Drawing.Size(237, 23);
            this.CmdSelectBox.Sorted = true;
            this.CmdSelectBox.TabIndex = 1;
            this.CmdSelectBox.SelectedIndexChanged += new System.EventHandler(this.CmdSelectBox_SelectedIndexChanged);
            // 
            // AddCmdBtn
            // 
            this.AddCmdBtn.Location = new System.Drawing.Point(713, 12);
            this.AddCmdBtn.Name = "AddCmdBtn";
            this.AddCmdBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCmdBtn.TabIndex = 2;
            this.AddCmdBtn.Text = "Add CMD";
            this.AddCmdBtn.UseVisualStyleBackColor = true;
            this.AddCmdBtn.Click += new System.EventHandler(this.AddCmdBtn_Click);
            // 
            // CmdInpuxBox
            // 
            this.CmdInpuxBox.Location = new System.Drawing.Point(12, 415);
            this.CmdInpuxBox.Name = "CmdInpuxBox";
            this.CmdInpuxBox.Size = new System.Drawing.Size(593, 23);
            this.CmdInpuxBox.TabIndex = 4;
            this.CmdInpuxBox.Text = "Input Text";
            this.CmdInpuxBox.Enter += new System.EventHandler(this.CmdInpuxBox_Enter);
            this.CmdInpuxBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmdInpuxBox_KeyDown);
            this.CmdInpuxBox.Leave += new System.EventHandler(this.CmdInpuxBox_Leave);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(667, 78);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // CmdDialogBox
            // 
            this.CmdDialogBox.HideSelection = false;
            this.CmdDialogBox.Location = new System.Drawing.Point(12, 41);
            this.CmdDialogBox.Name = "CmdDialogBox";
            this.CmdDialogBox.ReadOnly = true;
            this.CmdDialogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CmdDialogBox.Size = new System.Drawing.Size(593, 368);
            this.CmdDialogBox.TabIndex = 6;
            this.CmdDialogBox.Text = "";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(667, 128);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.DisconnectBtn.TabIndex = 7;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.CmdDialogBox);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.CmdInpuxBox);
            this.Controls.Add(this.AddCmdBtn);
            this.Controls.Add(this.CmdSelectBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox CmdSelectBox;
        private Button AddCmdBtn;
        private TextBox CmdInpuxBox;
        private Button ConnectBtn;
        private RichTextBox CmdDialogBox;
        private Button DisconnectBtn;
    }
}