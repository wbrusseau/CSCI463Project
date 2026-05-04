using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI463Project
{
    public partial class AddPrescription : Form
    {
        string treatmentPlanType;
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            List<string> patients = Session.GetDoctorPatients();
            string prescriptionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Information", "prescriptions.txt");
            foreach (string patient in patients)
            {
                PatientBox.Items.Add(patient);
            }
            foreach (string line in File.ReadAllLines(prescriptionFilePath))
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    string prescriptionInfo = $"{parts[0]} - {parts[1]} - {parts[2]}";
                    PrescriptionBox.Items.Add(prescriptionInfo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patient = PatientBox.SelectedItem?.ToString();
            string prescription = PrescriptionBox.SelectedItem?.ToString();
            string patientsPrescriptionFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                patient + "_prescriptions.txt"
            );
            string prescriptionfilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                "prescriptions.txt"
            );
            string patientsAlertsFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                patient + "_alerts.txt"
            );
            if (string.IsNullOrEmpty(patient) || string.IsNullOrEmpty(prescription))
            {
                MessageBox.Show("Please select a patient and a prescription.");
            }
            else
            {
                foreach(string line in File.ReadAllLines(prescriptionfilePath))
                {
                    string[] parts = line.Split('|');
                    string prescriptionName = parts[0];
                    if (prescriptionName == prescription)
                    {
                        string dosage = parts[1];
                        string frequency = parts[2];
                        string prescriptionInfo = $"{prescription} - {dosage} - {frequency}";
                        File.AppendAllText(patientsPrescriptionFilePath, prescriptionInfo + Environment.NewLine);
                        File.AppendAllText(patientsAlertsFilePath, $"Prescription '{prescription}' added." + Environment.NewLine);
                        break;
                    }
                }
                MessageBox.Show($"Prescription '{prescription}' added for patient '{patient}'.");
                File.AppendAllText(prescriptionfilePath, prescription + Environment.NewLine);
            }
        }
    }
}
