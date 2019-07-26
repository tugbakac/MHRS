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
    public class PatientController
    {
        PatientManagement patientManagement;
        AppointmentManagement appointmentManagement;
        CheckRegisterController controller;

        public PatientController()
        {
            patientManagement = new PatientManagement();
            controller = new CheckRegisterController();
            appointmentManagement = new AppointmentManagement(); 
        }

        public Patient GetPatientID(Guid patientID)
        {
            return patientManagement.GetPatientByID(patientID);
        }

        public bool Add(Patient patient)
        {
            CheckValues(patient);

            bool isExist = CheckMail(patient.PatientEMail);

            if (isExist)
            {
                throw new EmailRegisteredException();
            }

            controller.CheckPassword(patient.PatientPassword);

            int result = patientManagement.Add(patient);

            return result > 0;
        }

        

        bool CheckMail(string mail)
        {
            try
            {
                System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(mail);
            }
            catch (Exception)
            {
                throw new EmailEnterException();
            }

            List<Patient> patientList = patientManagement.GetAllPatients();

            foreach (Patient item in patientList)
            {
                if (item.PatientEMail == mail)
                {
                    return true;
                }
            }
            return false;
        }

        void CheckValues(Patient patient)
        {
            if (string.IsNullOrWhiteSpace(patient.PatientName))
            {
                throw new NameBlankException();
            }
            else if (string.IsNullOrWhiteSpace(patient.PatientSurname))
            {
                throw new SurnameBlankException();
            }
            else if (string.IsNullOrWhiteSpace(patient.PatientEMail))
            {
                throw new EmailBlankException();
            }
            else if (string.IsNullOrWhiteSpace(patient.PatientPassword))
            {
                throw new PasswordBlankException();
            }
        }

        public string Login(LoginDTO loginDTO)
        {
            List<Patient> patients = patientManagement.GetAllPatients();

            foreach (Patient item in patients)
            {
                if (item.PatientEMail == loginDTO.Mail)
                {
                    if (item.PatientPassword == loginDTO.Password)
                    {
                        return item.PatientID.ToString();
                    }
                    else
                    {
                        return "Password is invalid";
                    }
                }
            }
            return "E-mail is invalid";
        }

        public List<Appointment> GetAllAppointments(Guid patientID)
        {
            return appointmentManagement.ViewPatientByID(patientID);
        }

    }
}
