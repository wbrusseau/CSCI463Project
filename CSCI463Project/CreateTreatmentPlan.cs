using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSCI463Project
{
    public partial class CreateTreatmentPlan : Form
    {
        public CreateTreatmentPlan()
        {
            InitializeComponent();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string patient = PatientBox.SelectedItem.ToString();
            string type = "";
            string description = textBox1.Text;
            if (HighRiskButton.Checked && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(patient))
            {
                type = "High Risk";
                string file = patient + "_treatmentplan.txt";
                File.AppendAllText(file, type + "|" + description + Environment.NewLine);
                MessageBox.Show("Treatment plan created successfully.");
            }
            else if (LowRiskButton.Checked && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(patient))
            {
                type = "Low Risk";
                string file = patient + "_treatmentplan.txt";
                File.AppendAllText(file, type + "|" + description + Environment.NewLine);
                MessageBox.Show("Treatment plan created successfully.");
            }
            else
            {
                MessageBox.Show("Please select a risk level and enter a description.");
                return;
            }

        }

        private void CreateTreatmentPlan_Load(object sender, EventArgs e)
        {
            List<string> patients = Session.GetDoctorPatients();
            foreach (string patient in patients)
            {
                PatientBox.Items.Add(patient);
            }
        }
    }
}
