using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class OperatingRooms
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetOperatingRooms()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarQuirofanos";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public void InsertOperatingRoom(string operatingRoomNumber, string actualStatus)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarQuirofanos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@no_quirofano", operatingRoomNumber);
            command.Parameters.AddWithValue("@estado_actual",actualStatus);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateOperatingRoom(string operatingRoomNumber, string actualStatus, bool status, int id)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditarQuirofanos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@no_quirofano", operatingRoomNumber);
            command.Parameters.AddWithValue("@estado_actual", actualStatus);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
