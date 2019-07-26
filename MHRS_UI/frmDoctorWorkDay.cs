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
using MHRS_Entity;

namespace MHRS_UI
{
    public partial class frmDoctorWorkDay : Form
    {
        DoctorController _doctorController;
        LoginDTO loginDTO;
        Doctor currentDoctor;
        Patient patient;
        Appointment appointment;

        public frmDoctorWorkDay(Guid doctorUserID)
        {
            InitializeComponent();
            _doctorController = new DoctorController();
            currentDoctor = _doctorController.GetDoctor(doctorUserID);
            patient = new Patient();
            appointment = new Appointment();
        }

        private void btnViewActualExamination_Click(object sender, EventArgs e)
        {
            Frm_List();
        }

        private void Frm_List()
        {
            lstAppointments.Items.Clear();
            List<Appointment> actualExamination = _doctorController.ViewActualAppointment(DateTime.Today, currentDoctor.DoctorID);

            ListViewItem lvi;
            foreach (var item in actualExamination)
            {
                lvi = new ListViewItem();
                lvi.Text = item.AppointmentDate.ToString();
                lvi.SubItems.Add(item.AppointmentTime.ToString());
                lvi.Tag = item;
                lstAppointments.Items.Add(lvi);
            }


        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Exit Approval", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstAppointments.FocusedItem == null)
            {
                MessageBox.Show("Please select an appointment");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure to delete this appointment?", "Delete Approval", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                bool isDeleted = _doctorController.Delete((Appointment)lstAppointments.FocusedItem.Tag);
                if (isDeleted)
                {
                    MessageBox.Show("Appointment is deleted succesfully.");
                }
                else
                {
                    MessageBox.Show("Appointment isn't deleted.");
                }
              Frm_List2();
            }
            



        }

        private void btnCreateExamination_Click(object sender, EventArgs e)
        {
            if (lstAppointments.FocusedItem == null)
            {
                MessageBox.Show("Please select an appointment");
                return;
            }

            ListViewItem focused = lstAppointments.FocusedItem;
            frmMedicalExamination frm = new frmMedicalExamination(currentDoctor.DoctorUnique);
            frm.Show();
            this.Hide();
        }

        private void btnViewPreviousExamination_Click(object sender, EventArgs e)
        {
            Frm_List2();
        }

        private void Frm_List2()
        {
            lstAppointments.Items.Clear();
            List<Appointment> previousExamination = _doctorController.ViewPreviousAppointment(DateTime.Today, currentDoctor.DoctorID); 

            ListViewItem lvi;
            foreach (var item in previousExamination)
            {
                lvi = new ListViewItem();
                lvi.Text = item.AppointmentDate.ToString();
                lvi.SubItems.Add(item.AppointmentTime.ToString());
                lvi.Tag = item;
                lstAppointments.Items.Add(lvi);
            }


        }
    }
}
