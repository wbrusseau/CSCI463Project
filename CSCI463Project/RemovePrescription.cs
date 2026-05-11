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
    public partial class RemovePrescription : Form
    {
        public RemovePrescription()
        {
            InitializeComponent();
        }

        private void RemovePrescription_Load(object sender, EventArgs e)
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
                List<string[]> patients = Session.GetAllPatients();
                for (int i = 0; i < patients.Count; i++)
                {
                    string patientID = patients[i][1];
                    PatientBox.Items.Add(patientID);
                }
            }
        }

        private void PatientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientsPrescriptions.Items.Clear();
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                PatientBox.SelectedItem.ToString() + "_prescriptions.txt"
            );
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    string prescriptionInfo = $"{parts[0]}|{parts[1]}|{parts[2]}";
                    PatientsPrescriptions.Items.Add(prescriptionInfo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedPrescription = PatientsPrescriptions.SelectedItem?.ToString();
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                PatientBox.SelectedItem.ToString() + "_prescriptions.txt"
            );
            string alertfilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                PatientBox.SelectedItem.ToString() + "_alerts.txt"
            );

            if (string.IsNullOrEmpty(selectedPrescription))
            {
                MessageBox.Show("Please select a prescription to remove.");
                return;
            }
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split('|');
                string prescriptionInfo = $"{parts[0]}|{parts[1]}|{parts[2]}";
                if (prescriptionInfo == PatientsPrescriptions.SelectedItem.ToString())
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    lines.Remove(line);
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("Prescription removed successfully.");
                    PatientsPrescriptions.Items.Remove(PatientsPrescriptions.SelectedItem);
                    Session.AddLog("Remove Prescription", PatientBox.SelectedItem.ToString(), prescriptionInfo);
                    return;
                }
            }
        }
    }
}
