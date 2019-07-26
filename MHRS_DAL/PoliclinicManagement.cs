using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;

namespace MHRS_DAL
{
    public class PoliclinicManagement
    {
        SqlConnection connection;
        SqlCommand command;

        public PoliclinicManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
        }

        public List<Policlinic> GetAllPoliclinics()
        {
            List<Policlinic> policlinicList = new List<Policlinic>();
            command = new SqlCommand("select * from [POLICLINIC]", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Policlinic policlinic = new Policlinic();
                policlinic.PoliclinicID = reader.GetInt32(0);
                policlinic.PoliclinicName = reader.GetString(1);
                policlinicList.Add(policlinic);
            }

            reader.Close();
            return policlinicList;
        }
    }
}
