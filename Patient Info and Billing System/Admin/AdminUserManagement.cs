using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AdminUserManagement : UserControl
    {
        public static string connStr = "server=localhost; database=metro_care_db; uid=root";
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

            
        }

        public static void loadstaffdata(DataGridView dgv, string role)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT user_id, full_name, username, role, specialty, email, contact_number, status FROM users WHERE role = '" + role + "' ORDER BY full_name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
        
        }

        public static void CreateStaffAccount(string fullName, string username, string password, string role, string specialty, string email, string phone, string status)
        {
            try
            {


                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                cmd.CommandText = "INSERT INTO users (username, password_hash, full_name, role, email, contact_number, specialty, status) VALUES (" +
                    "'" + username + "', " +
                    "'" + password + "', " +
                    "'" + fullName + "', " +
                    "'" + role + "', " +
                    "'" + email + "', " +
                    "'" + phone + "', " +
                    "'" + specialty + "'," +
                    "'" + status + "')";

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Record Succesfully Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        public static void EditStaffAccount(string userId, string fullName, string username, string password, string role, string specialty, string email, string phone, string status)
        {
            try
            {
                
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "UPDATE users SET " +
                "username = '" + username + "', " +
                "password_hash = '" + password + "', " +
                "full_name = '" + fullName + "', " +
                "role = '" + role + "', " +
                "email = '" + email + "', " +
                "contact_number = '" + phone + "', " +
                "specialty = '" + specialty + "', " +
                "status = '" + status + "' " +
                "WHERE user_id = '" + userId + "'";

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Successfully Updated!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteStaffAccount(string userId)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "DELETE FROM users WHERE user_id = '" + userId + "'";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Successfully Deleted!");
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SearchStaff(DataGridView dgv, string role, string keyword)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT user_id, full_name, username, role, specialty, email, contact_number, status FROM users " +
                "WHERE role = '" + role + "' AND (" +
                "full_name LIKE '%" + keyword + "%' OR " +
                "username LIKE '%" + keyword + "%' OR " +
                "specialty LIKE '%" + keyword + "%' OR " +
                "email LIKE '%" + keyword + "%' OR " +
                "contact_number LIKE '%" + keyword + "%')";

                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data" + ex.Message);
            }
        }
        public static void FilterByStatus(DataGridView dgv, string role, string status)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();
                conn.Open();
                cmd.CommandText = "SELECT user_id, full_name, username, role, specialty, email, contact_number, status FROM users " +
                "WHERE role = '" + role + "' AND status = '" + status + "'";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
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
