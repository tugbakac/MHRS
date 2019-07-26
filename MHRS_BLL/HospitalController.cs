using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_DAL;
using MHRS_Entity;
using MHRS_DTO_;
using System.Data.SqlClient;

namespace MHRS_BLL
{

    public class HospitalController
    {
        HospitalManagement hospitalManagement;

        public HospitalController()
        {
            hospitalManagement = new HospitalManagement();
        }

        public List<Hospital> GetHospitals()
        {
            return hospitalManagement.GetAllHospitals();
        }
    }
}
