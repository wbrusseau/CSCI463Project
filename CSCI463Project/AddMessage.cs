using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI463Project
{
    public partial class AddMessage : Form
    {
        public AddMessage()
        {
            InitializeComponent();
        }

        private void AddMessage_Load(object sender, EventArgs e)
        {
            if (Session.UserRole == "Doctor")
            {
                List<string> patients = Session.GetDoctorPatients();
                foreach (string patient in patients)
                {
                    ReceiverBox.Items.Add(patient);
                }
            }
            else if (Session.UserRole == "Patient")
            {
                List<string> doctors = Session.GetPatientsDoctors();
                foreach (string doctor in doctors)
                {
                    ReceiverBox.Items.Add(doctor);
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string receiver = ReceiverBox.SelectedItem.ToString().Trim();
            string message = MessageTextBox.Text;
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                receiver + "_messages.txt"
            );
            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(receiver))
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                File.AppendAllText(filePath, Session.FullName + "|" + Session.Username + "|" + date + "|" + message + Environment.NewLine);
                MessageBox.Show("Message sent successfully.");
            }
            else
            {
                MessageBox.Show("Please select a receiver and enter a message.");
                return;
            }
        }
    }
}
