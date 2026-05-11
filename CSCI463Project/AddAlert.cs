using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSCI463Project
{
    public partial class AddAlert : Form
    {
        public AddAlert()
        {
            InitializeComponent();
        }

        private void AddAlert_Load(object sender, EventArgs e)
        {
            if (Session.Username == "Doctor")
            {
                List<string> patients = Session.GetDoctorPatients();
                foreach (string patient in patients)
                {
                    PatientBox.Items.Add(patient);
                }
            }
            else if (Session.Username == "Admin")
            {
                List<string[]> allPatients = Session.GetAllPatients();
                foreach (string[] patient in allPatients)
                {
                    PatientBox.Items.Add(patient[0]);
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string patient = PatientBox.SelectedItem.ToString().Trim();
            string type = "";
            string description = AlertDescription.Text;
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                patient + "_alerts.txt"
            );
            if (IDT.Checked && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(patient))
            {
                type = "Incorrect Dosage Taken";
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                File.AppendAllText(filePath, type + "|" + date + "|" + description + Environment.NewLine);
                MessageBox.Show("Alert created successfully.");
            }
            else if (MD.Checked && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(patient))
            {
                type = "Missing Dosage";
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                File.AppendAllText(filePath, type + "|" + date + "|" + description + Environment.NewLine);
                MessageBox.Show("Alert created successfully.");                
            }
            else if (PM.Checked && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(patient)){
                type = "Prescription Missing";
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                File.AppendAllText(filePath, type + "|" + date + "|" + description + Environment.NewLine);
                MessageBox.Show("Alert created successfully."); 
                Session.AddLog("Add Alert", patient, "Added alert of type: " + type + " with description: " + description);

            }
            else
            {
                MessageBox.Show("Please select an alert type and add a description");
                return;
            }
        }
    }
}
