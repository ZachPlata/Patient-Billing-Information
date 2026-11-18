using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class DoctorManage : UserControl
    {
        public DoctorManage()
        {
            InitializeComponent();
        }

        private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorManage_Load(object sender, EventArgs e)
        {
            searchText.PlaceholderText = "Type to search...";

        }
    }
}
