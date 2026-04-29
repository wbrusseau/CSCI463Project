using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI463Project
{
    // Session.cs
    public static class Session
    {
        public static string UserRole { get; set; }
        public static string Username { get; set; }


        /**
         * Alert Section:
         * Getting all alerts for the user and putting them in an array to be displayed on the alerts page.
         * Getting Alert Date: Gets the date of a specific alert to be displayed on the alert details page.
         * Getting Alert Message: Gets the message of a specific alert to be displayed on the alert details page.
         * Getting Alert Count: Gets the number of alerts for the user to be displayed on the dashboard.
         * Getting Doctor's Alerts: Gets all alerts for all patients of a doctor to be displayed on the doctor's dashboard.
         * 
         * 
         */
        private static string GetPath(string filename)
        {
            return Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                filename
            );
        }

        public static List<string> GetDoctorPatients()
        {
            List<string> patients = new List<string>();

            string file = GetPath(Session.Username + "_patients.txt");

            if (!File.Exists(file))
                return patients;

            foreach (string line in File.ReadLines(file))
            {
                string[] parts = line.Split('|');
                patients.Add(parts[0]); // PT1001
            }

            return patients;
        }

        public static List<string[]> GetPatientAlertData(string patientID)
        {
            List<string[]> alerts = new List<string[]>();

            string file = GetPath(patientID + "_alerts.txt");

            if (!File.Exists(file))
                return alerts;

            foreach (string line in File.ReadLines(file))
            {
                string[] parts = line.Split('|');
                if (parts.Length < 3)
                {
                    continue;
                } // Skip malformed lines
                alerts.Add(parts);
            }

            return alerts;
        }

        public static List<string> AlertList()
        {
            List<string> alrt = new List<string>();

            foreach (var parts in GetPatientAlertData(Username))
            {
                //File is formatted as "AlertID|AlertMessage|Date"
                alrt.Add(parts[1]);
            }
            return alrt;
        }

        public static string GetAlertMessage(string patientID, string alertID)
        {
            foreach(var parts in GetPatientAlertData(patientID))
            {
                if (parts[0] == alertID)
                {
                    return parts[1]; // AlertMessage
                }
            }
            return "";
        }
        public static string GetAlertDate(string patientID, string alertID)
        {
            foreach (var parts in GetPatientAlertData(patientID))
            {
                if (parts[0] == alertID)
                {
                    return parts[2]; // AlertDate
                }
            }
            return "";
        }

        public static int GetPatientsAlertCount(string patientID)
        {
            return GetPatientAlertData(patientID).Count;
        }

        public static List<string> getDoctorsAlertsList()
        {
            List<string> allAlerts = new List<string>();
            
            foreach(string patient in GetDoctorPatients())
            {
                foreach (var alert in GetPatientAlertData(patient))
                {
                    //File is formatted as "AlertID|AlertMessage|Date"
                    allAlerts.Add(alert[1]);
                }
            }
            return allAlerts;
        }

        public static int GetDoctorsAlertsCount()
        {
            int count = 0;

            foreach (string patient in GetDoctorPatients())
            {
                count += GetPatientsAlertCount(patient);
            }

            return count;
        }


        /**
         * Prescription Section:
         * Getting all prescriptions for the user and putting them in an array to be displayed on the prescriptions page.
         * Getting Prescription Dosage: Gets the dosage of a specific prescription to be displayed on the prescription details page.
         * Getting Prescription Frequency: Gets the frequency of a specific prescription to be displayed on the prescription details page.
         * 
         * 
         */
        public static List<string> PrescriptionsList()
        {
            List<string> prcn = new List<string>();
            string file = GetPath(Username + "_prescriptions.txt");

            if (!File.Exists(file))
            {
                return prcn;
            }

            foreach (string line in File.ReadLines(file))
            {
                string[] parts = line.Split('|');
             
                if (parts.Length < 1)
                {
                    continue;
                } // Skip malformed lines
                prcn.Add(parts[0]);
            }
            return prcn;
        }

        public static string GetPrescriptionDosage(string PrescriptionName)
        {
            string file = GetPath(Username + "_prescriptions.txt");
            if (!File.Exists(file))
            {
                return "";
            }
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "PrescriptionName|Dosage|Frequency"
                string[] parts = line.Split('|');

                if (parts.Length < 2)
                {
                    continue;
                }

                if (parts[0] == PrescriptionName)
                {
                    return parts[1];
                }
            }
            return "";
        }

        public static string GetPrescriptionFrequency(string PrescriptionName)
        {
            string file = GetPath(Session.Username + "_prescriptions.txt");

            if (!File.Exists(file))
            {
                return "";
            }

            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "PrescriptionName|Dosage|Frequency"
                string[] parts = line.Split('|');
                if (parts.Length < 3)
                {
                    continue;
                }

                if (parts[0] == PrescriptionName)
                {
                    return parts[2];
                }
            }
            return "";
        }

        /**
         * Treatment plan Section:
         * 
         * 
         */
        public static List<string> GetTreatmentPlanList()
        {
            List<string> trtmnt = new List<string>();
            string file = GetPath(Username + "_treatmentplan.txt");
            if (!File.Exists(file))
            {
                return trtmnt;
            }

            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "TreatmentName|Description"
                string[] parts = line.Split('|');
                if (parts.Length < 1)
                {
                    continue;
                }
                trtmnt.Add(parts[0]);
            }

            return trtmnt;
        }

        public static string GetTreatmentPlanDescription(string TreatmentName)
        {
            string file = GetPath(Session.Username + "_treatmentplan.txt");
            if (!File.Exists(file))
            {
                return "";
            }
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "TreatmentName|Description"
                string[] parts = line.Split('|');
                if (parts.Length < 2)
                {
                    continue;
                }

                if (parts[0] == TreatmentName)
                {
                    return parts[1];
                }
            }
            return "";
        }

        public static List<string> GetDoctorsTreatmentPlanList()
        {
            List<string> trtmnt = new List<string>();
            foreach (string patient in GetDoctorPatients())
            {
                string file = GetPath(patient + "_treatmentplan.txt");
                if (!File.Exists(file))
                {
                    continue;
                }

                foreach (string line in File.ReadLines(file))
                {
                    //File is formatted as "TreatmentName|Description"
                    string[] parts = line.Split('|');
                    if (parts.Length < 1)
                    {
                        continue;
                    }
                    trtmnt.Add(parts[0]);
                }
            }
            return trtmnt;
        }

        public static int GetDoctorsTreatmentPlanCount() { 
            return GetDoctorsTreatmentPlanList().Count;
        }
    }
}
