using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Assistant
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetAssistants()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarAsistentes";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetTypeAssistant()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarTiposDeAsistentes";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetTypeAssistantById(int id)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarAyudantePorId";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idservicio", id);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetAssistantByName(string name)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "BuscarAyudantePorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", name);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetAssistantByDPI(string dpi)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarAsistentePorDpi";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi", dpi);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public void InsertAssistant(
            int userId,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            string email,
            string phone,
            int idType,
            string cui
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarAsistente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@dpi", cui);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@telefono", phone);
            command.Parameters.AddWithValue("@id_tipo", idType);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateAssistant(
            int userId,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            string email,
            string phone,
            bool status,
            int idType,
            string cui,
            int idAssistant
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditarAsistente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@dpi", cui);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@telefono", phone);
            command.Parameters.AddWithValue("@id_tipo", idType);
            command.Parameters.AddWithValue("@estado", status);
            command.Parameters.AddWithValue("@id", idAssistant);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
