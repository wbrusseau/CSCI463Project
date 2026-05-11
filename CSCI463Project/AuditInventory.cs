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
    public partial class AuditInventory : Form
    {
        public AuditInventory()
        {
            InitializeComponent();
        }

        private void AuditInventory_Load(object sender, EventArgs e)
        {
            List<string[]> medications = Session.GetAllMedicationAudits();
            foreach (string[] medication in medications)
            {
                string medicationInfo = $"{medication[0]} | {medication[1]} | {medication[2]}";
                MedicationBox.Items.Add(medicationInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Information",
                "prescriptioninventory.txt"
            );
            if (MedicationBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a medication from the list.", "No Medication Selected");
                return;
            }

            string selectedMedication = MedicationBox.SelectedItem.ToString();
            string[] parts = selectedMedication.Split('|');
            if (parts.Length < 3)
            {
                MessageBox.Show("Selected medication information is not in the correct format.", "Invalid Format");
                return;
            }

            string medicationName = parts[0].Trim();
            string auditInfo = parts[1].Trim();

            string newInventory = inventoryNum.Text.Trim();

            if (string.IsNullOrEmpty(newInventory))
            {
                MessageBox.Show("Please enter a valid inventory number.", "Invalid Input");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineParts = lines[i].Split('|');
                if (lineParts.Length >= 3 && lineParts[0].Trim() == medicationName)
                {
                    lineParts[2] = newInventory;
                    lines[i] = string.Join(" | ", lineParts);
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);
            Session.AddLog("Update Inventory", medicationName, $"Updated inventory to {newInventory}");
            MessageBox.Show("Inventory updated successfully.", "Success"); 
            return;
        }
    }
}
