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
    public partial class UserControlAppointment : UserControl
    {
        beadandó_JRZUJVEntities context = new beadandó_JRZUJVEntities();

        public UserControlAppointment()
        {
            InitializeComponent();
            Szűrés();
            label1.Text = "\uF78B";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szűrés();
            
        }

        private void Szűrés()
        {
            var xy = from x in context.Procedures
                     where x.Name.Contains(textBox1.Text)
                     select x;

            listBox1.DataSource = xy.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Procedure xy = (Procedure)listBox1.SelectedItem;

            var yx = from x in context.Patients
                     where x.PatientID == xy.DoctorID_FK
                     select new { x.Name, x.Address, x.Phone };

            dataGridView1.DataSource = yx.ToList();

        }
    }
}
