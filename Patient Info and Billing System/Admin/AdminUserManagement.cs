using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AdminUserManagement : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";

        public AdminUserManagement()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += (s, e) => clearFields();

            loaddata();
        }

        private void AdminUserManagement_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void loaddata()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT * FROM users";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "userTable");
                userTable.DataSource = ds;
                userTable.DataMember = "userTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            string fullName = txt_Fullname.Text;
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string role = comboBox1.Text;
            string specialty = textBox4.Text;
            string email = textBox5.Text;
            string phone = textBox6.Text;

            CreateStaffAccount(fullName, username, password, role, specialty, email, phone);
        }

        void CreateStaffAccount(string fullName, string username, string password, string role, string specialty, string email, string phone)
        {
            try
            {
                string userId = Guid.NewGuid().ToString();

                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                cmd.CommandText = "INSERT INTO users (user_id, username, password_hash, full_name, role, email, contact_number, specialty) VALUES (" +
                    "'" + userId + "', " +
                    "'" + username + "', " +
                    "'" + password + "', " +
                    "'" + fullName + "', " +
                    "'" + role + "', " +
                    "'" + email + "', " +
                    "'" + phone + "', " +
                    "'" + specialty + "')";

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("RECORD SAVE");

                clearFields();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        void clearFields()
        {
            txt_Fullname.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = string.Empty;
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            txt_Fullname.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
