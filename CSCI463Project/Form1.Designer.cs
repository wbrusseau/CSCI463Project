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
            pictureBox1 = new PictureBox();
            UserIdText = new TextBox();
            PasswordText = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(85, 300);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(124, 48);
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
            UserIdText.Text = "UserID";
            UserIdText.TextChanged += UserIdText_TextChanged;
            // 
            // PasswordText
            // 
            PasswordText.ForeColor = Color.Gray;
            PasswordText.Location = new Point(44, 222);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(206, 31);
            PasswordText.TabIndex = 3;
            PasswordText.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(231, 70);
            label1.TabIndex = 4;
            label1.Text = "Software";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private PictureBox pictureBox1;
        private TextBox UserIdText;
        private TextBox PasswordText;
        private Label label1;
    }
}
