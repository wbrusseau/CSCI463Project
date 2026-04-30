namespace CSCI463Project
{
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
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

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            Appointments apForm = new Appointments();
            this.Hide();
            apForm.ShowDialog();
            this.Close();
        }

        private void TreatmentPlanButton_Click(object sender, EventArgs e)
        {
            TreatmentPlan tpForm = new TreatmentPlan();
            this.Hide();
            tpForm.ShowDialog();
            this.Close();
        }

        private void MessagesButton_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prescriptions_Load(object sender, EventArgs e)
        {
            if (Session.UserRole == "Patient")
            {
                textBox1.Text = Session.FullName + "'s Prescriptions";
                List<string[]> preslist = Session.GetPatientsPrescriptionsList(Session.Username);
                for (int i = 0; i < preslist.Count; i++)
                {
                    string presInfo = $"Prescription {i + 1}: {preslist[i][0]} - {preslist[i][1]} - {preslist[i][2]}";
                    PrescriptionBox.AppendText(presInfo + Environment.NewLine);
                }

            }
            else
            {
                textBox1.Text = Session.FullName + "'s Patients' Prescriptions";
                List<string> patients = Session.GetDoctorPatients();
                for (int i = 0; i < patients.Count; i++)
                {
                    List<string[]> preslist = Session.GetPatientsPrescriptionsList(patients[i]);
                    for (int j = 0; j < preslist.Count; j++)
                    {
                        if (string.IsNullOrEmpty(preslist[j][0]) && string.IsNullOrEmpty(preslist[j][1]) && string.IsNullOrEmpty(preslist[j][2]))
                        {
                            continue; // Skip empty prescriptions
                        }
                        string presInfo = $"Patient: {patients[i]} - Prescription {j + 1}: {preslist[j][0]} - {preslist[j][1]} - {preslist[j][2]}";
                        PrescriptionBox.AppendText(presInfo + Environment.NewLine);
                    }
                }

            }


        }
    }
}
