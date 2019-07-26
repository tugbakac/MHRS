using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;
using MHRS_DAL;

namespace MHRS_BLL
{
    public class HourController
    {
        HourManagement hourManagement;

        public HourController()
        {
            hourManagement = new HourManagement();
        }

        public List<Hours> GetAllHours()
        {
            return hourManagement.GetHours();
        }
    }
}
