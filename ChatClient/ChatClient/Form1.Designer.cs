namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.IpLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.ChatTxtBox = new System.Windows.Forms.TextBox();
            this.SendMsgButton = new System.Windows.Forms.Button();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.ClientListLable = new System.Windows.Forms.Label();
            this.PortLable = new System.Windows.Forms.Label();
            this.PortTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IPtextBox
            // 
            this.IPtextBox.Location = new System.Drawing.Point(313, 12);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(170, 22);
            this.IPtextBox.TabIndex = 0;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(312, 85);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(170, 22);
            this.NameTxtBox.TabIndex = 1;
            // 
            // IpLable
            // 
            this.IpLable.AutoSize = true;
            this.IpLable.Location = new System.Drawing.Point(224, 13);
            this.IpLable.Name = "IpLable";
            this.IpLable.Size = new System.Drawing.Size(88, 17);
            this.IpLable.TabIndex = 2;
            this.IpLable.Text = "IP Address : ";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(255, 88);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(57, 17);
            this.NameLable.TabIndex = 3;
            this.NameLable.Text = "Name : ";
            // 
            // ChatTxtBox
            // 
            this.ChatTxtBox.Location = new System.Drawing.Point(13, 319);
            this.ChatTxtBox.Name = "ChatTxtBox";
            this.ChatTxtBox.Size = new System.Drawing.Size(470, 22);
            this.ChatTxtBox.TabIndex = 4;
            // 
            // SendMsgButton
            // 
            this.SendMsgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.SendMsgButton.Location = new System.Drawing.Point(13, 348);
            this.SendMsgButton.Name = "SendMsgButton";
            this.SendMsgButton.Size = new System.Drawing.Size(470, 38);
            this.SendMsgButton.TabIndex = 5;
            this.SendMsgButton.Text = "Send";
            this.SendMsgButton.UseVisualStyleBackColor = true;
            this.SendMsgButton.Click += new System.EventHandler(this.SendMsgButton_Click);
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.ItemHeight = 16;
            this.ClientListBox.Location = new System.Drawing.Point(78, 11);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(140, 100);
            this.ClientListBox.TabIndex = 6;
            // 
            // ChatBox
            // 
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.ItemHeight = 16;
            this.ChatBox.Location = new System.Drawing.Point(12, 117);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(470, 196);
            this.ChatBox.TabIndex = 7;
            // 
            // ClientListLable
            // 
            this.ClientListLable.AutoSize = true;
            this.ClientListLable.Location = new System.Drawing.Point(13, 13);
            this.ClientListLable.Name = "ClientListLable";
            this.ClientListLable.Size = new System.Drawing.Size(62, 17);
            this.ClientListLable.TabIndex = 8;
            this.ClientListLable.Text = "Clients : ";
            // 
            // PortLable
            // 
            this.PortLable.AutoSize = true;
            this.PortLable.Location = new System.Drawing.Point(266, 52);
            this.PortLable.Name = "PortLable";
            this.PortLable.Size = new System.Drawing.Size(46, 17);
            this.PortLable.TabIndex = 9;
            this.PortLable.Text = "Port : ";
            // 
            // PortTxtBox
            // 
            this.PortTxtBox.Location = new System.Drawing.Point(312, 47);
            this.PortTxtBox.Name = "PortTxtBox";
            this.PortTxtBox.Size = new System.Drawing.Size(171, 22);
            this.PortTxtBox.TabIndex = 10;
            this.PortTxtBox.Text = "11000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 398);
            this.Controls.Add(this.PortTxtBox);
            this.Controls.Add(this.PortLable);
            this.Controls.Add(this.ClientListLable);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.ClientListBox);
            this.Controls.Add(this.SendMsgButton);
            this.Controls.Add(this.ChatTxtBox);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.IpLable);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.IPtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label IpLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox ChatTxtBox;
        private System.Windows.Forms.Button SendMsgButton;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.ListBox ChatBox;
        private System.Windows.Forms.Label ClientListLable;
        private System.Windows.Forms.Label PortLable;
        private System.Windows.Forms.TextBox PortTxtBox;
    }
}

