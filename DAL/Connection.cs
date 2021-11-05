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

        private SqlConnection connection2 = new SqlConnection("Server=192.168.1.101; Database=RecepcionV2; User Id=sa; Password=Hospital0;");

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

        public SqlConnection OpenConnection2()
        {
            if (connection2.State == ConnectionState.Closed)
                connection2.Open();
            return connection2;
        }

        public SqlConnection CloseConnection2()
        {
            if (connection2.State == ConnectionState.Open)
                connection2.Close();
            return connection2;
        }
    }
}
