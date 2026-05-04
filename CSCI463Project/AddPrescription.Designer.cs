namespace CSCI463Project
{
    partial class AddPrescription
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
            PatientBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            PrescriptionBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // PatientBox
            // 
            PatientBox.FormattingEnabled = true;
            PatientBox.ItemHeight = 25;
            PatientBox.Location = new Point(29, 44);
            PatientBox.Name = "PatientBox";
            PatientBox.Size = new Size(759, 154);
            PatientBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 16);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 1;
            label1.Text = "Select a Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 245);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 2;
            label2.Text = "Add a Prescription";
            // 
            // PrescriptionBox
            // 
            PrescriptionBox.FormattingEnabled = true;
            PrescriptionBox.ItemHeight = 25;
            PrescriptionBox.Location = new Point(29, 273);
            PrescriptionBox.Name = "PrescriptionBox";
            PrescriptionBox.Size = new Size(634, 154);
            PrescriptionBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(669, 309);
            button1.Name = "button1";
            button1.Size = new Size(126, 48);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddPrescription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(PrescriptionBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PatientBox);
            Name = "AddPrescription";
            Text = "AddPrescription";
            Load += AddPrescription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PatientBox;
        private Label label1;
        private Label label2;
        private ListBox PrescriptionBox;
        private Button button1;
    }
}