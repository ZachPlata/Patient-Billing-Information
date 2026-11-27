using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class Access_Logs___Audit_Trail : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root; pwd=;";

        public Access_Logs___Audit_Trail()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            Column1.DataPropertyName = "timestamp";
            Column2.DataPropertyName = "staff_id";
            Column3.DataPropertyName = "staff_member";
            Column4.DataPropertyName = "patient_id";
            Column5.DataPropertyName = "patient_name";
            Column6.DataPropertyName = "action_taken";

            this.Load += Access_Logs___Audit_Trail_Load;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
        }

        void NavigateToControl(UserControl nextControl)
        {
            Control container = this.Parent;
            if (container != null)
            {
                container.Controls.Clear();
                nextControl.Dock = DockStyle.Fill;
                container.Controls.Add(nextControl);
                nextControl.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToControl(new borja1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateToControl(new AdminUserManagement());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigateToControl(new ClinicAndDataSetup());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetActiveTab(button5);
            LoadPatientAccessLogs();
        }

        private void Access_Logs___Audit_Trail_Load(object sender, EventArgs e)
        {
            SetActiveTab(button5);
            LoadPatientAccessLogs();
        }

        void SetActiveTab(Button activeButton)
        {
            button5.BackColor = Color.FromArgb(56, 173, 238);
            button6.BackColor = Color.FromArgb(56, 173, 238);
            activeButton.BackColor = Color.FromArgb(37, 99, 235);
        }

        void LoadPatientAccessLogs()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT pal.timestamp, pal.staff_id, u.full_name AS staff_member, " +
                    "pal.patient_id, p.full_name AS patient_name, pal.action_taken " +
                    "FROM PatientAccessLogs pal " +
                    "INNER JOIN Users u ON pal.staff_id = u.user_id " +
                    "INNER JOIN Patients p ON pal.patient_id = p.patient_id " +
                    "ORDER BY pal.timestamp DESC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "accessLogs");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "accessLogs";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient access logs: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        void LoadStaffLoginLogs()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT sll.timestamp, sll.staff_id, u.full_name AS staff_member, " +
                    "'N/A' AS patient_id, 'N/A' AS patient_name, " +
                    "CONCAT(sll.event_type, ' (IP: ', sll.terminal_ip, ')') AS action_taken " +
                    "FROM StaffLoginLogs sll " +
                    "INNER JOIN Users u ON sll.staff_id = u.user_id " +
                    "ORDER BY sll.timestamp DESC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "loginLogs");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "loginLogs";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff login/logout logs: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetActiveTab(button5);
            LoadPatientAccessLogs();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetActiveTab(button6);
            LoadStaffLoginLogs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
