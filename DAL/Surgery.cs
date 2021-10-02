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
            command.Parameters.AddWithValue("@message", message);
            command.ExecuteScalar();
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
            command.CommandText = "sp_requestSurgery";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@anesthesiaType", interventionDetail);
            command.Parameters.AddWithValue("@surgeryType", patientId);
            command.Parameters.AddWithValue("@surgeryDate", serviceId);
            command.Parameters.AddWithValue("@message", response);
            command.ExecuteScalar();
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
            command.CommandText = "sp_requestSurgery";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@anesthesiaType", interventionDetail);
            command.Parameters.AddWithValue("@surgeryType", historyNumber);
            command.Parameters.AddWithValue("@surgeryDate", serviceId);
            command.Parameters.AddWithValue("@surgeryDate", firstName);
            command.Parameters.AddWithValue("@surgeryDate", secondName);
            command.Parameters.AddWithValue("@surgeryDate", thirdName);
            command.Parameters.AddWithValue("@surgeryDate", firstSurname);
            command.Parameters.AddWithValue("@surgeryDate", secondSurname);
            command.Parameters.AddWithValue("@surgeryDate", age);
            command.Parameters.AddWithValue("@surgeryDate", gender);
            command.Parameters.AddWithValue("@message", response);
            command.ExecuteScalar();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

    }
}
