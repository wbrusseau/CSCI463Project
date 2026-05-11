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
            // Load patients and prescriptions based on the user's role
            if (Session.UserRole == "Doctor")
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
            } else if (Session.UserRole == "Admin")
            {
                List<string[]> allPatients = Session.GetAllPatients();
                string prescriptionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Information", "prescriptions.txt");
                // Load all patients from the session and add them to the PatientBox
                foreach (string[] patient in allPatients)
                {
                    PatientBox.Items.Add(patient[0]);
                }

                // Load prescriptions from the file and add them to the PrescriptionBox
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patient = PatientBox.SelectedItem?.ToString();
            string prescription = PrescriptionBox.SelectedItem?.ToString();

            // Define file paths
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

            string prescriptioninventoryFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                "prescriptioninventory.txt"
            );

            // Validate that a patient and prescription are selected
            if (string.IsNullOrEmpty(patient) || string.IsNullOrEmpty(prescription))
            {
                MessageBox.Show("Please select a patient and a prescription.");
                return;
            }

            string[] selectedParts = prescription.Split('|');

            // Ensure the prescription format is correct (at least 3 parts: name, dosage, frequency)
            if (selectedParts.Length < 3)
            {
                MessageBox.Show("Invalid prescription format. Please select a valid prescription.");
                return;
            }

            string selectedPrescriptionName = selectedParts[0];

            // Check if the patient already has this prescription
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

            // Add alert for the patient
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string alertMessage = $"New Prescription Added|{date}|'{selectedPrescriptionName}' added.";
            File.AppendAllText(patientsAlertsFilePath, alertMessage + Environment.NewLine);
            Session.AddLog("Add Prescription", patient, $"Added prescription: {selectedPrescriptionName}");

            // Update prescription inventory audit status to "Audit Required"
            if (File.Exists(prescriptioninventoryFilePath))
            {
                string[] inventoryLines = File.ReadAllLines(prescriptioninventoryFilePath);

                for (int i = 0; i < inventoryLines.Length; i++)
                {
                    string[] parts = inventoryLines[i].Split('|');

                    if (parts.Length >= 3)
                    {
                        string inventoryPrescriptionName = parts[0];

                        if (inventoryPrescriptionName == selectedPrescriptionName)
                        {
                            // Keep the amount the same, only update audit status
                            inventoryLines[i] = $"{parts[0]}|Audit Required|{parts[2]}";
                            break;
                        }
                    }
                }

                File.WriteAllLines(prescriptioninventoryFilePath, inventoryLines);
            }

            MessageBox.Show($"Prescription '{selectedPrescriptionName}' added for patient '{patient}'.");
        }
    }
}

