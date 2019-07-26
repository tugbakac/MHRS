using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_DAL;
using MHRS_DTO_;
using MHRS_Entity;

namespace MHRS_BLL
{
    public class DoctorController
    {
        Doctor doctor;
        DoctorManagement doctorManagement;

        public DoctorController()
        {
            doctorManagement = new DoctorManagement();
            doctor = new Doctor();
        }

        public bool Delete(Appointment appointment)
        {
            int result = doctorManagement.DeleteAppointment(appointment);
            return result > 0;
        }

        public List<Appointment> ViewActualAppointment(DateTime dateTime, int doctorID)
        {
            if (dateTime == DateTime.Today)
            {
                return doctorManagement.ViewAppointmentByDatetime(dateTime, doctorID);

            }
            else
            {
                return null;
            }
        }

        public List<Doctor> GetDoctors()
        {
            return doctorManagement.GetAllDoctors();
        }

        public Doctor GetDoctor(Guid doctorID)
        {
            return doctorManagement.GetDoctor(doctorID);
        }

        public List<Appointment> ViewPreviousAppointment(DateTime dateTime, int doctorID)
        {
            if(dateTime == DateTime.Today)
            {
                return doctorManagement.ViewPreviousByDatetime(dateTime, doctorID);
            }
            else
            {
                return null;
            }
        }

        public string DoctorLogin(LoginDTO login)
        {
            List<Doctor> doctors = doctorManagement.GetAllDoctors();
            foreach (Doctor item in doctors)
            {
                if (item.DoctorEMail == login.Mail)
                {
                    if (item.DoctorPassword == login.Password)
                    {
                        return item.DoctorUnique.ToString();
                    }
                    else
                    {
                        return "Password is invalid";
                    }
                }

            }
            return "Email is invalid";

        }


    }
}
