using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS_UI
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorLogin formDoctor = new frmDoctorLogin();
            formDoctor.Owner = this;
            formDoctor.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientLogin formPatient = new frmPatientLogin();
            formPatient.Owner = this;
            formPatient.Show();
        }

        private void pharmacistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPharmacistLogin formPharmacist = new frmPharmacistLogin();
            formPharmacist.Owner = this;
            formPharmacist.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminRegister frmAdminRegister = new frmAdminRegister();
            frmAdminRegister.Owner = this;
            frmAdminRegister.Show();
        }
    }
}
