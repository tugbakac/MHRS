using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;

namespace MHRS_DAL
{
    public class HospitalManagement
    {
        SqlConnection connection;
        SqlCommand command;

        public HospitalManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
        }

        public List<Hospital> GetAllHospitals()
        {
            List<Hospital> hospitalList = new List<Hospital>();
            command = new SqlCommand("select * from [HOSPITAL]", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.HospitalID = reader.GetInt32(0);
                hospital.HospitalName = reader.GetString(1);
                hospitalList.Add(hospital);
            }

            reader.Close();
            return hospitalList;
        }

        

        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            command = new SqlCommand("select * from [APPOINTMENT]", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Appointment appointment = new Appointment();
                appointment.AppointmentID = reader.GetGuid(0);
                appointment.AppointmentDate = reader.GetDateTime(3);
                appointment.AppointmentTime = reader.GetInt32(6);
                appointmentList.Add(appointment);
            }

            reader.Close();
            return appointmentList;
        }

       
    }
}
