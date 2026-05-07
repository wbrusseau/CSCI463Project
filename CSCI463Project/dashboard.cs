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
            textBox1.Text = "Welcome, " + Session.FullName + "!";
            if (Session.UserRole == "Patient")
            {
                AuditsText.Visible = false;
                AlertsList.Text = Session.GetPatientsAlertCount(Session.Username).ToString() + " Current Alert(s)";
                TreatmentPlans.Text = Session.GetTreatmentPlanList(Session.Username).Count.ToString() + " Current Treatment Plan(s)";
            }
            else if (Session.UserRole == "Doctor")
            {
                AuditsText.Visible = false;
                AlertsList.Text = Session.GetDoctorsAlertsCount().ToString() + " Current Patient Alert(s)";
                TreatmentPlans.Text = Session.GetDoctorsTreatmentPlanCount().ToString() + " Current Treatment Plan(s)";
            }
            else if (Session.UserRole == "Admin")
            {
                AppointmentsButton.Visible = false;
                TreatmentPlan.Visible = false;
                Messages.Visible = false;
                TreatmentPlans.Visible = false;
                AlertsList.Text = Session.GetAllPatientsAlertsCount().ToString() + " Current Alert(s)";
                AuditsText.Text = Session.GetAuditAmount().ToString() + " Audit(s) to Review";
            }

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
