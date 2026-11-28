using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Patient_Info_and_Billing_System.Admin.AdminUserManagement;
namespace Patient_Info_and_Billing_System.Admin
{
    public partial class DoctorManage : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";
        string userId = "";
        public DoctorManage()
        {
            InitializeComponent();
            loadstaffdata(doctorTable, "Doctor");
        }

        private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string getStatus()
        {

            if (rbtnActive.Checked)
            {
                return "Active";
            }
            if (rbtnInactive.Checked)
            {
                return "Inactive";
            }
    
            return "";
        }
        void clearFields()
        {
            txt_Fullname.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            textEmail.Clear();
            textPNum.Clear();
            textSpecialty.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txt_Fullname.Text))
            {
                errorProvider1.SetError(txt_Fullname, "Full Name is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                errorProvider1.SetError(txt_Username, "Username is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                errorProvider1.SetError(txt_Password, "Password is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                errorProvider1.SetError(textEmail, "Email is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textPNum.Text))
            {
                errorProvider1.SetError(textPNum, "Phone Number is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textSpecialty.Text))
            {
                errorProvider1.SetError(textSpecialty, "Specialty is required.");
                isValid = false;
            }

            if (isValid)
            {
                CreateStaffAccount(txt_Fullname.Text, txt_Username.Text, txt_Password.Text, "Doctor", textSpecialty.Text, textEmail.Text, textPNum.Text, getStatus());
                loadstaffdata(doctorTable, "Doctor");
                clearFields();
            }
            else
            {
                MessageBox.Show("Please Fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void DoctorManage_Load(object sender, EventArgs e)
        {
            searchText.PlaceholderText = "Type to search...";

        }




        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void doctorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (doctorTable.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                DataGridViewRow row = doctorTable.Rows[e.RowIndex];
                userId = row.Cells["user_id"].Value.ToString();
                txt_Fullname.Text = row.Cells["full_name"].Value.ToString();
                txt_Username.Text = row.Cells["username"].Value.ToString();
                textEmail.Text = row.Cells["email"].Value.ToString();
                textPNum.Text = row.Cells["contact_number"].Value.ToString();
                textSpecialty.Text = row.Cells["specialty"].Value.ToString();


                string status = row.Cells["status"].Value.ToString();
                rbtnActive.Checked = status == "ACTIVE";
                rbtnInactive.Checked = status == "INACTIVE";
              

                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string  status = "";
            if (rbtnActive.Checked)
            {
                status = "ACTIVE";
            }
            else if (rbtnInactive.Checked)
            {
                status = "INACTIVE";
            }
           
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(userId))
            {
                errorProvider1.SetError(button3, "Please select a user from the table first");
                return;
            }
            EditStaffAccount(
                userId,
                txt_Fullname.Text,
                txt_Username.Text,
                txt_Password.Text,
                "Doctor",
                textSpecialty.Text,
                textEmail.Text,
                textPNum.Text,
                getStatus()
            );
            loadstaffdata(doctorTable, "Doctor");
            clearFields();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userId))
            {
                errorProvider1.SetError(button4, "Please select a user from the table first");
                return;
            }
            DeleteStaffAccount(userId);
            loadstaffdata(doctorTable, "Doctor");
            clearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchStaff(doctorTable, "Doctor", searchText.Text.Trim());

        }

        private void cmbBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbBoxFilter.SelectedItem.ToString();
            if (selectedStatus == "All")
            {
                loadstaffdata(doctorTable, "Doctor");
            }
            else
            {
                FilterByStatus(doctorTable, "Doctor", selectedStatus);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchText.Clear();
            cmbBoxFilter.SelectedIndex = 0;
        }
    }
}
