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
    public partial class Alerts : Form
    {
        public Alerts()
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

        private void Prescriptions_Click_1(object sender, EventArgs e)
        {
            Prescriptions prForm = new Prescriptions();
            this.Hide();
            prForm.ShowDialog();
            this.Close();

        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            Appointments apForm = new Appointments();
            this.Hide();
            apForm.ShowDialog();
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
            Messages messagesForm = new Messages();
            this.Hide();
            messagesForm.ShowDialog();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPage lgForm = new LoginPage();
            this.Hide();
            lgForm.ShowDialog();
            this.Close();
        }

        private void Alerts_Load(object sender, EventArgs e)
        {
            textBox1.Text = Session.FullName + "'s Alerts";
            if (Session.UserRole == "Patient")
            {
                List<string[]> alerts = Session.GetPatientAlertData(Session.Username);

                for (int i = 0; i < alerts.Count; i++)
                {
                    string alertID = alerts[i][0];
                    string alertMessage = Session.GetAlertMessage(Session.Username, alertID);
                    string alertDate = Session.GetAlertDate(Session.Username, alertID);
                    string displayText = $"{alertDate}: {alertMessage}";
                    AlertsBox.AppendText(displayText + Environment.NewLine);
                }
            }
            else
            {
                List<string> doctorPatients = Session.GetDoctorPatients();

                foreach (string patientID in doctorPatients)
                {
                    var alerts = Session.GetPatientAlertData(patientID);

                    if (alerts.Count == 0)
                        continue;

                    foreach (var alert in alerts)
                    {
                        string alertType = alert[0];
                        string alertMessage = alert[2];
                        string alertDate = alert[1];

                        AlertsBox.AppendText(
                            Environment.NewLine + $"{patientID} | {alertType} | {alertDate} {alertMessage}"
                            + Environment.NewLine
                        );
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAlert addAlertPage = new AddAlert();
            addAlertPage.ShowDialog();
        }
    }
}
