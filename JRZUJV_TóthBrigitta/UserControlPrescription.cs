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
    public partial class UserControlPrescription : UserControl
    {
        beadandó_JRZUJVEntities context = new beadandó_JRZUJVEntities();
        public UserControlPrescription()
        {
            InitializeComponent();
            label1.Text = "\uF78B";
            label2.Text = "\uF78B";
            btnSave.Text = "\uE74E";
            btnDelete.Text = "\uE74D";
            listBoxPatient.DisplayMember = "Name";
            listBoxMedication.DisplayMember = "Name";
            listBoxPrescription.DisplayMember = "Name";
            listBoxPrescription.ValueMember = "PrescriptionID";
        }

        private void textBoxPatient_TextChanged(object sender, EventArgs e)
        {
            PatientSzűrés();
        }

        private void PatientSzűrés()
        {
            var xy = from x in context.Patients
                     where x.Name.Contains(textBoxPatient.Text)
                     select x;
            listBoxPatient.DataSource = xy.ToList();
        }

        private void UserControlPrescription_Load(object sender, EventArgs e)
        {
            PatientSzűrés();
            MedicationSzűrés();
        }

        private void textBoxMedication_TextChanged(object sender, EventArgs e)
        {
            MedicationSzűrés();
        }

        private void MedicationSzűrés()
        {
            var xy = from x in context.Medications
                     where x.Name.Contains(textBoxMedication.Text)
                     select x;
            listBoxMedication.DataSource = xy.ToList();
        }

        private void listBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrescriptionListázás();
        }

        private void PrescriptionListázás()
        {
            if (listBoxPatient.SelectedItem == null) return;

            var p = (Patient)listBoxPatient.SelectedItem;

            var gyógyszerek = from x in context.Prescriptions
                              where x.PatientID_FK == p.PatientID
                              select new { x.Patient.PatientID, x.Medication.Name, x.PrescriptionID };

            listBoxPrescription.DataSource = gyógyszerek.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var patient = (Patient)listBoxPatient.SelectedItem;
            var medication = (Medication)listBoxMedication.SelectedItem;

            Prescription newPrescription = new Prescription();
            newPrescription.PatientID_FK = patient.PatientID;
            newPrescription.MedicationID_FK = medication.MedicationID;

            context.Prescriptions.Add(newPrescription);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            PrescriptionListázás();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var törlendő = (from x in context.Prescriptions
                           where x.PrescriptionID == (int)listBoxPrescription.SelectedValue
                           select x).FirstOrDefault();

            context.Prescriptions.Remove(törlendő);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            PrescriptionListázás();
        }
    }
}
