using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Patient_Info_and_Billing_System.Admin.AdminUserManagement;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AdminManage : UserControl
    {
        string userId = "";

        public AdminManage()
        {
            InitializeComponent();
            loadstaffdata(userTable, "Admin");
        }

        private string getStatus()
        {
            if (radioButton1.Checked)
            {
                return "ACTIVE";
            }
            if (radioButton2.Checked)
            {
                return "INACTIVE";
            }
            if (radioButton3.Checked)
            {
                return "LOCKED";
            }

            return "";
        }

        void clearFields()
        {
            userId = "";
            txt_Fullname.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            button1.Enabled = true;
            errorProvider1.Clear();
        }

        private void AdminManage_Load(object sender, EventArgs e)
        {
            searchText.PlaceholderText = "Type to search...";
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
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Email is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                errorProvider1.SetError(textBox6, "Phone Number is required.");
                isValid = false;
            }

            if (isValid)
            {
                CreateStaffAccount(txt_Fullname.Text, txt_Username.Text, txt_Password.Text, "Admin", "", textBox5.Text, textBox6.Text, getStatus());
                loadstaffdata(userTable, "Admin");
                clearFields();
            }
            else
            {
                MessageBox.Show("Please Fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(userId))
            {
                errorProvider1.SetError(button3, "Please select an admin to edit.");
                return;
            }

            EditStaffAccount(
                userId,
                txt_Fullname.Text,
                txt_Username.Text,
                txt_Password.Text,
                "Admin",
                "",
                textBox5.Text,
                textBox6.Text,
                getStatus()
            );
            loadstaffdata(userTable, "Admin");
            clearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(userId))
            {
                errorProvider1.SetError(button4, "Please select a user from the table first");
                return;
            }

            DeleteStaffAccount(userId);
            loadstaffdata(userTable, "Admin");
            clearFields();
        }

        private void userTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || userTable.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                DataGridViewRow row = userTable.Rows[e.RowIndex];
                userId = row.Cells["user_id"].Value.ToString();
                txt_Fullname.Text = row.Cells["full_name"].Value.ToString();
                txt_Username.Text = row.Cells["username"].Value.ToString();
                textBox5.Text = row.Cells["email"].Value.ToString();
                textBox6.Text = row.Cells["contact_number"].Value.ToString();

                string status = row.Cells["status"].Value.ToString();
                radioButton1.Checked = status == "ACTIVE";
                radioButton2.Checked = status == "INACTIVE";
                radioButton3.Checked = status == "LOCKED";

                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchStaff(userTable, "Admin", searchText.Text.Trim());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchText.Clear();
            comboBox1.SelectedIndex = -1;
            loadstaffdata(userTable, "Admin");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }

            string selectedStatus = comboBox1.SelectedItem.ToString();
            if (selectedStatus == "All")
            {
                loadstaffdata(userTable, "Admin");
            }
            else
            {
                FilterByStatus(userTable, "Admin", selectedStatus);
            }
        }
    }
}
