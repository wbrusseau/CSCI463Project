namespace CSCI463Project
{
    partial class Alerts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alerts));
            LogoutButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            Messages = new Button();
            TreatmentPlan = new Button();
            Prescriptions = new Button();
            Appointments = new Button();
            AlertsButton = new Button();
            Home = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            AlertsBox = new TextBox();
            AddAlertButton = new Button();
            button2 = new Button();
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
            LogoutButton.Click += LogoutButton_Click;
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
            panel2.Controls.Add(Messages);
            panel2.Controls.Add(TreatmentPlan);
            panel2.Controls.Add(Prescriptions);
            panel2.Controls.Add(Appointments);
            panel2.Controls.Add(AlertsButton);
            panel2.Controls.Add(Home);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 391);
            panel2.TabIndex = 2;
            // 
            // Messages
            // 
            Messages.BackColor = Color.White;
            Messages.FlatAppearance.BorderSize = 0;
            Messages.FlatStyle = FlatStyle.Popup;
            Messages.Location = new Point(0, 302);
            Messages.Name = "Messages";
            Messages.Size = new Size(164, 54);
            Messages.TabIndex = 5;
            Messages.Text = "Messages";
            Messages.TextAlign = ContentAlignment.MiddleLeft;
            Messages.UseVisualStyleBackColor = false;
            Messages.Click += Messages_Click;
            // 
            // TreatmentPlan
            // 
            TreatmentPlan.BackColor = Color.White;
            TreatmentPlan.FlatAppearance.BorderSize = 0;
            TreatmentPlan.FlatStyle = FlatStyle.Popup;
            TreatmentPlan.Location = new Point(0, 242);
            TreatmentPlan.Name = "TreatmentPlan";
            TreatmentPlan.Size = new Size(164, 54);
            TreatmentPlan.TabIndex = 4;
            TreatmentPlan.Text = "Treatment Plan";
            TreatmentPlan.TextAlign = ContentAlignment.MiddleLeft;
            TreatmentPlan.UseVisualStyleBackColor = false;
            TreatmentPlan.Click += TreatmentPlan_Click;
            // 
            // Prescriptions
            // 
            Prescriptions.BackColor = Color.White;
            Prescriptions.FlatAppearance.BorderSize = 0;
            Prescriptions.FlatStyle = FlatStyle.Popup;
            Prescriptions.Location = new Point(0, 182);
            Prescriptions.Name = "Prescriptions";
            Prescriptions.Size = new Size(164, 54);
            Prescriptions.TabIndex = 3;
            Prescriptions.Text = "Prescriptions";
            Prescriptions.TextAlign = ContentAlignment.MiddleLeft;
            Prescriptions.UseVisualStyleBackColor = false;
            Prescriptions.Click += Prescriptions_Click_1;
            // 
            // Appointments
            // 
            Appointments.BackColor = Color.White;
            Appointments.FlatAppearance.BorderSize = 0;
            Appointments.FlatStyle = FlatStyle.Popup;
            Appointments.Location = new Point(0, 122);
            Appointments.Name = "Appointments";
            Appointments.Size = new Size(164, 54);
            Appointments.TabIndex = 2;
            Appointments.Text = "Appointments";
            Appointments.TextAlign = ContentAlignment.MiddleLeft;
            Appointments.UseVisualStyleBackColor = false;
            Appointments.Click += Appointments_Click;
            // 
            // AlertsButton
            // 
            AlertsButton.BackColor = Color.White;
            AlertsButton.Enabled = false;
            AlertsButton.FlatAppearance.BorderSize = 0;
            AlertsButton.FlatStyle = FlatStyle.Popup;
            AlertsButton.Location = new Point(0, 62);
            AlertsButton.Name = "AlertsButton";
            AlertsButton.Size = new Size(164, 54);
            AlertsButton.TabIndex = 1;
            AlertsButton.Text = "Alerts";
            AlertsButton.TextAlign = ContentAlignment.MiddleLeft;
            AlertsButton.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            Home.BackColor = Color.White;
            Home.FlatAppearance.BorderSize = 0;
            Home.FlatStyle = FlatStyle.Popup;
            Home.Location = new Point(0, 2);
            Home.Name = "Home";
            Home.Size = new Size(164, 54);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.TextAlign = ContentAlignment.MiddleLeft;
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
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
            // AlertsBox
            // 
            AlertsBox.Enabled = false;
            AlertsBox.Location = new Point(195, 141);
            AlertsBox.Multiline = true;
            AlertsBox.Name = "AlertsBox";
            AlertsBox.ReadOnly = true;
            AlertsBox.Size = new Size(425, 282);
            AlertsBox.TabIndex = 6;
            // 
            // AddAlertButton
            // 
            AddAlertButton.BackColor = Color.Green;
            AddAlertButton.FlatStyle = FlatStyle.Popup;
            AddAlertButton.Font = new Font("Segoe UI", 12F);
            AddAlertButton.ForeColor = Color.White;
            AddAlertButton.Location = new Point(637, 144);
            AddAlertButton.Name = "AddAlertButton";
            AddAlertButton.Size = new Size(148, 63);
            AddAlertButton.TabIndex = 7;
            AddAlertButton.Text = "Add Alert";
            AddAlertButton.UseVisualStyleBackColor = false;
            AddAlertButton.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // Alerts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 438);
            Controls.Add(AddAlertButton);
            Controls.Add(AlertsBox);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Alerts";
            Text = "Alerts";
            Load += Alerts_Load;
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
        private Button Home;
        private Button Messages;
        private Button TreatmentPlan;
        private Button Prescriptions;
        private Button Appointments;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox1;
        private TextBox AlertsBox;
        private Button AddAlertButton;
        private Button button2;
    }
}
