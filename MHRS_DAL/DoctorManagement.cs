using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;

namespace MHRS_DAL
{
    public class DoctorManagement
    {
        //Doctor database ve entitiy üzerinde randevu saat bilgisi ve gerektiğinde güncelleme eklenecek

        SqlConnection connection;
        SqlCommand command;
        DateTime dt;
        Doctor doctor;
        Appointment appointmentDate;

        public DoctorManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
            appointmentDate = new Appointment();
            doctor = new Doctor();
        }


        //Randevu tarihlerine göre Doktorun o günkü randevularını listelemesi
        public List<Appointment> ViewAppointmentByDatetime(DateTime AppointmentDate, int DoctorID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            command = new SqlCommand("select * from [APPOINTMENT] where AppointmentDate=@appointmentDate and DoctorID=@doctorID", connection);
            command.Parameters.AddWithValue("@appointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@doctorID", DoctorID);

            Appointment appointment;

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

        public List<Appointment> ViewPreviousByDatetime(DateTime AppointmentDate, int DoctorID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            command = new SqlCommand("select * from [APPOINTMENT] where AppointmentDate<@appointmentDate and DoctorID=@doctorID", connection);
            command.Parameters.AddWithValue("@appointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@doctorID", DoctorID);

            Appointment appointment;

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

        public int DeleteAppointment(Appointment appointment)
        {
            command = new SqlCommand("delete from Appointment where AppointmentID=@AppointmentID", connection);
            command.Parameters.AddWithValue("@AppointmentID", appointment);
            return ExecuteCommand();

        }

        int ExecuteCommand()
        {
            try
            {
                connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctorList = new List<Doctor>();
            command = new SqlCommand("select * from [DOCTORS]", connection);
            Doctor currentDoctor = null;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                currentDoctor = new Doctor();
                currentDoctor.DoctorID = reader.GetInt32(0);
                currentDoctor.DoctorUnique = reader.GetGuid(1);
                currentDoctor.DoctorName = reader.GetString(2);
                currentDoctor.DoctorSurname = reader.GetString(3);
                currentDoctor.DoctorEMail = reader.GetString(4);
                currentDoctor.DoctorPassword = reader.GetString(5);

                doctorList.Add(currentDoctor);
            }

            reader.Close();
            return doctorList;
        }

        public Doctor GetDoctor(Guid doctorUnique)
        {
            //Doctor doctor = new Doctor();
            command = new SqlCommand("select * from [DOCTORS] where DoctorUnique=@doctorUnique", connection);

            command.Parameters.AddWithValue("@doctorUnique", doctorUnique);
            //Doctor currentDoctor = null;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Doctor currentDoctor = new Doctor();
            currentDoctor.DoctorID = reader.GetInt32(0);
            currentDoctor.DoctorUnique = reader.GetGuid(1);
            currentDoctor.DoctorName = reader.GetString(2);
            currentDoctor.DoctorSurname = reader.GetString(3);
            currentDoctor.DoctorEMail = reader.GetString(4);
            currentDoctor.DoctorPassword = reader.GetString(5);

            reader.Close();
            return currentDoctor;
        }
    }
}
