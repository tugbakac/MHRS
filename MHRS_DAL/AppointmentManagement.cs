using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;

namespace MHRS_DAL
{
    public class AppointmentManagement
    {
        SqlConnection connection;
        SqlCommand command;

        public AppointmentManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
        }

        public int AddAppointment(Appointment appointment)
        {
            command = new SqlCommand("INSERT INTO [APPOINTMENT]VALUES(@appointmentID,@doctorID,@patientID,@appointmentDate,@hospitalID,@policlinicID,@appointmentTime)", connection);
            command.Parameters.AddWithValue("@appointmentID", appointment.AppointmentID);
            command.Parameters.AddWithValue("@doctorID", appointment.DoctorID);
            command.Parameters.AddWithValue("@patientID", appointment.PatientID);
            command.Parameters.AddWithValue("@appointmentDate", appointment.AppointmentDate);
            command.Parameters.AddWithValue("@hospitalID", appointment.HospitalID);
            command.Parameters.AddWithValue("@policlinicID", appointment.PoliclinicID);
            command.Parameters.AddWithValue("@appointmentTime", appointment.AppointmentTime);



            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int DeleteAppointment(Guid AppointmentID)
        {
            command = new SqlCommand("Delete [APPOINTMENT] where AppointmentID=@appointmentID");
            command.Parameters.AddWithValue("@appointmentID", AppointmentID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int UpdateAppointment(Appointment appointment)
        {
            command = new SqlCommand("Update [APPOINTMENT] set AppointmentTime=@newAppointmentTime,DoctorID=@newDoctorID,AppointmentDate=@newAppointmentDate", connection);
            //PatientID güncellenemez çünkü Patient değişikliği yapan kişidir zaten

            command.Parameters.AddWithValue("@newAppointmentTime", appointment.AppointmentTime);
            command.Parameters.AddWithValue("@newDoctorID", appointment.DoctorID);
            command.Parameters.AddWithValue("@newAppointmentDate", appointment.AppointmentDate);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Appointment> ViewPatientByID(Guid PatientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            command = new SqlCommand("select * from [APPOINTMENT] where PatientID=@patientID", connection);
            Appointment appointment = null;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                appointment = new Appointment();
                appointment.AppointmentID = reader.GetGuid(0);
                appointment.DoctorID = reader.GetInt32(1);
                appointment.PatientID = reader.GetGuid(2);
                appointment.AppointmentDate = reader.GetDateTime(3);
                appointment.HospitalID = reader.GetInt32(4);
                appointment.PoliclinicID = reader.GetInt32(5);
                appointment.AppointmentTime = reader.GetInt32(6);

                appointmentList.Add(appointment);
            }

            reader.Close();
            return appointmentList;
        }
    }
}
