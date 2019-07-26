using MHRS_BLL;
using MHRS_Entity;
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
    public partial class frmAdminRegister : Form
    {
        AdminController adminController;
        PoliclinicController policlinicController;

        public frmAdminRegister()
        {
            InitializeComponent();
            adminController = new AdminController();
            policlinicController = new PoliclinicController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                txtPasswordConfirm.BackColor = Color.Red;
                txtPasswordConfirm.Select();
                return;
            }

            Doctor newDoctor = new Doctor();
            newDoctor.DoctorName = txtName.Text;
            newDoctor.DoctorSurname = txtSurname.Text;
            newDoctor.DoctorEMail = txtEmail.Text;
            newDoctor.DoctorPassword = txtPassword.Text;
            newDoctor.PoliclinicID = Convert.ToInt32(cmbPoliclinics.SelectedValue);

            bool result = false;

            try
            {
                result = adminController.AddDoctor(newDoctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(result ? "Registration Successful" : "Registration Failed");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                txtPasswordConfirm.BackColor = Color.Red;
                txtPasswordConfirm.Select();
                return;
            }

            Pharmacist newPharmacist = new Pharmacist();
            newPharmacist.PharmacistName = txtName.Text;
            newPharmacist.PharmacistSurname = txtSurname.Text;
            newPharmacist.PharmacistEMail = txtEmail.Text;
            newPharmacist.PharmacistPassword = txtPassword.Text;

            bool result = false;

            try
            {
                result = adminController.AddPharmacist(newPharmacist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(result ? "Registration Successful" : "Registration Failed");
        }

        void ViewPoliclinicCombobox()
        {
            cmbPoliclinics.DisplayMember = "PoliclinicName";
            cmbPoliclinics.ValueMember = "PoliclinicID";
            cmbPoliclinics.DataSource = policlinicController.GetPoliclinics();
        }

        private void frmAdminRegister_Load(object sender, EventArgs e)
        {
            ViewPoliclinicCombobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
