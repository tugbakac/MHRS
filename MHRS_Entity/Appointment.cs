using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS_Entity
{
    public class Appointment
    {
        public Appointment()
        {
            AppointmentID = Guid.NewGuid();
        }
        public Guid AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public Guid PatientID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int HospitalID { get; set; }
        public int PoliclinicID { get; set; }
        public int AppointmentTime { get; set; }
    }
}
