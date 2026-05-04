namespace CSCI463Project
{
    partial class RemovePrescription
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
            label2 = new Label();
            PatientBox = new ListBox();
            PatientsPrescriptions = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 198);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 1;
            label2.Text = "Patients Prescription";
            // 
            // PatientBox
            // 
            PatientBox.FormattingEnabled = true;
            PatientBox.ItemHeight = 25;
            PatientBox.Location = new Point(15, 42);
            PatientBox.Name = "PatientBox";
            PatientBox.Size = new Size(468, 129);
            PatientBox.TabIndex = 2;
            PatientBox.SelectedIndexChanged += PatientBox_SelectedIndexChanged;
            // 
            // PatientsPrescriptions
            // 
            PatientsPrescriptions.FormattingEnabled = true;
            PatientsPrescriptions.ItemHeight = 25;
            PatientsPrescriptions.Location = new Point(17, 226);
            PatientsPrescriptions.Name = "PatientsPrescriptions";
            PatientsPrescriptions.Size = new Size(472, 179);
            PatientsPrescriptions.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(558, 289);
            button1.Name = "button1";
            button1.Size = new Size(170, 67);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RemovePrescription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(PatientsPrescriptions);
            Controls.Add(PatientBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RemovePrescription";
            Text = "RemovePrescription";
            Load += RemovePrescription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox PatientBox;
        private ListBox PatientsPrescriptions;
        private Button button1;
    }
}