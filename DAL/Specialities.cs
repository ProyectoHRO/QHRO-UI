using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Specialities
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetSpecialities()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarEspecialidades";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetSpecialitieByName(string specialitieName)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarEspecialidadesPorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", specialitieName);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public void InsertSpecialitie(string specialitieName)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarEspecialidad";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", specialitieName);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateSpecialitie(string specialitieName, int id)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditarEspecialidad";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", specialitieName);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
