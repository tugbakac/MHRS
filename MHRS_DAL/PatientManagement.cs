using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;

namespace MHRS_DAL
{
    public class PatientManagement
    {
        SqlConnection connection;
        SqlCommand command;
        public PatientManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
        }

        public int Add(Patient patient)
        {
            command = new SqlCommand("insert into [PATIENT] values(@patientID,@patientName,@patientSurname,@patientEMail,@PatientPassword)", connection);
            AddParametersToCommand(patient);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        private void AddParametersToCommand(Patient patient)
        {
            command.Parameters.AddWithValue("@patientID", patient.PatientID);
            command.Parameters.AddWithValue("@patientName", patient.PatientName);
            command.Parameters.AddWithValue("@patientSurname", patient.PatientSurname);
            command.Parameters.AddWithValue("@patientEMail", patient.PatientEMail);
            command.Parameters.AddWithValue("@patientPassword", patient.PatientPassword);
        }

        public int Delete(Guid patientID)
        {
            command = new SqlCommand("Delete [PATIENT] where PatientID=@patientID",connection);
            command.Parameters.AddWithValue("@patientID", patientID);
            
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;


        }
        public int Update(Patient patient)
        {
            command = new SqlCommand("Update [PATIENT] set PatientName=@newName,PatientSurname=@newSurname,PatientPassword=@newPassword where PatientID=@patientID",connection);
            command.Parameters.AddWithValue("@newName", patient.PatientName);
            command.Parameters.AddWithValue("@newSurname", patient.PatientSurname);
            command.Parameters.AddWithValue("@newPassword", patient.PatientPassword);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patientList = new List<Patient>();
            command = new SqlCommand("select * from [PATIENT]", connection);
            Patient patient = null;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while(reader.Read())
            {
                patient = new Patient();
                patient.PatientID = reader.GetGuid(0);
                patient.PatientName = reader.GetString(1);
                patient.PatientSurname = reader.GetString(2);
                patient.PatientEMail = reader.GetString(3);
                patient.PatientPassword = reader.GetString(4);
                patientList.Add(patient);
            }
            reader.Close();
            return patientList;
        }

        public Patient GetPatientByID(Guid patientID)
        {
            command = new SqlCommand("select * from [PATIENT] where PatientID=@patientID", connection);
            command.Parameters.AddWithValue("@patientID", patientID);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Patient patient = new Patient();
            patient.PatientID = patientID;
            patient.PatientName = reader.GetString(1);
            patient.PatientSurname = reader.GetString(2);
            patient.PatientEMail = reader.GetString(3);
            patient.PatientPassword = reader.GetString(4);

            reader.Close();
            return patient;
        }
    }
}
