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
        public SignIn()
        {
            InitializeComponent();
        }
       

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                if(dr.Read())
                {
                    txtHideUser.Text = dr[0].ToString(); 
                    txtHidePw.Text = dr[1].ToString();   
                    txtHideType.Text = dr[2].ToString(); 
                    string role = dr[2]?.ToString();
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
                    MessageBox.Show("Invalid Username or Password");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
           
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
