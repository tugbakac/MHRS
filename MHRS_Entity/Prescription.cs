using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS_Entity
{
    public class Prescription
    {
        public Prescription()
        {
            PrescriptionID = Guid.NewGuid();
        }
        public Guid PrescriptionID { get; set; }
        public string PrescriptionInfo { get; set; }

        public Guid PatientID { get; set; }
        public Guid DoctorUnique { get; set; }
        public Guid PharmacistID { get; set; }
        public DateTime PrescriptionDate { get; set; }
    }
}
