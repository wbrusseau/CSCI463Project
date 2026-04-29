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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            AlertsList.Text = Session.GetDoctorsAlertsCount().ToString() + " Current Patient Alerts";
            TreatmentPlans.Text = Session.getDoctorsTreatmentplanList().Length.ToString() + " Current Treatment Plans";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointments apForm = new Appointments();
            this.Hide();
            apForm.ShowDialog();
            this.Close();
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

        }

        private void Alerts_Click(object sender, EventArgs e)
        {
            Alerts alForm = new Alerts();
            this.Hide();
            alForm.ShowDialog();
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


    }
}
