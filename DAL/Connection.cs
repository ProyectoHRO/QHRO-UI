using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class Connection
    {
        private SqlConnection connection = new SqlConnection("Server=25.12.40.132;DataBase=HROBD;User=hroadmin;Password=database123");

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
