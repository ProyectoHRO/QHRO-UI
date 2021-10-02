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
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@numero", phone);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@idType", idType);
            command.Parameters.AddWithValue("@dpi", cui);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateAssistant(
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
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@numero", phone);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@idType", idType);
            command.Parameters.AddWithValue("@dpi", cui);
            command.Parameters.AddWithValue("@estado", status);
            command.Parameters.AddWithValue("@id", idAssistant);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
