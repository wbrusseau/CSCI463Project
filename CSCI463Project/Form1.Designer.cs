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
            LoginButton.Location = new Point(68, 240);
            LoginButton.Margin = new Padding(2, 2, 2, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(99, 38);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(292, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 466);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserIdText
            // 
            UserIdText.ForeColor = Color.Gray;
            UserIdText.Location = new Point(44, 165);
            UserIdText.Name = "UserIdText";
            UserIdText.Size = new Size(206, 31);
            UserIdText.TabIndex = 2;
            // 
            // PasswordText
            // 
            PasswordText.ForeColor = Color.Gray;
            PasswordText.Location = new Point(44, 222);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(206, 31);
            PasswordText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(231, 70);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(PasswordText);
            Controls.Add(UserIdText);
            Controls.Add(pictureBox1);
            Controls.Add(LoginButton);
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
