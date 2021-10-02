using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Services
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetServices()
        {
                tableData = new DataTable();
                command.Connection = connection.OpenConnection();
                command.CommandText = "MostrarServicios";
                command.CommandType = CommandType.StoredProcedure;
                read = command.ExecuteReader();
                tableData.Load(read);
                connection.CloseConnection();
                return tableData;
        }

        public DataTable GetServicesByName(string serviceName)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarServicioPorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", serviceName);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public void InsertService(string serviceName)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarServicio";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", serviceName); 
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateService(string serviceName, int id)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditarServicio";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", serviceName);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
