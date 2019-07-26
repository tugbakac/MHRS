using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MHRS_BLL;
using MHRS_Entity;

namespace MHRS_UI
{
    public partial class frmViewPrescription : Form
    {
        PharmacistController pharmacistController;

        public frmViewPrescription(Guid pharmacistID)
        {
            InitializeComponent();
            pharmacistController = new PharmacistController();
            pharmacistController.GetPharmacists();
        }

        private void frmViewPrescription_Load(object sender, EventArgs e)
        {

        }

        private void btnViewPrescription_Click(object sender, EventArgs e)
        {
            ViewPresciption();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to exit?", "Exit Approval", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
        }

        void ViewPresciption()
        {
            Guid patientID;

            if (Guid.TryParse(txtPatientID.Text, out patientID))
            {
                Prescription prescription = pharmacistController.GetPrescription(patientID);

                txtViewPrescription.Text = prescription.PrescriptionInfo;
            }
            else
            {
                MessageBox.Show(txtPatientID.Text);
            }
        }

        void ViewPreviousPrescriptionList()
        {
            Guid patientID;

            if (Guid.TryParse(txtPatientID.Text, out patientID))
            {
                List<Prescription> prescriptions = pharmacistController.GetPreviousPrescription(patientID);

                lstPreviousPrescription.DataSource = prescriptions;
            }
            else
            {
                MessageBox.Show(txtPatientID.Text);
            }

        }

        private void btnViewPreviousPrescription_Click(object sender, EventArgs e)
        {
            ViewPreviousPrescriptionList();
        }
    }
}
