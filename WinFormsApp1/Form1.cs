
using MySql.Data.MySqlClient;
using System.Data;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database= db_classlist; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            conn.Open();
            cmd.CommandText = "SELECT * FROM tbl_studentrecords";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            da.Fill(ds, "abc");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "abc";
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }





            string gender = "";
            string year = "";

            if (radFemale.Checked)
            {
                gender = "Female";
            }
            if (radMale.Checked)
            {
                gender = "Male";
            }
            if (radLower.Checked)
            {
                year = "Lower Year";
            }
            if (radHigher.Checked)
            {
                year = "Higher Year";
            }

            string college = "";
            switch (cmboCollege.SelectedIndex)
            {
                case 0: college = "Engineering"; break;
                case 1: college = "Business Administration"; break;
                case 2: college = "Arts and Sciences"; break;
                case 3: college = "Fine Arts"; break;
                case 4: college = "Senior HighSchool"; break;
                default: college = "NO COLLEGE SELECTED"; break;
            }
            MySqlConnection conn = new MySqlConnection("server=localhost; database= db_classlist; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.CommandText = "INSERT INTO tbl_studentrecords values (" + textBox1.Text + "," +
                "'" + textBox2.Text + "', " +
                "'" + textBox3.Text + "', " +
                "'" + textBox4.Text + "'," +
                "'" + college + "'," +
                "'" + gender + "'," +
                "'" + year + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("RECORD SAVE");
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database= db_classlist; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            conn.Open();
            cmd.CommandText = "SELECT * FROM tbl_studentrecords WHERE SN = " + txtSearch.Text;
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                textBox1.Text = reader[0].ToString(); //SN
                textBox2.Text = reader[1].ToString(); //Name
                textBox3.Text = reader["Course"].ToString(); //Course
            }
            else {
                MessageBox.Show("No Record Found");
            }
        }
    }
}
