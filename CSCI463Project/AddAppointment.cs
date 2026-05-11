using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CSCI463Project
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAppointmentButton_Click(object sender, EventArgs e)
        {
            string patient =
                AppointmenterBox.SelectedItem?.ToString();

            string reason =
                ReasonBox.Text.Trim();

            if (string.IsNullOrEmpty(patient) ||
                string.IsNullOrEmpty(reason))
            {
                MessageBox.Show(
                    "Please fill out all appointment information."
                );
                return;
            }

            string date =
                AppointmentDatePicker.Value.ToString("MM/dd/yyyy");

            string time =
                AppointmentTimePicker.Value.ToString("hh:mm tt");

            string doctor = Session.Username;

            string appointmentInfo =
                $"{date}|{time}|{doctor}|{patient}|{reason}";

            // Doctor appointments file
            string doctorFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                doctor + "_appointments.txt"
            );

            // Patient appointments file
            string patientFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                patient + "_appointments.txt"
            );

            // Add to BOTH files
            File.AppendAllText(
                doctorFile,
                appointmentInfo + Environment.NewLine
            );

            File.AppendAllText(
                patientFile,
                appointmentInfo + Environment.NewLine
            );

            // Add system log
            Session.AddLog(
                "Created Appointment",
                patient,
                $"{date} {time} - {reason}"
            );

            MessageBox.Show(
                "Appointment created successfully."
            );

            ReasonBox.Clear();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            if (Session.UserRole == "Doctor")
            {
                List<string> patients = Session.GetDoctorPatients();
                foreach (string patient in patients)
                {
                    AppointmenterBox.Items.Add(patient);
                }
            }
            else
            {
                List<string> doctors = Session.GetPatientsDoctors();
                foreach (string doctor in doctors)
                {
                    AppointmenterBox.Items.Add(doctor);
                }
            }
        }
    }
}
