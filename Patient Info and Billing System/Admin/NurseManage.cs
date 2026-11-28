using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Patient_Info_and_Billing_System.Admin.AdminUserManagement;
namespace Patient_Info_and_Billing_System.Admin
{
    public partial class NurseManage : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";
        string userId = "";
        public NurseManage()
        {
            InitializeComponent();
            loadstaffdata(nurseTable, "Nurse");
        }
        private string getStatus()
        {
            if (rbtnActive.Checked)
            {
                return "ACTIVE";
            }
            if (rbtnInactive.Checked)
            {
                return "INACTIVE";
            }


            return "";
        }
        void clearFields()
        {
            userId = "";
            txt_Fullname.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            textEmail.Clear();
            textPNum.Clear();
            textTitle.Clear();
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
            button1.Enabled = true;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void NurseManage_Load(object sender, EventArgs e)
        {
            searchText.PlaceholderText = "Type to search...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(userId))
            {
                errorProvider1.SetError(button3, "Please select a nurse to edit.");
                return;
            }
            EditStaffAccount(
                userId,
                txt_Fullname.Text,
                txt_Username.Text,
                txt_Password.Text,
                "Nurse",
                textTitle.Text,
                textEmail.Text,
                textPNum.Text,
                getStatus()
                );
            loadstaffdata(nurseTable, "Nurse");
            clearFields();
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
            if (string.IsNullOrWhiteSpace(textTitle.Text))
            {
                errorProvider1.SetError(textTitle, "Nurse Title is required.");
                isValid = false;
            }

            if (isValid)
            {
                CreateStaffAccount(txt_Fullname.Text, txt_Username.Text, txt_Password.Text, "Nurse", textTitle.Text, textEmail.Text, textPNum.Text, getStatus());
                loadstaffdata(nurseTable, "Nurse");
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

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(userId))
            {
                errorProvider1.SetError(button4, "Please select a user from the table first");
                return;
            }
            DeleteStaffAccount(userId);
            loadstaffdata(nurseTable, "Nurse");
            clearFields();
        }

        private void nurseTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || nurseTable.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                DataGridViewRow row = nurseTable.Rows[e.RowIndex];
                userId = row.Cells["user_id"].Value.ToString();
                txt_Fullname.Text = row.Cells["full_name"].Value.ToString();
                txt_Username.Text = row.Cells["username"].Value.ToString();
                textEmail.Text = row.Cells["email"].Value.ToString();
                textPNum.Text = row.Cells["contact_number"].Value.ToString();
                textTitle.Text = row.Cells["specialty"].Value.ToString();


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

        private void button5_Click(object sender, EventArgs e)
        {
            SearchStaff(nurseTable, "Nurse", searchText.Text.Trim());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchText.Clear();
            cmbBoxFilter.SelectedIndex = -1;
            loadstaffdata(nurseTable, "Nurse");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxFilter.SelectedItem == null)
            {
                return;
            }

            string selectedStatus = cmbBoxFilter.SelectedItem.ToString();
            if (selectedStatus == "All")
            {
                loadstaffdata(nurseTable, "Nurse");
            }
            else
            {
                FilterByStatus(nurseTable, "Nurse", selectedStatus);
            }
        }
    }
}
