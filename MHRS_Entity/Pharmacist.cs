using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS_Entity
{
    public class Pharmacist
    {
        public Pharmacist()
        {
            PharmacistID = Guid.NewGuid();
        }
        public Guid PharmacistID { get; set; }
        public string PharmacistName { get; set; }
        public string PharmacistSurname { get; set; }
        public string PharmacistEMail { get; set; }
        public string PharmacistPassword { get; set; }
    }
}
