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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void AlertsButton_Click(object sender, EventArgs e)
        {
            Alerts asForm = new Alerts();
            this.Hide();
            asForm.ShowDialog();
            this.Close();
        }

        private void Prescriptions_Click(object sender, EventArgs e)
        {
            Prescriptions prForm = new Prescriptions();
            this.Hide();
            prForm.ShowDialog();
            this.Close();
        }

        private void TreatmentPlan_Click(object sender, EventArgs e)
        {
            TreatmentPlan tpForm = new TreatmentPlan();
            this.Hide();
            tpForm.ShowDialog();
            this.Close();
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            Messages msForm = new Messages();
            this.Hide();
            msForm.ShowDialog();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPage lgPage = new LoginPage();
            this.Hide();
            lgPage.ShowDialog();
            this.Close();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            if (Session.UserRole == "Patient")
            {
                textBox1.Text = Session.FullName + "'s Appointments";
                List<string[]> appointments = Session.GetUpcomingAppointments();
                foreach (string[] appointment in appointments)
                {
                    string displayText =
                        $"{appointment[0]} {appointment[1]} - " +
                        $"Doctor: {appointment[2]} - " +
                        $"Patient: {appointment[3]} - " +
                        $"{appointment[4]}";

                    AppointmentBox.AppendText(displayText + Environment.NewLine);
                }
            }
            else
            {
                textBox1.Text = "Doctor's Appointments";
                List<string[]> appointments = Session.GetUpcomingAppointments();
                foreach (string[] appointment in appointments)
                {
                    string displayText =
                        $"{appointment[0]} {appointment[1]} - " +
                        $"Doctor: {appointment[2]} - " +
                        $"Patient: {appointment[3]} - " +
                        $"{appointment[4]}";

                    AppointmentBox.AppendText(displayText + Environment.NewLine);
                }
            }
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointment addApptForm = new AddAppointment();
            addApptForm.ShowDialog();
        }
    }
}
