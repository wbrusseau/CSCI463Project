namespace CSCI463Project
{
    partial class AuditInventory
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
            MedicationBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            inventoryNum = new TextBox();
            SuspendLayout();
            // 
            // MedicationBox
            // 
            MedicationBox.FormattingEnabled = true;
            MedicationBox.ItemHeight = 25;
            MedicationBox.Location = new Point(21, 41);
            MedicationBox.MultiColumn = true;
            MedicationBox.Name = "MedicationBox";
            MedicationBox.ScrollAlwaysVisible = true;
            MedicationBox.Size = new Size(365, 379);
            MedicationBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 1;
            label1.Text = "Prescriptions in Inventory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 131);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 2;
            label2.Text = "What is the correct amount?";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(413, 271);
            button1.Name = "button1";
            button1.Size = new Size(248, 87);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // inventoryNum
            // 
            inventoryNum.Location = new Point(433, 175);
            inventoryNum.Name = "inventoryNum";
            inventoryNum.Size = new Size(218, 31);
            inventoryNum.TabIndex = 5;
            // 
            // AuditInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(inventoryNum);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MedicationBox);
            Name = "AuditInventory";
            Text = "AuditInventory";
            Load += AuditInventory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox MedicationBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox inventoryNum;
    }
}