using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_Entity;


namespace MHRS_DAL
{
    public class HourManagement
    {
        SqlConnection connection;
        SqlCommand command;

        public HourManagement()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
        }

        public List<Hours> GetHours()
        {
            List<Hours> hourList = new List<Hours>();
            command = new SqlCommand("select * from [HOURS]", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Hours hours = new Hours();
                hours.HourID = reader.GetInt32(0);
                hours.HourName = reader.GetString(1);
                hourList.Add(hours);
            }

            reader.Close();
            return hourList;
        }
    }
}
