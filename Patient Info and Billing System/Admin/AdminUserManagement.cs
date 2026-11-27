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
        string connStr = "server=localhost; database=patientbillingdb; uid=root";
        private enum SetupTab
        {
            DoctorManagement,
            NurseManagement,
            AdminManagement
        }
        private SetupTab currentTab = SetupTab.DoctorManagement;
        public AdminUserManagement()
        {
            InitializeComponent();
            btnTabDoctor.PerformClick();
            //button1.Click += button1_Click;
            //button2.Click += (s, e) => clearFields();

        }
        private void ActiveButton(Button currentButton)
        {
            foreach (Button btn in new[] { btnTabDoctor, btnTabAdmin, btnTabNurse })
            {
                btn.ForeColor = Color.FromArgb(100, 116, 139);
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            currentButton.ForeColor = Color.FromArgb(37, 99, 235);
            currentButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTabUnderline.Left = currentButton.Left;
            panelTabUnderline.Width = currentButton.Width;
            panelTabUnderline.BringToFront();

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
                //userTable.DataSource = ds;
                //userTable.DataMember = "userTable";
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

            //string fullName = txt_Fullname.Text;
            //string username = txt_Username.Text;
            //string password = txt_Password.Text;
            //string role = comboBox1.Text;
            //string specialty = textBox4.Text;
            //string email = textBox5.Text;
            //string phone = textBox6.Text;

            //CreateStaffAccount(fullName, username, password, role, specialty, email, phone);
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
            //txt_Fullname.Clear();
            //txt_Username.Clear();
            //txt_Password.Clear();
            //comboBox1.SelectedIndex = -1;
            //comboBox1.Text = string.Empty;
            //textBox4.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
            //txt_Fullname.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminUserManagement_Load_1(object sender, EventArgs e)
        {

        }

        private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnTabRoomBed_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.DoctorManagement;
            panelContent.Controls.Clear();
            DoctorManage form = new DoctorManage();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTabNurse_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.NurseManagement;
            panelContent.Controls.Clear();
            NurseManage form = new NurseManage();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnTabAdmin_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.AdminManagement;
            panelContent.Controls.Clear();
            AdminManage form = new AdminManage();
            panelContent.Controls.Add(form);
            form.Show();
        }
    }
}
