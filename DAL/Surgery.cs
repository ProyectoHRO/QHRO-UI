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

        public DataTable GetDailySurgeries()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "VerCirugiasDiarias";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }


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
        
        public DataTable getDoctorsBySurgeries(int surgerieId)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerDoctoresPorCirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable reScheduleSurgerie(int surgerieId, DateTime date)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ReprogramarCirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha", date);
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable diffSurgerie(int surgerieId, string reason)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "DiferirCirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@motivo", reason);
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable getAssistantsBySurgerie(int surgerieId)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerAyudantesPorCirugias";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable getDailyReport(DateTime surgeryDate)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionesReporte";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha", surgeryDate);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable getDailyDiff(DateTime surgeryDate)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionesDiferidas";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha", surgeryDate);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public string AssignSurgery(
            string anesthesiaType,
            string surgeryType,
            DateTime surgeryDate,
            int opRoomId,
            int anesthetistId,
            int programationId,
            string relevance,
            string interventionDetail,
            DataTable assistantDetail,
            DataTable doctorDetail
            )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_assignSurgery";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tipo_anestesia", anesthesiaType);
            command.Parameters.AddWithValue("@tipo_cirugia", surgeryType);
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            command.Parameters.AddWithValue("@idanestesia", anesthetistId);
            command.Parameters.AddWithValue("@id_programaciones", programationId);
            command.Parameters.AddWithValue("@relevancia", relevance);
            command.Parameters.AddWithValue("@detalleIntervencion", interventionDetail);
            command.Parameters.AddWithValue("@detalleAsistente", assistantDetail);
            command.Parameters.AddWithValue("@detalleDoctor", doctorDetail);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar,250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }


        public string requestSurgery(
            string interventionDetail,
            int patientId,
            int serviceId)
        {
            string response="";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_solicitar_cirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@diagnostico", interventionDetail);
            command.Parameters.AddWithValue("@idpaciente", patientId);
            command.Parameters.AddWithValue("@idservicio", serviceId);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }

        public string requestSurgeryAndPatient(
            string interventionDetail,
            int serviceId,
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
            string response = "";
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
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }

    }
}
