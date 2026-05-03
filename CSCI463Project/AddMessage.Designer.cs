namespace CSCI463Project
{
    partial class AddMessage
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
            ReceiverBox = new ListBox();
            MessageTextBox = new TextBox();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(258, 25);
            label1.TabIndex = 0;
            label1.Text = "Who is receiving this message?";
            // 
            // ReceiverBox
            // 
            ReceiverBox.FormattingEnabled = true;
            ReceiverBox.ItemHeight = 25;
            ReceiverBox.Location = new Point(14, 54);
            ReceiverBox.Name = "ReceiverBox";
            ReceiverBox.Size = new Size(359, 129);
            ReceiverBox.TabIndex = 1;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(396, 29);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(388, 338);
            MessageTextBox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.Green;
            SubmitButton.FlatStyle = FlatStyle.Popup;
            SubmitButton.Font = new Font("Segoe UI", 14F);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(89, 247);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(206, 76);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // AddMessage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitButton);
            Controls.Add(MessageTextBox);
            Controls.Add(ReceiverBox);
            Controls.Add(label1);
            Name = "AddMessage";
            Text = "AddMessage";
            Load += AddMessage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ReceiverBox;
        private TextBox MessageTextBox;
        private Button SubmitButton;
    }
}