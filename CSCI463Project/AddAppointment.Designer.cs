namespace CSCI463Project
{
    partial class AddAppointment
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
            label1 = new Label();
            AppointmenterBox = new ListBox();
            AppointmentDatePicker = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            AppointmentTimePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            ReasonBox = new TextBox();
            label4 = new Label();
            CreateAppointmentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 0;
            label1.Text = "Who is this Appointment with?";
            // 
            // AppointmenterBox
            // 
            AppointmenterBox.FormattingEnabled = true;
            AppointmenterBox.ItemHeight = 25;
            AppointmenterBox.Location = new Point(24, 56);
            AppointmenterBox.Name = "AppointmenterBox";
            AppointmenterBox.Size = new Size(470, 129);
            AppointmenterBox.TabIndex = 1;
            // 
            // AppointmentDatePicker
            // 
            AppointmentDatePicker.Format = DateTimePickerFormat.Short;
            AppointmentDatePicker.Location = new Point(570, 56);
            AppointmentDatePicker.Name = "AppointmentDatePicker";
            AppointmentDatePicker.Size = new Size(164, 31);
            AppointmentDatePicker.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(805, 164);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 3;
            // 
            // AppointmentTimePicker
            // 
            AppointmentTimePicker.Format = DateTimePickerFormat.Time;
            AppointmentTimePicker.Location = new Point(567, 144);
            AppointmentTimePicker.Name = "AppointmentTimePicker";
            AppointmentTimePicker.ShowUpDown = true;
            AppointmentTimePicker.Size = new Size(164, 31);
            AppointmentTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 28);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 5;
            label2.Text = "What Day?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 116);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 6;
            label3.Text = "What Time?";
            // 
            // ReasonBox
            // 
            ReasonBox.Location = new Point(30, 256);
            ReasonBox.Multiline = true;
            ReasonBox.Name = "ReasonBox";
            ReasonBox.Size = new Size(521, 175);
            ReasonBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 210);
            label4.Name = "label4";
            label4.Size = new Size(336, 25);
            label4.TabIndex = 8;
            label4.Text = "What is the reason for the Appointment?";
            // 
            // CreateAppointmentButton
            // 
            CreateAppointmentButton.BackColor = Color.Green;
            CreateAppointmentButton.Font = new Font("Segoe UI", 16F);
            CreateAppointmentButton.ForeColor = Color.White;
            CreateAppointmentButton.Location = new Point(585, 290);
            CreateAppointmentButton.Name = "CreateAppointmentButton";
            CreateAppointmentButton.Size = new Size(186, 84);
            CreateAppointmentButton.TabIndex = 9;
            CreateAppointmentButton.Text = "Submit";
            CreateAppointmentButton.UseVisualStyleBackColor = false;
            CreateAppointmentButton.Click += CreateAppointmentButton_Click;
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateAppointmentButton);
            Controls.Add(label4);
            Controls.Add(ReasonBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AppointmentTimePicker);
            Controls.Add(dateTimePicker2);
            Controls.Add(AppointmentDatePicker);
            Controls.Add(AppointmenterBox);
            Controls.Add(label1);
            Name = "AddAppointment";
            Text = "AddAppointment";
            Load += AddAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox AppointmenterBox;
        private DateTimePicker AppointmentDatePicker;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker AppointmentTimePicker;
        private Label label2;
        private Label label3;
        private TextBox ReasonBox;
        private Label label4;
        private Button CreateAppointmentButton;
    }
}