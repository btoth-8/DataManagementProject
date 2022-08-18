using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRZUJV_TóthBrigitta
{
    public partial class Form2 : Form
    {
        beadandó_JRZUJVEntities context = new beadandó_JRZUJVEntities();
        public Form2()
        {
            InitializeComponent();
            btnNewPatient.Text = "\uE74E";
            btnDelete.Text = "\uE74D";
            label1.Text = "\uF78B";
            context.Patients.Load();
            patientBindingSource.DataSource = context.Patients.Local;
          

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
          Patient p = new Patient();
          p.Name = textBoxName.Text;
          p.Address = textBoxAddress.Text;
          p.Phone = Convert.ToInt32(this.textBoxPhone.Text);
          patientBindingSource.Add(p);
            
          try
          {
              context.SaveChanges();
          }
          catch (Exception ex)
          {
             MessageBox.Show(ex.Message);

          }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var xy = from x in context.Patients
                     where x.Name.Contains(textBox1.Text)
                     select x;
            dataGridView1.DataSource = xy.ToList();
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in  this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                 
            }
        }

        // Validálás

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "Nem lehet üres!");
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, "");
        }

       
        private void textBoxAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxAddress, "Nem lehet üres!");
            }
        }

        private void textBoxAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxAddress, "");

        }

       
        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[1-9][0-9]*$");
            if (!r.IsMatch(textBoxPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxPhone, "06/+36 nélkül kell beírni a telefonszámot");
            }

        }

        private void textBoxPhone_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPhone, "");

        }
    }
}
