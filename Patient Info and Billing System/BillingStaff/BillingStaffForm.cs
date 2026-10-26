using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.BillingStaff
{
    public partial class BillingStaffForm : Form
    {
        public BillingStaffForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            timer.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
