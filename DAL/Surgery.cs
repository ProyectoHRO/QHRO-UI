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

        public DataTable GetDailySurgeries(string date)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "VerCirugiasDiarias";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha", date);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        
        public DataTable GetUnfinishedSurgeries()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarCirugiasSinFinalizar";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public void updateSurgerieAnesthetist(
            int surgerieId,
            int anesthetistId,
            string anesType
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "ActualizarCirugiaAnes";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            command.Parameters.AddWithValue("@idanestesia", anesthetistId);
            command.Parameters.AddWithValue("@tipo_anestesia", anesType);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
        

          public string EmergencyAndPatientNew(
        string firstName,
        string secondName,
        string firstSurname,
        string secondSurname,
        short age,
        string gender,
        int serviceId,
        int surgeryId,
        int userId,
        string finalHour,
        DateTime finalDate,
        string anesthesiaType,
        string surgeryType,
        DateTime surgeryDate,
        int opRoomId,
        int anesthetistId,
        string relevance,
        string interventionDetail,
        string time,
        DataTable assistantDetail,
        DataTable doctorDetail
       )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "AssignEmergencyAndPatientNew";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@edad", age);
            command.Parameters.AddWithValue("@genero", gender);

            command.Parameters.AddWithValue("@idservicio", serviceId);
            command.Parameters.AddWithValue("@idcirugia", surgeryId);
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@hora_final", finalHour);
            command.Parameters.AddWithValue("@fecha_final", finalDate);
            command.Parameters.AddWithValue("@tipo_anestesia", anesthesiaType);
            command.Parameters.AddWithValue("@tipo_cirugia", surgeryType);
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            command.Parameters.AddWithValue("@idanestesia", anesthetistId);
            command.Parameters.AddWithValue("@relevancia", relevance);
            command.Parameters.AddWithValue("@detalleIntervencion", interventionDetail);
            command.Parameters.AddWithValue("@hora", time);
            command.Parameters.AddWithValue("@detalleAsistente", assistantDetail);
            command.Parameters.AddWithValue("@detalleDoctor", doctorDetail);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }
        public string EmergencyAndPatient(
        string historyNumber,
        string firstName,
        string secondName,
        string firstSurname,
        string secondSurname,
        short age,
        string gender,
        int serviceId,
        int surgeryId,
        int userId,
        string finalHour,
        DateTime finalDate,
        string anesthesiaType,
        string surgeryType,
        DateTime surgeryDate,
        int opRoomId,
        int anesthetistId,
        string relevance,
        string interventionDetail,
        string time,
        DataTable assistantDetail,
        DataTable doctorDetail
       )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "AssignEmergencyAndPatient";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@no_historia", historyNumber);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@edad", age);
            command.Parameters.AddWithValue("@genero", gender);

            command.Parameters.AddWithValue("@idservicio", serviceId);
            command.Parameters.AddWithValue("@idcirugia", surgeryId);
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@hora_final", finalHour);
            command.Parameters.AddWithValue("@fecha_final", finalDate);
            command.Parameters.AddWithValue("@tipo_anestesia", anesthesiaType);
            command.Parameters.AddWithValue("@tipo_cirugia", surgeryType);
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            command.Parameters.AddWithValue("@idanestesia", anesthetistId);
            command.Parameters.AddWithValue("@relevancia", relevance);
            command.Parameters.AddWithValue("@detalleIntervencion", interventionDetail);
            command.Parameters.AddWithValue("@hora", time);
            command.Parameters.AddWithValue("@detalleAsistente", assistantDetail);
            command.Parameters.AddWithValue("@detalleDoctor", doctorDetail);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }

        public string EmergencyBasic(
            int pacientId,
            int serviceId,
            int surgeryId,
            int userId,
            string finalHour,
            DateTime finalDate,
            string anesthesiaType,
            string surgeryType,
            DateTime surgeryDate,
            int opRoomId,
            int anesthetistId,
            string relevance,
            string interventionDetail,
            string time,
            DataTable assistantDetail,
            DataTable doctorDetail
           )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "AssignEmergencyBase";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idpaciente", pacientId);
            command.Parameters.AddWithValue("@idservicio", serviceId);
            command.Parameters.AddWithValue("@idcirugia", surgeryId); 
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@hora_final", finalHour);
            command.Parameters.AddWithValue("@fecha_final", finalDate);
            command.Parameters.AddWithValue("@tipo_anestesia", anesthesiaType);
            command.Parameters.AddWithValue("@tipo_cirugia", surgeryType);
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            command.Parameters.AddWithValue("@idanestesia", anesthetistId);
            command.Parameters.AddWithValue("@relevancia", relevance);
            command.Parameters.AddWithValue("@detalleIntervencion", interventionDetail);
            command.Parameters.AddWithValue("@hora", time);
            command.Parameters.AddWithValue("@detalleAsistente", assistantDetail);
            command.Parameters.AddWithValue("@detalleDoctor", doctorDetail);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }

        public DataTable GetSurgeriesWithoutAnesthetist()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarCirugiasSinAnestecia";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetDailySurgeriesByRoom(int roomNumber)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "VerCirugiasDiariasPorQuirofano";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numberRoom", roomNumber);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
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

        public DataTable GetEmergencySurgeries()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerCirugiasDeEmergencia";
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
        public DataTable getInfoAnesthetist(int surgerieId)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerInfoAnestesista";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable getInfoUnfinishiedSurgerie(int surgerieId)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerInfoCirugiaSinFinalizar";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable getSurgeriesByHour(DateTime surgeryDate, string hour, int opRoomId)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "BuscarCirugiasPorHora";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@hora", hour);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable getSurgeriesByDoctor(DateTime surgeryDate, string hour)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "BuscarCirugiasPorDoctor";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@hora", hour);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable getSurgeriesByServiceByDates(DateTime firstDate, DateTime secondDate, string serviceName)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionesPorServicioEntreDosFechas";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha1", firstDate);
            command.Parameters.AddWithValue("@fecha2 ", secondDate);
            command.Parameters.AddWithValue("@nombreServicio", serviceName);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetEmercencySurgeriesByDates(DateTime firstDate, DateTime secondDate)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionesDeEmergenciaEntreDosFechas";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha1", firstDate);
            command.Parameters.AddWithValue("@fecha2 ", secondDate);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }


        public DataTable GetSurgeriesByAnesthesiaByDates(DateTime firstDate, DateTime secondDate, string anesthesia)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionesPorAnestesiaEntreDosFechas";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha1", firstDate);
            command.Parameters.AddWithValue("@fecha2 ", secondDate);
            command.Parameters.AddWithValue("@nombreAnestesia", anesthesia);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable getSurgeriesByHistoryNumber(string historyNumber)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionPorNoHistoria";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numeroHistoria", historyNumber);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable getSurgeriesByQuiByDates(DateTime firstDate, DateTime secondDate, string quiNumber)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionesPorQuirofanoEntreDosFechas";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha1", firstDate);
            command.Parameters.AddWithValue("@fecha2 ", secondDate);
            command.Parameters.AddWithValue("@noquirofano", quiNumber);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable getSurgeriesByDates(DateTime firstDate, DateTime secondDate)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarIntervencionesEntreDosFechas";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha1", firstDate);
            command.Parameters.AddWithValue("@fecha2 ", secondDate);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetSurgeriesById(int idSurgerie)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerCirugiaPorId";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", idSurgerie);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable reScheduleSurgerie(int surgerieId, int roomId, DateTime date, string time)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ReprogramarCirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fecha", date);
            command.Parameters.AddWithValue("@hora", time);
            command.Parameters.AddWithValue("@idquirofano", roomId);
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

        public string finishSurgerie(int surgerieId)
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "FinalizarCirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
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
            command.Parameters.AddWithValue("@fecha", surgeryDate.Date);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public string AssignSurgery(
            int userId,
            string anesthesiaType,
            string surgeryType,
            DateTime surgeryDate,
            int opRoomId,
            int anesthetistId,
            int programationId,
            string relevance,
            string interventionDetail,
            string time,
            DataTable assistantDetail,
            DataTable doctorDetail
            )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_assignSurgery";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@tipo_anestesia", anesthesiaType);
            command.Parameters.AddWithValue("@tipo_cirugia", surgeryType);
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            command.Parameters.AddWithValue("@idanestesia", anesthetistId);
            command.Parameters.AddWithValue("@id_programaciones", programationId);
            command.Parameters.AddWithValue("@relevancia", relevance);
            command.Parameters.AddWithValue("@detalleIntervencion", interventionDetail);
            command.Parameters.AddWithValue("@hora", time);
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
        public void UpdateSurgerie(
           int surgerieId,
           string surgeryType,
           DateTime surgeryDate,
           int opRoomId,
           int programationId,
           string relevance,
           string interventionDetail,
           string time,
           DataTable assistantDetail,
           DataTable doctorDetail
           )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "ActualizarCirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            command.Parameters.AddWithValue("@tipo_cirugia", surgeryType);
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            command.Parameters.AddWithValue("@id_programaciones", programationId);
            command.Parameters.AddWithValue("@relevancia", relevance);
            command.Parameters.AddWithValue("@detalleIntervencion", interventionDetail);
            command.Parameters.AddWithValue("@hora", time);
            command.Parameters.AddWithValue("@detalleAsistente", assistantDetail);
            command.Parameters.AddWithValue("@detalleDoctor", doctorDetail);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
        public string AssignSurgeryAnesthetist(
         int userId,
         string anesthesiaType,
         int anesthetistId,
         int programationId
         )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_assignSurgeryAnesthethist";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@tipo_anestesia", anesthesiaType);
            command.Parameters.AddWithValue("@idanestesia", anesthetistId);
            command.Parameters.AddWithValue("@id_programaciones", programationId);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }
        

        public string sp_assignSurgeryBasic(
         int userId,
         
            string surgeryType,
            DateTime surgeryDate,
            int opRoomId,
            int programationId,
            string relevance,
            string interventionDetail,
            string time,
            DataTable assistantDetail,
            DataTable doctorDetail
         )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_assignSurgeryBasic";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@tipo_cirugia", surgeryType);
            command.Parameters.AddWithValue("@fecha_cirugia", surgeryDate);
            command.Parameters.AddWithValue("@idquirofano", opRoomId);
            command.Parameters.AddWithValue("@id_programaciones", programationId);
            command.Parameters.AddWithValue("@relevancia", relevance);
            command.Parameters.AddWithValue("@detalleIntervencion", interventionDetail);
            command.Parameters.AddWithValue("@hora", time);
            command.Parameters.AddWithValue("@detalleAsistente", assistantDetail);
            command.Parameters.AddWithValue("@detalleDoctor", doctorDetail);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }

        public string requestSurgery(
            int userId,
            string interventionDetail,
            string firstName,
            string secondName,
            string firstSurname,
            string secondSurname,
            short age,
            string gender,
            int patientId,
            int serviceId)
        {
            string response="";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_solicitar_cirugia";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@diagnostico", interventionDetail);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@edad", age);
            command.Parameters.AddWithValue("@genero", gender);
            command.Parameters.AddWithValue("@id", patientId);
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
            int userId,
            string interventionDetail,
            int serviceId,
            string historyNumber,
            string firstName,
            string secondName,
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
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@diagnostico", interventionDetail);
            command.Parameters.AddWithValue("@idservicio", serviceId);
            command.Parameters.AddWithValue("@no_historia", historyNumber);
            command.Parameters.AddWithValue("@primerNombre", firstName);
            command.Parameters.AddWithValue("@segundoNombre", secondName);
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

        public void UpdateSurgerieData(int surgerieId, string anesthesiaType, string Proce)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "ActualizarDatosPostOperatorios";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idcirugia", surgerieId);
            command.Parameters.AddWithValue("@tipo_anestesia", anesthesiaType);
            command.Parameters.AddWithValue("@procedimiento", Proce);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }

}

