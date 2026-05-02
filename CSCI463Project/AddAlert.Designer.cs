namespace CSCI463Project
{
    partial class AddAlert
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
            label2 = new Label();
            IDT = new RadioButton();
            MD = new RadioButton();
            PM = new RadioButton();
            AlertDescription = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // PatientBox
            // 
            PatientBox.FormattingEnabled = true;
            PatientBox.ItemHeight = 25;
            PatientBox.Location = new Point(7, 45);
            PatientBox.Name = "PatientBox";
            PatientBox.Size = new Size(366, 129);
            PatientBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 11);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 2;
            label2.Text = "Choose Alert Type";
            // 
            // IDT
            // 
            IDT.AutoSize = true;
            IDT.Location = new Point(437, 57);
            IDT.Name = "IDT";
            IDT.Size = new Size(221, 29);
            IDT.TabIndex = 3;
            IDT.TabStop = true;
            IDT.Text = "Incorrect Dosage Taken";
            IDT.UseVisualStyleBackColor = true;
            // 
            // MD
            // 
            MD.AutoSize = true;
            MD.Location = new Point(437, 101);
            MD.Name = "MD";
            MD.Size = new Size(164, 29);
            MD.TabIndex = 4;
            MD.TabStop = true;
            MD.Text = "Missing Dosage";
            MD.UseVisualStyleBackColor = true;
            // 
            // PM
            // 
            PM.AutoSize = true;
            PM.Location = new Point(437, 145);
            PM.Name = "PM";
            PM.Size = new Size(196, 29);
            PM.TabIndex = 5;
            PM.TabStop = true;
            PM.Text = "Prescription Missing";
            PM.UseVisualStyleBackColor = true;
            // 
            // AlertDescription
            // 
            AlertDescription.Location = new Point(14, 212);
            AlertDescription.Multiline = true;
            AlertDescription.Name = "AlertDescription";
            AlertDescription.Size = new Size(482, 152);
            AlertDescription.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 181);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Patient";
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.Green;
            SubmitButton.FlatStyle = FlatStyle.Popup;
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(512, 240);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(146, 84);
            SubmitButton.TabIndex = 8;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // AddAlert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 378);
            Controls.Add(SubmitButton);
            Controls.Add(label3);
            Controls.Add(AlertDescription);
            Controls.Add(PM);
            Controls.Add(MD);
            Controls.Add(IDT);
            Controls.Add(label2);
            Controls.Add(PatientBox);
            Controls.Add(label1);
            Name = "AddAlert";
            Text = "AddAlert";
            Load += AddAlert_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private ListBox PatientBox;
        private Label label2;
        private RadioButton IDT;
        private RadioButton MD;
        private RadioButton PM;
        private TextBox AlertDescription;
        private Label label3;
        private Label label1;
        private Button SubmitButton;
    }
}