using MHRS_BLL;
using MHRS_DTO_;
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
    public partial class frmPharmacistLogin : Form
    {
        PharmacistController pharmacistController;
        LoginDTO loginDTO;

        public frmPharmacistLogin()
        {
            InitializeComponent();
            pharmacistController = new PharmacistController();
        }

        private void btnPharmasistLogin_Click(object sender, EventArgs e)
        {
            loginDTO = new LoginDTO();
            loginDTO.Mail = txtPharmasistUsername.Text;
            loginDTO.Password = txtPharmasistPassword.Text;

            string result = pharmacistController.Login(loginDTO);
            Guid pharmacistID;

            if (Guid.TryParse(result, out pharmacistID))
            {
                frmViewPrescription forumViewPrescription = new frmViewPrescription(pharmacistID);
                forumViewPrescription.Owner = this;
                forumViewPrescription.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
