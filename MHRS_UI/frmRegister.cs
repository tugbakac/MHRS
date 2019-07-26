using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MHRS_BLL;
using MHRS_Entity;
using MHRS_DTO_;

namespace MHRS_UI
{
    public partial class frmRegister : Form
    {
        PatientController patientController;

        public frmRegister()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text!=txtPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                txtPasswordConfirm.BackColor = Color.Red;
                txtPasswordConfirm.Select();
                return;
            }

            Patient newPatient = new Patient();
            newPatient.PatientName = txtName.Text;
            newPatient.PatientSurname = txtSurname.Text;
            newPatient.PatientEMail = txtEmail.Text;
            newPatient.PatientPassword = txtPassword.Text;

            //patientController.Add(newPatient);

            bool result = false;

            try
            {
                result = patientController.Add(newPatient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(result ? "Registration Successful" : "Registration Failed");
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Show();
        }
    }
}
