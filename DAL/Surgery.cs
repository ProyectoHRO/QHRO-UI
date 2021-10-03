using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Surgery
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetRequestedSurgeries()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarSolicitudes";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public void AssignSurgery(
            string anesthesiaType,
            string surgeryType,
            DateTime surgeryDate,
            int opRoomId,
            int doctorId,
            int anesthetistId,
            int programationId,
            Object detail,
            ref string message
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_asignarCirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@anesthesiaType", anesthesiaType);
            command.Parameters.AddWithValue("@surgeryType", surgeryType);
            command.Parameters.AddWithValue("@surgeryDate", surgeryDate);
            command.Parameters.AddWithValue("@opRoomId", opRoomId);
            command.Parameters.AddWithValue("@doctorId", doctorId);
            command.Parameters.AddWithValue("@anesthetistId", anesthetistId);
            command.Parameters.AddWithValue("@programationId", programationId);
            command.Parameters.AddWithValue("@detalle", detail);
            command.Parameters.AddWithValue("@mensaje", message);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }


        public void requestSurgery(
            string interventionDetail,
            int patientId,
            int serviceId,
            ref string response)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_solicitar_cirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@diagnostico", interventionDetail);
            command.Parameters.AddWithValue("@idpaciente", patientId);
            command.Parameters.AddWithValue("@idservicio", serviceId);
            command.Parameters.AddWithValue("@mensaje", response);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void requestSurgeryAndPatient(
            string interventionDetail,
            int serviceId,
            string historyNumber,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            short age,
            string gender,
            ref string response)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_solicitar_cirugia_paciente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@diagnostico", interventionDetail);
            command.Parameters.AddWithValue("@idservicio", serviceId);
            command.Parameters.AddWithValue("@no_historia", historyNumber);
            command.Parameters.AddWithValue("@primerNombre", firstName);
            command.Parameters.AddWithValue("@segundoNombre", secondName);
            command.Parameters.AddWithValue("@tecerNombre", thirdName);
            command.Parameters.AddWithValue("@primerApellido", firstSurname);
            command.Parameters.AddWithValue("@segundoApellido", secondSurname);
            command.Parameters.AddWithValue("@edad", age);
            command.Parameters.AddWithValue("@genero", gender);
            command.Parameters.AddWithValue("@mensaje", response);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

    }
}
