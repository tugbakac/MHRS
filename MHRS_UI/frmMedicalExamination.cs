using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS_BLL;
using MHRS_Entity;
using MHRS_DTO_;

namespace MHRS_UI
{
    public partial class frmMedicalExamination : Form
    {
        Prescription prescription;
        PatientController patientController;
        Patient currentPatient;

        public frmMedicalExamination(Guid patientID)
        {
            InitializeComponent();
            prescription = new Prescription();
            patientController = new PatientController();
            currentPatient = patientController.GetPatientID(patientID);
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            frmGetAnAppointment frm = new frmGetAnAppointment(currentPatient.PatientID);
            frm.ShowDialog();
            
        }

        private void btnCreatePrescription_Click(object sender, EventArgs e)
        {
            prescription.PrescriptionInfo = textBox1.Text;
        }
    }
}
