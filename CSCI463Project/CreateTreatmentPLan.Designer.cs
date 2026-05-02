namespace CSCI463Project
{
    partial class CreateTreatmentPlan
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
            textBox1 = new TextBox();
            Submitbutton = new Button();
            HighRiskButton = new RadioButton();
            LowRiskButton = new RadioButton();
            label3 = new Label();
            PatientBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(513, 24);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 1;
            label1.Text = "Is Patient High or Low Risk?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 222);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 250);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 211);
            textBox1.TabIndex = 3;
            // 
            // Submitbutton
            // 
            Submitbutton.BackColor = Color.Green;
            Submitbutton.FlatStyle = FlatStyle.Popup;
            Submitbutton.ForeColor = Color.White;
            Submitbutton.Location = new Point(570, 353);
            Submitbutton.Name = "Submitbutton";
            Submitbutton.Size = new Size(121, 62);
            Submitbutton.TabIndex = 4;
            Submitbutton.Text = "Submit";
            Submitbutton.UseVisualStyleBackColor = false;
            Submitbutton.Click += Submitbutton_Click;
            // 
            // HighRiskButton
            // 
            HighRiskButton.AutoSize = true;
            HighRiskButton.Location = new Point(538, 60);
            HighRiskButton.Name = "HighRiskButton";
            HighRiskButton.Size = new Size(112, 29);
            HighRiskButton.TabIndex = 5;
            HighRiskButton.TabStop = true;
            HighRiskButton.Text = "High Risk";
            HighRiskButton.UseVisualStyleBackColor = true;
            // 
            // LowRiskButton
            // 
            LowRiskButton.AutoSize = true;
            LowRiskButton.Location = new Point(538, 100);
            LowRiskButton.Name = "LowRiskButton";
            LowRiskButton.Size = new Size(106, 29);
            LowRiskButton.TabIndex = 6;
            LowRiskButton.TabStop = true;
            LowRiskButton.Text = "Low Risk";
            LowRiskButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 13);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 7;
            label3.Text = "Select a Patient";
            // 
            // PatientBox
            // 
            PatientBox.FormattingEnabled = true;
            PatientBox.ItemHeight = 25;
            PatientBox.Location = new Point(40, 41);
            PatientBox.MultiColumn = true;
            PatientBox.Name = "PatientBox";
            PatientBox.ScrollAlwaysVisible = true;
            PatientBox.Size = new Size(456, 179);
            PatientBox.TabIndex = 8;
            // 
            // CreateTreatmentPlan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 473);
            Controls.Add(PatientBox);
            Controls.Add(label3);
            Controls.Add(LowRiskButton);
            Controls.Add(HighRiskButton);
            Controls.Add(Submitbutton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateTreatmentPlan";
            Text = "CreateTreatmentPLan";
            Load += CreateTreatmentPlan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button Submitbutton;
        private RadioButton HighRiskButton;
        private RadioButton LowRiskButton;
        private Label label3;
        private ListBox PatientBox;
    }
}