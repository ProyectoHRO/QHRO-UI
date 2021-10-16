using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL.Properties;
using System.Configuration;
namespace DAL
{
    public class Connection
    {
        private static string getString()
        {
            return Settings.Default.HROBDConnectionString;
        }
        private SqlConnection connection = new SqlConnection(getString());

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public SqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }

    }
}
