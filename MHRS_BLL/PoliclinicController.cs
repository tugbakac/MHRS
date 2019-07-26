using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_DAL;
using MHRS_Entity;
using MHRS_DTO_;

namespace MHRS_BLL
{
    public class PoliclinicController
    {
        PoliclinicManagement policlinicManagement;

        public PoliclinicController()
        {
            policlinicManagement = new PoliclinicManagement();
        }

        public List<Policlinic> GetPoliclinics()
        {
            return policlinicManagement.GetAllPoliclinics();
        }
    }
}
