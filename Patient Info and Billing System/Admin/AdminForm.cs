using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            timer.Text = DateTime.Now.ToLongTimeString();
        }
        private void ActiveButton(Button currentButton)
        {
            btnAdminDashboard.BackColor = Color.FromArgb(17, 34, 64);
            btnClncDtSet.BackColor = Color.FromArgb(17, 34, 64);
            btnUserManagement.BackColor = Color.FromArgb(17, 34, 64);
            btnALAT.BackColor = Color.FromArgb(17, 34, 64);
            currentButton.BackColor = Color.FromArgb(37, 99, 235);

        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            AdminUserManagement form = new AdminUserManagement();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnClncDtSet_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
        }

        private void btnALAT_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
        }

        private void timer_Click(object sender, EventArgs e)
        {

        }
    }
}
