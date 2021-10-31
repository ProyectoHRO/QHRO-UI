using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Anesthesia
    {
        private Connection connection = new Connection();
        SqlDataReader read;
        DataTable tableData;

        SqlCommand command = new SqlCommand();
        public DataTable GetAnestheasia()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarTipoAnestesia";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetAnesthesiaByAnesthesiaType(string AnesthesiaType)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarTipoAnestesiaPorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", AnesthesiaType);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetAnesthesiaById(int anesthesiaId)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarTipoAnestesiaPorId";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", anesthesiaId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public void InsertAnesthesiaType(string AnesthesiaType)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarTipoAnestesia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", AnesthesiaType);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateAnesthesiaType(string AnesthesiaType, int anesthesiaId)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "ModificarTipoAnestesia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", AnesthesiaType);
            command.Parameters.AddWithValue("@id", anesthesiaId);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
