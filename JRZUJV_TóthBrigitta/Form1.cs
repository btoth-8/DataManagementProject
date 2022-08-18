using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRZUJV_TóthBrigitta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLoad.Text = "\uE80F";
            btnIdőpont.Text = "\uE8FA";
            btnPatient.Text = "\uE716";
            btnPrescription.Text = "\uE71D";
            btnAppointment.Text = "\uE773";
            btnEnd.Text = "\uE7E8";
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlPrescription ucP = new UserControlPrescription();
            panel1.Controls.Add(ucP);
            ucP.Dock = DockStyle.Fill;
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAppointment ucA = new UserControlAppointment();
            panel1.Controls.Add(ucA);
            ucA.Dock = DockStyle.Fill;
        }

        private void btnIdőpont_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();          
            UserControlLoad ucL = new UserControlLoad();
            panel1.Controls.Add(ucL);
            ucL.Dock = DockStyle.Fill;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlLoad ucL = new UserControlLoad();
            panel1.Controls.Add(ucL);
            ucL.Dock = DockStyle.Fill;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
