using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using NurseDashBoard;
using Org.BouncyCastle.Asn1.Mozilla;
using Patient_Info_and_Billing_System.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Patient_Info_and_Billing_System.Doctor;
namespace Patient_Info_and_Billing_System.LogIn
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private string selectedRole = "";
        private void SignIn_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.PlaceholderText = "Enter Username";
            txtPassword.PlaceholderText = "Enter Password";
            this.ActiveControl = button1;
            selectedRole = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedRole == "")
            {
                MessageBox.Show("Please select a role before signing in", "No Role Selected",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connstring = "server=localhost; database=patientbillingdb; uid=root";
            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;


            try
            {
                conn.Open();
                cmd.CommandText = "SELECT username, password_hash, role " +
                          "FROM users " +
                          "WHERE username = '" + txtUser.Text + "' " +
                          "AND password_hash = '" + txtPassword.Text + "'";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtHideUser.Text = dr[0].ToString();
                    txtHidePw.Text = dr[1].ToString();
                    txtHideType.Text = dr[2].ToString();
                    string role = dr[2].ToString();
                    

                    if(role != selectedRole)
                    {
                        MessageBox.Show("Access Denied. The selected role does not match your account", "Role Mismatch",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Hide();
                    if (role == "Admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.userLabel.Text = txtHideUser.Text;
                        adminForm.Show();
                    }
                    else if (role == "Nurse")
                    {
                        Nurse nurseForm = new Nurse();
                        nurseForm.Show();
                    }
                    else if (role == "Doctor")
                    {
                        DoctorForm doctorForm = new DoctorForm();
                        doctorForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User has an invalid role assigned.");
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        private void SelectedButton(Button selected)
        {
            foreach (Button btn in new[] { button3, button4, button5 })
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(17, 34, 64);
            }
            selected.BackColor = Color.FromArgb(17, 34, 64);
            selected.ForeColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";
            SelectedButton(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedRole = "Doctor";
            SelectedButton(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedRole = "Nurse";
            SelectedButton(button5);
        }
    }
}
