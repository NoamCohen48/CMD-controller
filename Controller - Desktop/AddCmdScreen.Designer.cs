namespace DesktopForm
{
    partial class AddCmdScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameInputBox = new System.Windows.Forms.TextBox();
            this.IpInputBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PortInputBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PortInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameInputBox
            // 
            this.NameInputBox.Location = new System.Drawing.Point(12, 79);
            this.NameInputBox.Name = "NameInputBox";
            this.NameInputBox.Size = new System.Drawing.Size(256, 23);
            this.NameInputBox.TabIndex = 0;
            // 
            // IpInputBox
            // 
            this.IpInputBox.Location = new System.Drawing.Point(12, 139);
            this.IpInputBox.Name = "IpInputBox";
            this.IpInputBox.Size = new System.Drawing.Size(256, 23);
            this.IpInputBox.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(36, 259);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Confirm";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(170, 259);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter New CMD";
            // 
            // PortInputBox
            // 
            this.PortInputBox.Location = new System.Drawing.Point(12, 200);
            this.PortInputBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortInputBox.Name = "PortInputBox";
            this.PortInputBox.Size = new System.Drawing.Size(256, 23);
            this.PortInputBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // AddCmdScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortInputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.IpInputBox);
            this.Controls.Add(this.NameInputBox);
            this.Name = "AddCmdScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PortInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameInputBox;
        private TextBox IpInputBox;
        private Button AddBtn;
        private Button ResetBtn;
        private Label label1;
        private NumericUpDown PortInputBox;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}