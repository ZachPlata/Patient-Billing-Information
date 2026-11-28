using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NurseDashBoard
{
    public partial class uc_RegistrationPatients : UserControl
    {
        public uc_RegistrationPatients()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegPat_BtnAdd_Click(object sender, EventArgs e)
        {

            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(PatReg_NameTxtBox.Text))
            {

                MessageBox.Show("Please enter the patient's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PatReg_NameTxtBox.Focus();
                return;


            }
 
            string gender = "Other";
            if (PatReg_GenderCbox.SelectedIndex == 0)
            {
                gender = "Male";
            }
            else if (PatReg_GenderCbox.SelectedIndex == 1)
            {
                gender = "Female";
            }


            string bloodtype = PatReg_BloodTypeComboBox.Text.Trim();
            if (string.IsNullOrEmpty(bloodtype))
            {
                bloodtype = "O+";
            }

            //gen a unique patient ID
            string patientID = "PAT" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string birthDate = PatReg_Date.Value.ToString("yyyy-MM-dd");
            string allergies = string.IsNullOrWhiteSpace(Allergy_notes.Text) ? "None" : Allergy_notes.Text.Trim();

            try // INSERT PATIENT TO DATABASE
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=metro_care_db;password=;");
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                cmd.CommandText = "INSERT INTO Patients (patient_id, full_name, date_of_birth, gender, contact_number, address, emergency_contact_name, emergency_contact_phone, blood_type, allergies, current_status) " +
                        "VALUES (" +
                        "'" + patientID + "', " +
                        "'" + PatReg_NameTxtBox.Text.Trim() + "', " +
                        "'" + birthDate + "', " +
                        "'" + gender + "', " +
                        "'" + PatReg_ConNoTxtBox.Text.Trim() + "', " +
                        "'" + PatReg_HomeAdTxtBox.Text.Trim() + "', " +
                        "'" + PatReg_ConPerTxtBox.Text.Trim() + "', " +
                        "'" + PatReg_ConRelTxtBox.Text.Trim() + "', " +
                        "'" + bloodtype + "', " +
                        "'" + allergies + "', " +
                        "'Outpatient')";

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                if (!string.IsNullOrWhiteSpace(PatReg_BPTxtBox.Text) || !string.IsNullOrWhiteSpace(PatReg_BPTextBox.Text))
                {
                    string bp = string.IsNullOrWhiteSpace(PatReg_BPTxtBox.Text) ? "120/80" : PatReg_BPTxtBox.Text.Trim();

                    int pulse = 75;
                    int.TryParse(PatReg_BPTextBox.Text.Trim(), out pulse);

                    decimal temp = 36.5m;
                    decimal.TryParse(PatReg_BodyTemTxtBox.Text.Trim(), out temp);

                    decimal weight = 50.0m;
                    decimal.TryParse(PatReg_KgTxtBox.Text.Trim(), out weight);

                    MySqlCommand vitalsCmd = new MySqlCommand();
                    vitalsCmd.Connection = conn;
                    vitalsCmd.CommandText = "INSERT INTO PatientVitalsHistory (patient_id, taken_by_nurse_id, blood_pressure, pulse_rate, temperature, weight_kg) " +
                        "VALUES (" +
                        "'" + patientID + "', 'USR-NUR-001', '" + bp + "', " + pulse + ", " + temp + ", " + weight + ")";
                    vitalsCmd.ExecuteNonQuery();
                }
                conn.Close();

                MessageBox.Show("RECORD SAVE", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegPat_BtnClr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            PatReg_NameTxtBox.Clear();
            PatReg_HomeAdTxtBox.Clear();
            PatReg_ConPerTxtBox.Clear();
            PatReg_ConNoTxtBox.Clear();
            PatReg_ConRelTxtBox.Clear();
            textBox1.Clear();

            PatReg_BPTxtBox.Clear();       
            PatReg_BPTextBox.Clear();      
            PatReg_BodyTemTxtBox.Clear();  
            textBox2.Clear();              
            PatReg_KgTxtBox.Clear();
            Allergy_notes.Clear();

            PatReg_GenderCbox.SelectedIndex = -1;
            PatReg_BloodTypeComboBox.SelectedIndex = -1;
            PatReg_Date.Value = DateTime.Now;
        }
    }
}
