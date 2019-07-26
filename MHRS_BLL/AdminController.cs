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
    public class AdminController
    {
        AdminManagement adminManagement;
        CheckRegisterController controller;

        public AdminController()
        {
            adminManagement = new AdminManagement();
            controller = new CheckRegisterController();
        }

        public bool AddDoctor(Doctor doctor)
        {
            CheckValuesDoctor(doctor);

            bool isExist = CheckMailDoctor(doctor.DoctorEMail);

            if (isExist)
            {
                throw new Exception("This E-mail address is already registered");
            }

            controller.CheckPassword(doctor.DoctorPassword);

            int result = adminManagement.AddDoctor(doctor);

            return result > 0;
        }

        bool CheckMailDoctor(string mail)
        {
            try
            {
                System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(mail);
            }
            catch (Exception)
            {
                throw new EmailEnterException();
            }

            List<Doctor> doctorList = adminManagement.GetAllDoctors();

            foreach (Doctor item in doctorList)
            {
                if (item.DoctorEMail == mail)
                {
                    return true;
                }
            }
            return false;
        }

        void CheckValuesDoctor(Doctor doctor)
        {
            if (string.IsNullOrWhiteSpace(doctor.DoctorName))
            {
                throw new NameBlankException();
            }
            else if (string.IsNullOrWhiteSpace(doctor.DoctorSurname))
            {
                throw new SurnameBlankException();
            }
            else if (string.IsNullOrWhiteSpace(doctor.DoctorEMail))
            {
                throw new EmailBlankException();
            }
            else if (string.IsNullOrWhiteSpace(doctor.DoctorPassword))
            {
                throw new PasswordBlankException();
            }
        }


        public bool AddPharmacist(Pharmacist pharmacist)
        {
            CheckValuesPharmacist(pharmacist);

            bool isExist = CheckMailPharmacist(pharmacist.PharmacistEMail);

            if (isExist)
            {
                throw new Exception("This E-mail address is already registered");
            }

            controller.CheckPassword(pharmacist.PharmacistPassword);

            int result = adminManagement.AddPharmacist(pharmacist);

            return result > 0;
        }

        bool CheckMailPharmacist(string mail)
        {
            try
            {
                System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(mail);
            }
            catch (Exception)
            {
                throw new EmailEnterException();
            }

            List<Pharmacist> pharmacistList = adminManagement.GetAllPharmacist();

            foreach (Pharmacist item in pharmacistList)
            {
                if (item.PharmacistEMail == mail)
                {
                    return true;
                }
            }
            return false;
        }

        void CheckValuesPharmacist(Pharmacist pharmacist)
        {
            if (string.IsNullOrWhiteSpace(pharmacist.PharmacistName))
            {
                throw new NameBlankException();
            }
            else if (string.IsNullOrWhiteSpace(pharmacist.PharmacistSurname))
            {
                throw new SurnameBlankException();
            }
            else if (string.IsNullOrWhiteSpace(pharmacist.PharmacistEMail))
            {
                throw new EmailBlankException();
            }
            else if (string.IsNullOrWhiteSpace(pharmacist.PharmacistPassword))
            {
                throw new PasswordBlankException();
            }
        }
    }
}
