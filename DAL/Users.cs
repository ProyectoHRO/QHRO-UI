using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Users
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetDataUsers(string user, string password)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "IniciarSesion";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@usuario", user);
            command.Parameters.AddWithValue("@contra", password);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
    }
}
