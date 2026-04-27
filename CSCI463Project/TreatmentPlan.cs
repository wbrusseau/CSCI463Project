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
    public partial class TreatmentPlan : Form
    {
        public TreatmentPlan()
        {
            InitializeComponent();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPage lgPage = new LoginPage();
            this.Hide();
            lgPage.ShowDialog();
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void Alerts_Click(object sender, EventArgs e)
        {
            Alerts alForm = new Alerts();
            this.Hide();
            alForm.ShowDialog();
            this.Close();
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            Messages msForm = new Messages();
            this.Hide();
            msForm.ShowDialog();
            this.Close();
        }

        private void AlertsButton_Click(object sender, EventArgs e)
        {
            Alerts arForm = new Alerts();
            this.Hide();
            arForm.ShowDialog();
            this.Close();
        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            Appointments apForm = new Appointments();
            this.Hide();
            apForm.ShowDialog();
            this.Close();
        }

        private void Prescriptions_Click_1(object sender, EventArgs e)
        {
            Prescriptions prForm = new Prescriptions();
            this.Hide();
            prForm.ShowDialog();
            this.Close();
        }

        private void Messages_Click_1(object sender, EventArgs e)
        {
            Messages messageForm = new Messages();
            this.Hide();
            messageForm.ShowDialog();
            this.Close();
        }
    }
}

