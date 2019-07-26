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
    public partial class frmPreviousAppointment : Form
    {
        PatientController patientController;
        Patient currentPatient;

        public frmPreviousAppointment(Guid patientID)
        {
            InitializeComponent();
            patientController = new PatientController();
            currentPatient = patientController.GetPatientID(patientID);
        }
        
        void ViewAllAppointments()
        {
            listView1.Items.Clear();

            List<Appointment> appointment = patientController.GetAllAppointments(currentPatient.PatientID);

            ListViewItem lvi;

            foreach(var item in appointment)
            {
                lvi = new ListViewItem();
                lvi.Text = item.AppointmentID.ToString();
                lvi.SubItems.Add(item.AppointmentDate.ToString());
                lvi.SubItems.Add(item.AppointmentTime.ToString());
                lvi.SubItems.Add(item.PoliclinicID.ToString());
                lvi.SubItems.Add(item.HospitalID.ToString());
                lvi.SubItems.Add(item.DoctorID.ToString());
                listView1.Items.Add(lvi);
            }

            //listBox1.DataSource = appointment;
            //DataSource listView1 için gelmeli!?
        }

        private void frmPreviousAppointment_Load(object sender, EventArgs e)
        {
            ViewAllAppointments();
        }
        
    }
}
