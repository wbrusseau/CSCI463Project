namespace CSCI463Project
{
    public partial class AddPrescription : Form
    {
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
                    string prescriptionInfo = $"{parts[0]}|{parts[1]}|{parts[2]}";
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
                return;
            }

            string[] selectedParts = prescription.Split('|');

            if (selectedParts.Length < 3)
            {
                MessageBox.Show("Invalid prescription format. Please select a valid prescription.");
                return;
            }

            string selectedPrescriptionName = selectedParts[0];

            if (File.Exists(patientsPrescriptionFilePath))
            {
                var existingPrescriptions = File.ReadAllLines(patientsPrescriptionFilePath);
                if (existingPrescriptions.Contains(prescription))
                {
                    MessageBox.Show("Patient already has this prescription.");
                    return;
                }
            }
            File.AppendAllText(patientsPrescriptionFilePath, prescription + Environment.NewLine);

            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string alertMessage = $"New Prescription Added|{date}|'{selectedPrescriptionName}' added.";
            File.AppendAllText(patientsAlertsFilePath, alertMessage + Environment.NewLine);

            MessageBox.Show($"Prescription '{selectedPrescriptionName}' added for patient '{patient}'.");
        }
    }
}

