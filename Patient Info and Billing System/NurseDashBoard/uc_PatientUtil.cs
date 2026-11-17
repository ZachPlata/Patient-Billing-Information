using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System
{
    public partial class uc_PatientUtil : UserControl
    {
        public uc_PatientUtil()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=patientbillingdb; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            conn.Open();
            cmd.CommandText = "SELECT item_id AS `ID`, bill_id AS `Bill ID`, item_type AS `Category`, description AS `Item`, quantity AS `Qty`, unit_price AS `Price`, subtotal AS `Total` FROM BillingLineItems";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            da.Fill(ds, "abc");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "abc";
            conn.Close();
        }
        private void uc_PatientUtil_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void util_BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            string category = "";
            switch (PatUtil_EqCatComboBox.SelectedIndex)
            {
                case 0:
                    category = "Medication";
                    break;
                case 1:
                    category = "Laboratory";
                    break;
                case 2:
                    category = "Other";
                    break;
                default:
                    MessageBox.Show("Please select a valid equipment category.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            MySqlConnection conn = new MySqlConnection("server=localhost; database=patientbillingdb; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.CommandText = "INSERT INTO BillingLineItems (bill_id, item_type, description, quantity, unit_price) VALUES (" +
                "'BILL-2026-0001'," +
                "'" + category + "'," +
                "'" + PatUtil_EqDrgComboBox.Text + "'," +
                PatUtil_QtTextBox.Text + "," +
                "50.00)";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("RECORD SAVED");
            loaddata();

            }


        }
    }

