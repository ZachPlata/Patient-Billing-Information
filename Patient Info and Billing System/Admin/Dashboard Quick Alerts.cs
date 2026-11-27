using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class borja1 : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root; pwd=;";

        public borja1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Column1.DataPropertyName = "timestamp";
            Column2.DataPropertyName = "staff_member";
            Column4.DataPropertyName = "patient_name";
            Column3.DataPropertyName = "action_taken";

            this.Load += borja1_Load;
        }

        private void borja1_Load(object? sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            LoadDashboardSummary();
            LoadActivityFeed();
        }

        void LoadDashboardSummary()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                // 1. Total Active Patients
                MySqlCommand cmdPatients = new MySqlCommand();
                cmdPatients.Connection = conn;
                cmdPatients.CommandText = "SELECT COUNT(*) FROM Patients WHERE current_status IN ('Outpatient', 'Admitted')";
                MySqlDataReader readerPatients = cmdPatients.ExecuteReader();
                if (readerPatients.Read())
                {
                    label10.Text = readerPatients[0].ToString();
                }
                readerPatients.Close();

                // 2. Bed Occupancy Rate
                int totalBeds = 0;
                int occupiedBeds = 0;
                double occupancyRate = 0;

                MySqlCommand cmdBeds = new MySqlCommand();
                cmdBeds.Connection = conn;
                cmdBeds.CommandText = "SELECT COUNT(*) AS total_beds, IFNULL(SUM(CASE WHEN is_occupied = 1 THEN 1 ELSE 0 END), 0) AS occupied_beds FROM RoomsBeds";
                MySqlDataReader readerBeds = cmdBeds.ExecuteReader();
                if (readerBeds.Read())
                {
                    totalBeds = Convert.ToInt32(readerBeds["total_beds"]);
                    occupiedBeds = Convert.ToInt32(readerBeds["occupied_beds"]);
                }
                readerBeds.Close();

                if (totalBeds > 0)
                {
                    occupancyRate = ((double)occupiedBeds / totalBeds) * 100.0;
                }
                label5.Text = occupancyRate.ToString("0.0") + "%";

                // 3. Total Clinic Staff
                MySqlCommand cmdStaff = new MySqlCommand();
                cmdStaff.Connection = conn;
                cmdStaff.CommandText = "SELECT COUNT(*) FROM Users WHERE is_active = 1";
                MySqlDataReader readerStaff = cmdStaff.ExecuteReader();
                if (readerStaff.Read())
                {
                    label13.Text = readerStaff[0].ToString();
                }
                readerStaff.Close();

                // 4. Total Paid Collection (from BillingRecords.amount_paid to avoid double-counting)
                MySqlCommand cmdPaid = new MySqlCommand();
                cmdPaid.Connection = conn;
                cmdPaid.CommandText = "SELECT IFNULL(SUM(amount_paid), 0) FROM BillingRecords WHERE billing_status <> 'Cancelled'";
                MySqlDataReader readerPaid = cmdPaid.ExecuteReader();
                if (readerPaid.Read())
                {
                    decimal totalPaid = Convert.ToDecimal(readerPaid[0]);
                    label6.Text = "₱" + totalPaid.ToString("N2");
                }
                readerPaid.Close();

                // 5. Quick Alert: Bed Occupancy Warning
                if (totalBeds == 0)
                {
                    label1.Text = "SYSTEM WARNING: NO BEDS CONFIGURED IN ROOMS & BEDS";
                }
                else if (occupancyRate < 50.0)
                {
                    label1.Text = "SYSTEM WARNING: LOW BED OCCUPANCY RATE (" + occupiedBeds + "/" + totalBeds + " beds occupied, " + occupancyRate.ToString("0.0") + "%)";
                }
                else if (occupancyRate >= 85.0)
                {
                    label1.Text = "SYSTEM WARNING: HIGH BED OCCUPANCY RATE (" + occupiedBeds + "/" + totalBeds + " beds occupied, " + occupancyRate.ToString("0.0") + "%)";
                }
                else
                {
                    label1.Text = "SYSTEM NOTICE: BED OCCUPANCY NORMAL (" + occupiedBeds + "/" + totalBeds + " beds occupied, " + occupancyRate.ToString("0.0") + "%)";
                }

                // 6. Quick Alert: Critical Medicine Stock
                int criticalMedCount = 0;
                MySqlCommand cmdMeds = new MySqlCommand();
                cmdMeds.Connection = conn;
                cmdMeds.CommandText = "SELECT COUNT(*) FROM MedicineCatalog WHERE is_active = 1 AND stock_quantity <= 20";
                MySqlDataReader readerMeds = cmdMeds.ExecuteReader();
                if (readerMeds.Read())
                {
                    criticalMedCount = Convert.ToInt32(readerMeds[0]);
                }
                readerMeds.Close();

                if (criticalMedCount > 0)
                {
                    label2.Text = "INVENTORY NOTICE: CRITICAL MEDICINE STOCK (" + criticalMedCount + " item(s) with 20 or fewer units)";
                }
                else
                {
                    label2.Text = "INVENTORY NOTICE: MEDICINE STOCK LEVELS NORMAL (0 critical items)";
                }

                // 7. Quick Alert: Pending Outstanding Balances
                int pendingBillCount = 0;
                decimal totalBalance = 0;
                MySqlCommand cmdBalances = new MySqlCommand();
                cmdBalances.Connection = conn;
                cmdBalances.CommandText = "SELECT COUNT(*) AS pending_count, IFNULL(SUM(remaining_balance), 0) AS total_balance FROM BillingRecords WHERE billing_status IN ('Unpaid', 'Partial') AND remaining_balance > 0";
                MySqlDataReader readerBalances = cmdBalances.ExecuteReader();
                if (readerBalances.Read())
                {
                    pendingBillCount = Convert.ToInt32(readerBalances["pending_count"]);
                    totalBalance = Convert.ToDecimal(readerBalances["total_balance"]);
                }
                readerBalances.Close();

                if (pendingBillCount > 0)
                {
                    label3.Text = "BILLING NOTICE: " + pendingBillCount + " PENDING OUTSTANDING BALANCE(S) (Total: ₱" + totalBalance.ToString("N2") + ")";
                }
                else
                {
                    label3.Text = "BILLING NOTICE: NO PENDING OUTSTANDING BALANCES";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard summary: " + ex.Message, "Database Error",
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

        void LoadActivityFeed()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT pal.timestamp, u.full_name AS staff_member, p.full_name AS patient_name, pal.action_taken " +
                    "FROM PatientAccessLogs pal " +
                    "INNER JOIN Users u ON pal.staff_id = u.user_id " +
                    "INNER JOIN Patients p ON pal.patient_id = p.patient_id " +
                    "ORDER BY pal.timestamp DESC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "activityFeed");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "activityFeed";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activity feed: " + ex.Message, "Database Error",
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
