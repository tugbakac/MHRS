using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class frmGetAnAppointment : Form
    {
        Patient patient;
        HospitalController hospitalController;
        PoliclinicController policlinicController;
        DoctorController doctorController;
        AppointmentController appointmentController;
        HourController hourController;
        Guid patientId;

        public frmGetAnAppointment(Guid patientID)
        {
            InitializeComponent();
            hourController = new HourController();
            patient = new Patient();
            hospitalController = new HospitalController();
            policlinicController = new PoliclinicController();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
            patientId = patientID;
            //id yi bu şekilde çekme imkanımız oluyor
        }



        private void frmGetAnAppointment_Load(object sender, EventArgs e)
        {
            ViewHospitalCombobox();
            ViewPoliclinicCombobox();
            ViewDoctorCombobox();
            ViewHoursCombobox();
        }

        void ViewHospitalCombobox()
        {
            cmbHospitals.DisplayMember = "HospitalName";
            cmbHospitals.ValueMember = "HospitalID";
            cmbHospitals.DataSource = hospitalController.GetHospitals();
        }

        void ViewHoursCombobox()
        {
            comboBox2.DisplayMember = "HourName";
            comboBox2.ValueMember = "HourID";
            comboBox2.DataSource = hourController.GetAllHours();
        }

        void ViewPoliclinicCombobox()
        {
            cmbPoliclinics.DisplayMember = "PoliclinicName";
            cmbPoliclinics.ValueMember = "PoliclinicID";
            cmbPoliclinics.DataSource = policlinicController.GetPoliclinics();
        }

        void ViewDoctorCombobox()
        {
            comboBox1.DisplayMember = "DoctorName";
            comboBox1.ValueMember = "DoctorID";
            comboBox1.DataSource = doctorController.GetDoctors();
        }

        private void btnGetThisAppointment_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment();
            newAppointment.DoctorID = Convert.ToInt32(comboBox1.SelectedValue);
            newAppointment.PatientID = patient.PatientID;
            newAppointment.AppointmentDate = dtpAppointmentDate.Value.Date;
            newAppointment.HospitalID = Convert.ToInt32(cmbHospitals.SelectedValue);
            newAppointment.PoliclinicID = Convert.ToInt32(cmbPoliclinics.SelectedValue);
            newAppointment.AppointmentTime = Convert.ToInt32(comboBox2.SelectedValue);




            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    Button gelenButon = item as Button;
                    gelenButon.Click += new EventHandler(btn_Click);
                }
            }

            //switch (comboBox2.SelectedIndex)
            //{
            //    case 0:
            //        btn1.BackColor = Color.Red;
            //        btn1.Enabled = false;
            //        break;
            //    case 1:
            //        btn2.BackColor = Color.Red;
            //        btn2.Enabled = false;
            //        break;
            //    case 2:
            //        btn3.BackColor = Color.Red;
            //        btn3.Enabled = false;
            //        break;
            //    case 3:
            //        btn4.BackColor = Color.Red;
            //        btn4.Enabled = false;
            //        break;
            //    case 4:
            //        btn5.BackColor = Color.Red;
            //        btn5.Enabled = false;
            //        break;
            //    case 5:
            //        btn6.BackColor = Color.Red;
            //        btn6.Enabled = false;
            //        break;
            //    case 6:
            //        btn7.BackColor = Color.Red;
            //        btn7.Enabled = false;
            //        break;
            //    case 7:
            //        btn8.BackColor = Color.Red;
            //        btn8.Enabled = false;
            //        break;
            //    case 8:
            //        btn9.BackColor = Color.Red;
            //        btn9.Enabled = false;
            //        break;
            //    case 9:
            //        btn10.BackColor = Color.Red;
            //        btn10.Enabled = false;
            //        break;
            //    case 10:
            //        btn11.BackColor = Color.Red;
            //        btn11.Enabled = false;
            //        break;
            //    case 11:
            //        btn12.BackColor = Color.Red;
            //        btn12.Enabled = false;
            //        break;
            //    case 12:
            //        btn13.BackColor = Color.Red;
            //        btn13.Enabled = false;
            //        break;
            //    case 13:
            //        btn14.BackColor = Color.Red;
            //        btn14.Enabled = false;
            //        break;
            //    case 14:
            //        btn15.BackColor = Color.Red;
            //        btn15.Enabled = false;
            //        break;
            //    case 15:
            //        btn16.BackColor = Color.Red;
            //        btn16.Enabled = false;
            //        break;
            //}

            bool result = false;

            try
            {
                result = appointmentController.AddAppointmentController(newAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(result ? "Registration Successful" : "Registration Failed");
        }

        private void lblMyPreviousAppointments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPreviousAppointment frmPreviousAppointment = new frmPreviousAppointment(patientId);
            frmPreviousAppointment.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        string[] hours = { "09:00", "09:30", "10:00", "10:30" };
        private void btn_Click(object sender, EventArgs e)
        {
            Button btnBasilan = (sender as Button);
            foreach (string item in hours)
            {
                if (item==btnBasilan.Text)
                {
                    btnBasilan.BackColor = Color.YellowGreen;
                    btnBasilan.Enabled = false;
                }
            }
        }
    }
}
