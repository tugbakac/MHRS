using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS_Entity
{
    public class Patient
    {
        public Patient()
        {
            PatientID = Guid.NewGuid();
        }
        public Guid PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientEMail { get; set; }
        public string PatientPassword { get; set; }

    }
}
