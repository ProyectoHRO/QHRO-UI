using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Doctor
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetDoctors()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarDoctor";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetDoctorByDpi(string dpi)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarDoctorPorDpi";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi", dpi);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public void InsertDoctor(
            string doctorDpi,
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
            command.CommandText = "InsertarDoctor";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi_doctor", doctorDpi);
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

        public void UpdateDoctor(
            string doctorDpi,
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
            command.CommandText = "EditarDoctor";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi_doctor", doctorDpi);
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
