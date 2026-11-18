using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AdminManage : UserControl
    {
        public AdminManage()
        {
            InitializeComponent();
        }

        private void AdminManage_Load(object sender, EventArgs e)
        {
            searchText.PlaceholderText = "Type to search...";
        }
    }
}
