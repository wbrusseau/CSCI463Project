namespace CSCI463Project
{
    partial class Messages
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            LogoutButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            MessagesButton = new Button();
            TreatmentPlanButton = new Button();
            PrescriptionsButton = new Button();
            AppointmentsButton = new Button();
            AlertsButton = new Button();
            HomeButton = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            MessageText = new TextBox();
            SendMess = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.BackgroundImage = (Image)resources.GetObject("LogoutButton.BackgroundImage");
            LogoutButton.BackgroundImageLayout = ImageLayout.Stretch;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Location = new Point(748, 10);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(40, 36);
            LogoutButton.TabIndex = 0;
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoutButton);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 52);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 1;
            label1.Text = "My ODMS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(MessagesButton);
            panel2.Controls.Add(TreatmentPlanButton);
            panel2.Controls.Add(PrescriptionsButton);
            panel2.Controls.Add(AppointmentsButton);
            panel2.Controls.Add(AlertsButton);
            panel2.Controls.Add(HomeButton);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 391);
            panel2.TabIndex = 2;
            // 
            // MessagesButton
            // 
            MessagesButton.BackColor = Color.White;
            MessagesButton.Enabled = false;
            MessagesButton.FlatAppearance.BorderSize = 0;
            MessagesButton.FlatStyle = FlatStyle.Popup;
            MessagesButton.Location = new Point(0, 302);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(164, 54);
            MessagesButton.TabIndex = 5;
            MessagesButton.Text = "Messages";
            MessagesButton.TextAlign = ContentAlignment.MiddleLeft;
            MessagesButton.UseVisualStyleBackColor = false;
            // 
            // TreatmentPlanButton
            // 
            TreatmentPlanButton.BackColor = Color.White;
            TreatmentPlanButton.FlatAppearance.BorderSize = 0;
            TreatmentPlanButton.FlatStyle = FlatStyle.Popup;
            TreatmentPlanButton.Location = new Point(0, 242);
            TreatmentPlanButton.Name = "TreatmentPlanButton";
            TreatmentPlanButton.Size = new Size(164, 54);
            TreatmentPlanButton.TabIndex = 4;
            TreatmentPlanButton.Text = "Treatment Plan";
            TreatmentPlanButton.TextAlign = ContentAlignment.MiddleLeft;
            TreatmentPlanButton.UseVisualStyleBackColor = false;
            TreatmentPlanButton.Click += TreatmentPlanButton_Click;
            // 
            // PrescriptionsButton
            // 
            PrescriptionsButton.BackColor = Color.White;
            PrescriptionsButton.FlatAppearance.BorderSize = 0;
            PrescriptionsButton.FlatStyle = FlatStyle.Popup;
            PrescriptionsButton.Location = new Point(0, 182);
            PrescriptionsButton.Name = "PrescriptionsButton";
            PrescriptionsButton.Size = new Size(164, 54);
            PrescriptionsButton.TabIndex = 3;
            PrescriptionsButton.Text = "Prescriptions";
            PrescriptionsButton.TextAlign = ContentAlignment.MiddleLeft;
            PrescriptionsButton.UseVisualStyleBackColor = false;
            PrescriptionsButton.Click += PrescriptionsButton_Click;
            // 
            // AppointmentsButton
            // 
            AppointmentsButton.BackColor = Color.White;
            AppointmentsButton.FlatAppearance.BorderSize = 0;
            AppointmentsButton.FlatStyle = FlatStyle.Popup;
            AppointmentsButton.Location = new Point(0, 122);
            AppointmentsButton.Name = "AppointmentsButton";
            AppointmentsButton.Size = new Size(164, 54);
            AppointmentsButton.TabIndex = 2;
            AppointmentsButton.Text = "Appointments";
            AppointmentsButton.TextAlign = ContentAlignment.MiddleLeft;
            AppointmentsButton.UseVisualStyleBackColor = false;
            AppointmentsButton.Click += AppointmentsButton_Click;
            // 
            // AlertsButton
            // 
            AlertsButton.BackColor = Color.White;
            AlertsButton.FlatAppearance.BorderSize = 0;
            AlertsButton.FlatStyle = FlatStyle.Popup;
            AlertsButton.Location = new Point(0, 62);
            AlertsButton.Name = "AlertsButton";
            AlertsButton.Size = new Size(164, 54);
            AlertsButton.TabIndex = 1;
            AlertsButton.Text = "Alerts";
            AlertsButton.TextAlign = ContentAlignment.MiddleLeft;
            AlertsButton.UseVisualStyleBackColor = false;
            AlertsButton.Click += AlertsButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.White;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Popup;
            HomeButton.Location = new Point(0, 2);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(164, 54);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(197, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(569, 8);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(276, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 299);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(19, 302);
            panel5.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(197, 60);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(569, 54);
            textBox1.TabIndex = 5;
            // 
            // MessageText
            // 
            MessageText.Location = new Point(200, 142);
            MessageText.Multiline = true;
            MessageText.Name = "MessageText";
            MessageText.ReadOnly = true;
            MessageText.Size = new Size(288, 271);
            MessageText.TabIndex = 6;
            // 
            // SendMess
            // 
            SendMess.Location = new Point(532, 147);
            SendMess.Name = "SendMess";
            SendMess.Size = new Size(219, 48);
            SendMess.TabIndex = 7;
            SendMess.Text = "Send Message";
            SendMess.UseVisualStyleBackColor = true;
            SendMess.Click += button1_Click;
            // 
            // Messages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 438);
            Controls.Add(SendMess);
            Controls.Add(MessageText);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Messages";
            Text = "Alerts";
            Load += Messages_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        private Button LogoutButton;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button AlertsButton;
        private Button HomeButton;
        private Button MessagesButton;
        private Button TreatmentPlanButton;
        private Button PrescriptionsButton;
        private Button AppointmentsButton;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox1;
        private TextBox MessageText;
        private Button SendMess;
    }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
}