using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS_BLL;
using MHRS_DTO_;
using MHRS_Entity;

namespace MHRS_UI
{
    public partial class frmPatientLogin : Form
    {
        PatientController patientController;
        LoginDTO loginDTO;

        public frmPatientLogin()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void lblNewPatientRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister formRegister = new frmRegister();
            formRegister.Owner = this;
            formRegister.ShowDialog();
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            loginDTO = new LoginDTO();
            loginDTO.Mail = txtPatientUsername.Text;
            loginDTO.Password = txtPatientPassword.Text;

            string result = patientController.Login(loginDTO);

            Guid patientID;
            if (Guid.TryParse(result,out patientID))
            {
                frmGetAnAppointment FormAppointment = new frmGetAnAppointment(patientID);
                FormAppointment.Owner = this;
                FormAppointment.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void frmPatientLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
