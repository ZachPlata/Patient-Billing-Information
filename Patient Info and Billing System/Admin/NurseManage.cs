using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class NurseManage : UserControl
    {
        public NurseManage()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void NurseManage_Load(object sender, EventArgs e)
        {
            searchText.PlaceholderText = "Type to search...";
        }
    }
}
