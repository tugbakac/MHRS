using MHRS_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS_DAL
{
    public class AdminManagement
    {
        SqlConnection connection;
        SqlCommand command;
        public AdminManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
        }

        public int AddDoctor(Doctor doctor)
        {
            command = new SqlCommand("insert into [DOCTORS](DoctorUnique,DoctorName,DoctorSurname,DoctorEMail,DoctorPassword,PoliclinicID) values(@doctorUnique,@doctorName,@doctorSurname,@doctorEMail,@doctorPassword,@doctorPoliclinic)", connection);
            command.Parameters.AddWithValue("@doctorUnique", doctor.DoctorUnique);
            command.Parameters.AddWithValue("@doctorName", doctor.DoctorName);
            command.Parameters.AddWithValue("@doctorSurname", doctor.DoctorSurname);
            command.Parameters.AddWithValue("@doctorEMail", doctor.DoctorEMail);
            command.Parameters.AddWithValue("@doctorPassword", doctor.DoctorPassword);
            command.Parameters.AddWithValue("@doctorPoliclinic", doctor.PoliclinicID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int AddPharmacist(Pharmacist pharmacist)
        {
            command = new SqlCommand("insert into [PHARMACIST](PharmacistID,PharmacistName,PharmacistSurname,PharmacistEMail,PharmacistPassword) values(@pharmacistID,@pharmacistName,@pharmacistSurname,@pharmacistEMail,@pharmacistPassword)", connection);

            command.Parameters.AddWithValue("@pharmacistID", pharmacist.PharmacistID);
            
            command.Parameters.AddWithValue("@pharmacistName", pharmacist.PharmacistName);
            command.Parameters.AddWithValue("@pharmacistSurname", pharmacist.PharmacistSurname);
            command.Parameters.AddWithValue("@pharmacistEMail", pharmacist.PharmacistEMail);
            command.Parameters.AddWithValue("@pharmacistPassword", pharmacist.PharmacistPassword);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int DeleteDoctor(Guid DoctorUnique)
        {
            command = new SqlCommand("delete [DOCTORS] where DoctorUnique=@doctorUnique", connection);
            command.Parameters.AddWithValue("@doctorUnique", DoctorUnique);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int DeletePharmacist(Guid PharmacistID)
        {
            command = new SqlCommand("delete [PHARMACIST] where PharmacistID=@pharmacistID", connection);
            command.Parameters.AddWithValue("@pharmacistID", PharmacistID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctorList = new List<Doctor>();
            command = new SqlCommand("select * from [DOCTORS]", connection);
            Doctor doctor = null;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                doctor = new Doctor();
                doctor.DoctorID = reader.GetInt32(0);
                doctor.DoctorUnique = reader.GetGuid(1);
                doctor.DoctorName = reader.GetString(2);
                doctor.DoctorSurname = reader.GetString(3);
                doctor.DoctorEMail = reader.GetString(4);
                doctor.DoctorPassword = reader.GetString(5);
                doctorList.Add(doctor);
            }
            reader.Close();
            return doctorList;
        }

        public List<Pharmacist> GetAllPharmacist()
        {
            List<Pharmacist> pharmacistList = new List<Pharmacist>();
            command = new SqlCommand("select * from [PHARMACIST]", connection);
            Pharmacist pharmacist = null;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                pharmacist = new Pharmacist();
                pharmacist.PharmacistID = reader.GetGuid(0);
                pharmacist.PharmacistName = reader.GetString(1);
                pharmacist.PharmacistSurname = reader.GetString(2);
                pharmacist.PharmacistEMail = reader.GetString(3);
                pharmacist.PharmacistPassword = reader.GetString(4);
                pharmacistList.Add(pharmacist);
            }
            reader.Close();
            return pharmacistList;
        }
    }
}
