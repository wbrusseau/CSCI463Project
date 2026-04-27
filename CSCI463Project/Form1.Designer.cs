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
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(85, 299);
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
            UserIdText.Location = new Point(44, 164);
            UserIdText.Name = "UserIdText";
            UserIdText.PlaceholderText = "UserID";
            UserIdText.Size = new Size(206, 31);
            UserIdText.TabIndex = 2;
            // 
            // PasswordText
            // 
            PasswordText.ForeColor = Color.Black;
            PasswordText.Location = new Point(44, 221);
            PasswordText.Name = "PasswordText";
            PasswordText.PlaceholderText = "Password";
            PasswordText.Size = new Size(206, 31);
            PasswordText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(246, 70);
            label1.TabIndex = 4;
            label1.Text = "ClearPath";
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.DarkGray;
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(PasswordText);
            LoginPanel.Controls.Add(UserIdText);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Location = new Point(0, 1);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(310, 449);
            LoginPanel.TabIndex = 5;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPanel);
            Name = "LoginPage";
            Text = "Login Page";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private TextBox UserIdText;
        private TextBox PasswordText;
        private Label label1;
        private Panel LoginPanel;
    }
}
