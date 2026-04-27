namespace CSCI463Project
{
    partial class LoginPage
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
            LoginButton = new Button();
            UserIdText = new TextBox();
            PasswordText = new TextBox();
            label1 = new Label();
            LoginPanel = new Panel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(93, 318);
            LoginButton.Margin = new Padding(2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(124, 48);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // UserIdText
            // 
            UserIdText.ForeColor = Color.Black;
            UserIdText.Location = new Point(29, 203);
            UserIdText.Margin = new Padding(4);
            UserIdText.Name = "UserIdText";
            UserIdText.PlaceholderText = "UserID";
            UserIdText.Size = new Size(256, 31);
            UserIdText.TabIndex = 2;
            // 
            // PasswordText
            // 
            PasswordText.ForeColor = Color.Black;
            PasswordText.Location = new Point(29, 263);
            PasswordText.Margin = new Padding(4);
            PasswordText.Name = "PasswordText";
            PasswordText.PlaceholderText = "Password";
            PasswordText.Size = new Size(256, 31);
            PasswordText.TabIndex = 3;
            PasswordText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(39, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 70);
            label1.TabIndex = 4;
            label1.Text = "ClearPath";
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.DarkGray;
            LoginPanel.Location = new Point(0, 1);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(310, 449);
            LoginPanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PasswordText);
            panel1.Controls.Add(UserIdText);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 564);
            panel1.TabIndex = 5;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 562);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "LoginPage";
            Text = "Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private TextBox UserIdText;
        private TextBox PasswordText;
        private Label label1;
        private Panel LoginPanel;
        private Panel panel1;
    }
}
