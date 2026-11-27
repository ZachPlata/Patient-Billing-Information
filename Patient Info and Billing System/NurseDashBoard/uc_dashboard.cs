using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace NurseDashBoard
{
    public partial class uc_dashboard : UserControl
    {
        public uc_dashboard()
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
            cmd.CommandText = "SELECT bed_id AS `Bed ID`, room_number AS `Room`, bed_number AS `Bed`, room_type AS `Type`, daily_rate AS `Daily Rate`, IF(is_occupied = 1, 'Occupied', 'Availablec;
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            da.Fill(ds, "abc");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "abc";
            conn.Close();
        }

        void loadcounts()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=patientbillingdb; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            conn.Open();

            // Available Beds / Total Beds
            cmd.CommandText = "SELECT COUNT(*) AS avail, (SELECT COUNT(*) FROM RoomsBeds) AS total FROM RoomsBeds WHERE is_occupied = 0";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label10.Text = reader["avail"].ToString() + " / " + reader["total"].ToString();
            }
            reader.Close();

            // Bed Occupancy Rate (Occupied Beds)
            cmd.CommandText = "SELECT COUNT(*) AS occupied FROM RoomsBeds WHERE is_occupied = 1";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label12.Text = reader["occupied"].ToString();
            }
            reader.Close();

            // Total Clinic Patients
            cmd.CommandText = "SELECT COUNT(*) AS total FROM Patients";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label14.Text = reader["total"].ToString();
            }
            reader.Close();

            // Admitted Patients
            cmd.CommandText = "SELECT COUNT(*) AS total FROM Patients WHERE current_status = 'Admitted'";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label9.Text = reader["total"].ToString();
            }
            reader.Close();

            // Available Doctors
            cmd.CommandText = "SELECT COUNT(*) AS total FROM Users WHERE role = 'Doctor' AND is_active = 1";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label3.Text = reader["total"].ToString();
            }
            reader.Close();

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
            loaddata();
            loadcounts();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
