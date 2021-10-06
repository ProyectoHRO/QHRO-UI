using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Anesthetist
    {

        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetAnesthetist()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarAnestesista";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetAnesthetistByCui(string dpi)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarAnestesistaPorDpi";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi", dpi);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetAnesthetistByName(string name)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "BuscarAnestesistaPorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", name);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public void InsertAnesthetist(
            string anesthetistDpi,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            string number,
            string email
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarAnestesista";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi_anestesista", anesthetistDpi);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@numero", number);
            command.Parameters.AddWithValue("@correo", email);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateAnesthetist(
            string anesthetistDpi,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            string number,
            string email,
            bool status,
            int id
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditarAnestesista";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi_anestesista", anesthetistDpi);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@numero", number);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@estado", status);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
