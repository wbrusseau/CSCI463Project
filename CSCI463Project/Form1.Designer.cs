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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            LoginButton = new Button();
            UserIdText = new TextBox();
            PasswordText = new TextBox();
            label1 = new Label();
            LoginPanel = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Font = new Font("Segoe UI", 48F);
            label1.Location = new Point(471, 318);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(455, 128);
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
            panel1.Controls.Add(PasswordText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UserIdText);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 564);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F);
            label2.Location = new Point(80, 49);
            label2.Name = "label2";
            label2.Size = new Size(157, 70);
            label2.TabIndex = 6;
            label2.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(584, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 177);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 562);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "LoginPage";
            Text = "Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox UserIdText;
        private TextBox PasswordText;
        private Label label1;
        private Panel LoginPanel;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
