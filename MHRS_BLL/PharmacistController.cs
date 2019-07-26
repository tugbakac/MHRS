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
    public class PharmacistController
    {
        PharmacistManagement pharmacistManagement;

        public PharmacistController()
        {
            pharmacistManagement = new PharmacistManagement();
        }

        public Prescription GetPrescription(Guid patientID)
        {
            return pharmacistManagement.GetPrescriptionByPatientID(patientID);
        }

        public List<Prescription> GetPreviousPrescription(Guid patientID)
        {
            return pharmacistManagement.GetPreviousPrescriptionByPatientID(patientID);
        }

        public string Login(LoginDTO loginDTO)
        {
            List<Pharmacist> pharmacists = pharmacistManagement.GetAllPharmacists();

            foreach (Pharmacist item in pharmacists)
            {
                if (item.PharmacistEMail == loginDTO.Mail)
                {
                    if (item.PharmacistPassword == loginDTO.Password)
                    {
                        return item.PharmacistID.ToString();
                    }
                    else
                    {
                        return "Password is invalid";
                    }
                }
            }
            return "E-mail is invalid";
        }

        public List<Pharmacist> GetPharmacists()
        {
            return pharmacistManagement.GetAllPharmacists();
        }
    }
}
