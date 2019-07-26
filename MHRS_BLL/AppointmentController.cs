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
    public class AppointmentController
    {
        AppointmentManagement appointmentManagement;

        public AppointmentController()
        {
            appointmentManagement = new AppointmentManagement();
        }

        public bool AddAppointmentController(Appointment appointment)
        {
            int result = appointmentManagement.AddAppointment(appointment);

            return result > 0;
        }

    }
}
