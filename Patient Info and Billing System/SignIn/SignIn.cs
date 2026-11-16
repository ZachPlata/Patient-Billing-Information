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
using NurseDashBoard;
namespace Patient_Info_and_Billing_System.LogIn
{
    public partial class SignIn : Form
    {
        private string selectedRole = "";

        public SignIn()
        {
            InitializeComponent();
        }
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
            if (string.IsNullOrEmpty(selectedRole))
            {
               MessageBox.Show("Please Select a Role to Sign In", "Role Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
               errorProvider1.SetError(txtUser, "Username or Email is Required");
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password is Required");
            }
            string connstring = "server=localhost;user id=root;password=;database=patientbillingdb";
            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;


            try
            {
                conn.Open();
                cmd.CommandText = cmd.CommandText = "SELECT Username, Password, Usertype " +
                          "FROM userTable " +
                          "WHERE Username = '" + txtUser.Text + "' " +
                          "AND Password = '" + txtPassword.Text + "'";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtHideUser.Text = dr[0].ToString();
                    txtHidePw.Text = dr[1].ToString();
                    txtHideType.Text = dr[2].ToString();
                    string role = dr[2]?.ToString();


                    if (role != selectedRole)
                    {

                        MessageBox.Show("Warning: You do not have permission for the selected role", "Role Mismatch",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.Hide();
                    if (role == "1")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.userTxtBox.Text = txtHideUser.Text;
                        adminForm.Show();
                    }
                    else if (role == "2")
                    {
                        Nurse nurseForm = new Nurse();
                        nurseForm.Show();
                    }
                    else if (role == "3")
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
                   MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
        private void HighlightSelectedRole(Button selected)
        {
            foreach (Button btn in new[] { button3, button4, button5 })
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(17, 34, 64);
            }
            selected.BackColor = Color.FromArgb(17, 34, 64);
            selected.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedRole = "1"; // Admin
            HighlightSelectedRole(button3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            selectedRole = "3"; // Doctor
            HighlightSelectedRole(button4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            selectedRole = "2"; // Nurse
            HighlightSelectedRole(button5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            selectedRole = "";
            foreach (Button btn in new[] { button3, button4, button5 })
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(17, 34, 64);
            }
            txtUser.Focus();
        }
    }
}
