using System;
using System.Drawing;
using System.Windows.Forms;



namespace NurseDashBoard
{
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }


        //changes color of the button when clicked
        private Color normalColor = Color.FromArgb(17, 34, 64);
        private Color activeColor = Color.FromArgb(37, 99, 235);

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void SetActiveButton(Button selectedButton)
        {
            btn_nursedash.BackColor = normalColor;
            btn_ptntrec.BackColor = normalColor;
            btn_ptntreg.BackColor = normalColor;
            btn_util.BackColor = normalColor;
            btn_util.BackColor = normalColor;
            btn_shiftlog.BackColor = normalColor;
            btn_shiftlog.BackColor = normalColor;

            selectedButton.BackColor = activeColor;
        }


        //PANEL CONTENT BUTTONS

        private void btn_nursedash_Click(object sender, EventArgs e)
        {
            // SHOWING THE FORMS WHEN THE BUTTONS ARE CLICKED
            uc_dashboard frm = new uc_dashboard();



            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_nursedash);

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ptntreg_Click(object sender, EventArgs e)
        {
            uc_RegistrationPatients frm = new uc_RegistrationPatients();



            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_ptntreg);
        }

        private void btn_ptntrec_Click(object sender, EventArgs e)
        {

        }



        private void btn_util_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void LABEL_Click(object sender, EventArgs e)
        {
        }

        private void btn_shiftlog_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
