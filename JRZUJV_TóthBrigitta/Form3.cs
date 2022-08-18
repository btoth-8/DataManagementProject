using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRZUJV_TóthBrigitta
{
    public partial class Form3 : Form
    {
        beadandó_JRZUJVEntities context = new beadandó_JRZUJVEntities();
        public Form3()
        {

            InitializeComponent();
            context.Doctors.Load();
            doctorBindingSource.DataSource = context.Doctors.Local;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Name = textBoxName.Text;
            d.Position = textBoxPosition.Text;
            doctorBindingSource.Add(d);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
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

        private void textBoxPosition_Validating(object sender, CancelEventArgs e)
        {
             if (string.IsNullOrEmpty(textBoxPosition.Text))
             {
                e.Cancel = true;
                errorProvider1.SetError(textBoxPosition, "Nem lehet üres!");
             }
        }

        private void textBoxPosition_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPosition, "");
        }
    }
}
