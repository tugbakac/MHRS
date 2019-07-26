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
using MHRS_DTO_;

namespace MHRS_UI
{
    public partial class frmDoctorLogin : Form
    {
        DoctorController doctorController;
        LoginDTO login;

        public frmDoctorLogin()
        {
            InitializeComponent();
            doctorController = new DoctorController();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Exit Approval", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            login = new LoginDTO();
            login.Mail = txtDoctorUsername.Text;
            login.Password = txtDoctorPassword.Text;

            string result = doctorController.DoctorLogin(login);
            Guid doctorUserID;
            if (Guid.TryParse(result, out doctorUserID))
            {

                frmDoctorWorkDay frm = new frmDoctorWorkDay(doctorUserID);
                frm.Owner = this;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result);
            }


        }
    }
}
