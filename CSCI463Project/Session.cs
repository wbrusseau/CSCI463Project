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
        public static string[] AlertList()
        {
            string[] alrt = new string[100];
            string file = Session.Username + "_alerts.txt";
            int i = 0;
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "AlertID|AlertMessage|Date"
                string[] parts = line.Split('|');
                alrt[i] = parts[1];
                i++;
            }
            return alrt;
        }

        public static string getAlertDate(string alertID)
        {
            string alrt = "";
            string file = Session.Username + "_alerts.txt";
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "AlertID|AlertMessage|Date"
                string[] parts = line.Split('|');
                if (parts[0] == alertID)
                {
                    alrt = parts[2];
                }
            }
            return alrt;
        }

        public static string getAlertMessage(string alertID)
        {
            string alrt = "";
            string file = Session.Username + "_alerts.txt";
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "AlertID|AlertMessage|Date"
                string[] parts = line.Split('|');
                if (parts[0] == alertID)
                {
                    alrt = parts[1];
                }
            }
            return alrt;
        }
        public static int AlertCount()
        {
            string file = Session.Username + "_alerts.txt";
            int count = 0;
            foreach (string line in File.ReadLines(file))
            {
                count++;
            }
            return count;
        }

        public static string[] getDoctorsAlertsList()
        {
            string[] alrt = new string[100];
            string file = Session.Username + "_patients.txt";
            int i = 0;
            foreach (string line in File.ReadLines(file))
            {
                string patID = line.Split('|')[0];
                foreach (string line2 in File.ReadLines(patID + "_alerts.txt"))
                {
                    //File is formatted as "AlertID|AlertMessage|Date"
                    string[] parts = line2.Split('|');
                    alrt[i] = parts[1];
                    i++;
                }
            }
            return alrt;
        }


        /**
         * Prescription Section:
         * Getting all prescriptions for the user and putting them in an array to be displayed on the prescriptions page.
         * Getting Prescription Dosage: Gets the dosage of a specific prescription to be displayed on the prescription details page.
         * Getting Prescription Frequency: Gets the frequency of a specific prescription to be displayed on the prescription details page.
         * 
         * 
         */
        public static string[] PrescriptionsList()
        {
            string[] prcn = new string[100];
            string file = Session.Username + "_prescriptions.txt";
            int i = 0;
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "PrescriptionName|Dosage|Frequency"
                string[] parts = line.Split('|');
                prcn[i] = parts[0];
                i++;
            }
            return prcn;
        }

        public static string getPrescriptionDosage(string PrescriptionName)
        {
            string alrt = "";
            string file = Session.Username + "_prescriptions.txt";
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "PrescriptionName|Dosage|Frequency"
                string[] parts = line.Split('|');
                if (parts[0] == PrescriptionName)
                {
                    alrt = parts[1];
                }
            }
            return alrt;
        }

        public static string getPrescriptionFrequency(string PrescriptionName)
        {
            string alrt = "";
            string file = Session.Username + "_prescriptions.txt";
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "PrescriptionName|Dosage|Frequency"
                string[] parts = line.Split('|');
                if (parts[0] == PrescriptionName)
                {
                    alrt = parts[2];
                }
            }
            return alrt;
        }

        /**
         * Treatment plan Section:
         * 
         * 
         */
        public static string[] TreatmentPlanList()
        {
            string[] trtmnt = new string[100];
            string file = Session.Username + "_treatmentplan.txt";
            int i = 0;
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "TreatmentName|Description"
                string[] parts = line.Split('|');
                trtmnt[i] = parts[0];
                i++;
            }
            return trtmnt;
        }

        public static string getTreatmentPlanDescription(string TreatmentName)
        {
            string alrt = "";
            string file = Session.Username + "_treatmentplan.txt";
            foreach (string line in File.ReadLines(file))
            {
                //File is formatted as "TreatmentName|Description"
                string[] parts = line.Split('|');
                if (parts[0] == TreatmentName)
                {
                    alrt = parts[1];
                }
            }
            return alrt;
        }

        public static string getDoctorsTreatmentplanList()
        {
            string trtmnt = "";
            string file = Session.Username + "_patients.txt";
            foreach (string line in File.ReadLines(file))
            {
                string patID = line.Split('|')[0];
                foreach (string line2 in File.ReadLines(patID + "_treatmentplan.txt"))
                {
                    //File is formatted as "TreatmentName|Description"
                    string[] parts = line2.Split('|');
                    trtmnt += parts[0] + "\n";
                }
            }
            return trtmnt;
        }
    }
}
