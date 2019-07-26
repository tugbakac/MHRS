using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;

namespace MHRS_DAL
{
    public class PharmacistManagement
    {
        SqlConnection connection;
        SqlCommand command;

        public PharmacistManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
        }

        public List<Prescription> GetPreviousPrescriptionByPatientID(Guid PatientID)
        {
            List<Prescription> prescriptionList = new List<Prescription>();
            command = new SqlCommand("select * from [PRESCRIPTION] where PatientID=@patientID", connection);
            command.Parameters.AddWithValue("@patientID", PatientID);

            Prescription prescription = null;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


            while (reader.Read())
            {
                prescription = new Prescription();
                prescription.PrescriptionID = reader.GetGuid(0);
                prescription.PrescriptionInfo = reader.GetString(1);
                prescription.PatientID = reader.GetGuid(2);
                prescription.DoctorUnique = reader.GetGuid(3);
                prescription.PrescriptionDate = reader.GetDateTime(5);

                prescriptionList.Add(prescription);
            }

            reader.Close();
            return prescriptionList;
        }

        public Prescription GetPrescriptionByPatientID(Guid PatientID)
        {
            command = new SqlCommand("select * from [PRESCRIPTION] where PatientID=@patientID", connection);
            command.Parameters.AddWithValue("@patientID",PatientID);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


            reader.Read();

            Prescription prescription = new Prescription();
            prescription.PrescriptionID = reader.GetGuid(0);
            prescription.PrescriptionInfo = reader.GetString(1);
            prescription.PatientID = reader.GetGuid(2);
            prescription.DoctorUnique = reader.GetGuid(3);
            prescription.PrescriptionDate = reader.GetDateTime(5);

            reader.Close();
            return prescription;
        }

        public Pharmacist GetPharmacistByID(Guid pharmacistID)
        {
            command = new SqlCommand("select * from [PHARMACIST] where PharmacistID=@pharmacistID", connection);

            command.Parameters.AddWithValue("@pharmacistID", pharmacistID);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


            reader.Read();
            Pharmacist pharmacist = new Pharmacist();
            pharmacist.PharmacistID = reader.GetGuid(0);
            pharmacist.PharmacistName = reader.GetString(1);
            pharmacist.PharmacistSurname = reader.GetString(2);
            pharmacist.PharmacistEMail = reader.GetString(3);
            pharmacist.PharmacistPassword = reader.GetString(4);

            reader.Close();
            return pharmacist;
        }

        public List<Pharmacist> GetAllPharmacists()
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
