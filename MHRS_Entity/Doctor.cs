using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS_Entity
{
    public class Doctor
    {
        public Doctor()
        {
            DoctorUnique = Guid.NewGuid();
        }

        public int DoctorID { get; set; }
        public Guid DoctorUnique { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string DoctorEMail { get; set; }
        public string DoctorPassword { get; set; }
        public int PoliclinicID { get; set; }
    }
}
