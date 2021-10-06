using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Patient
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();


        public DataTable GetDiagnosis(int id)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarDiagnosticos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idpaciente", id);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetPatients()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarPacientes";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetPatientByHistoryNumber(string history_number)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarPacientePorNoHistoria";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@no_historia", history_number);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetPatientByName(string name)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "BuscarPacientePorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", name);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        
        public DataTable GetDiagnosisByPatient(int id)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarDiagnosticos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idpaciente", id);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public void InsertPatient(
            string historyNumber,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            short age,
            string gender
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarPaciente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@no_historia", historyNumber);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@edad", age);
            command.Parameters.AddWithValue("@genero", gender);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdatePatient(
            string historyNumber,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            short age,
            string gender,
             bool status,
             int idPatient
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditarPaciente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@no_historia", historyNumber);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@edad", age);
            command.Parameters.AddWithValue("@genero", gender);
            command.Parameters.AddWithValue("@estado", status);
            command.Parameters.AddWithValue("@id", idPatient);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
