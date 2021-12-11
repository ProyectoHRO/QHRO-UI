using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data; 
namespace BLL
{
    public class Surgeries
    {
        private Surgery surgeries;
        public Surgeries()
        {
            surgeries = new Surgery();
        }

        public DataTable GetEmergencySurgeries()
        {
            return surgeries.GetEmergencySurgeries();
        }
        public DataTable getDailyReport(DateTime date)
        {
            return surgeries.getDailyReport(date);
        }
        public DataTable ObtenerDoctoresAsignados(int surgerieId)
        {
            return surgeries.obtenerDoctoresAsignados(surgerieId);
        }

        public DataTable getSurgeriesByHistoryNumber(string historyNumber)
        {
            return surgeries.getSurgeriesByHistoryNumber(historyNumber);
        }

        public DataTable getSurgeriesById(int idSurgerie)
        {
            return surgeries.GetSurgeriesById(idSurgerie);
        }

        public DataTable getSurgeriesByDates(DateTime firstDate, DateTime secondDate)
        {
            return surgeries.getSurgeriesByDates(firstDate, secondDate);
        }
        public DataTable getSurgeriesByServiceByDates(DateTime firstDate, DateTime secondDate, string serviceName)
        {
            return surgeries.getSurgeriesByServiceByDates(firstDate, secondDate, serviceName);
        }

        public DataTable getEmercencySurgeriesByDates(DateTime firstDate, DateTime secondDate)
        {
            return surgeries.GetEmercencySurgeriesByDates(firstDate, secondDate);
        }

        public DataTable getSurgeriesByAnesthesiaByDates(DateTime firstDate, DateTime secondDate, string anesthesia)
        {
            return surgeries.GetSurgeriesByAnesthesiaByDates(firstDate, secondDate, anesthesia);
        }


        public DataTable getSurgeriesByQuiByDates(DateTime firstDate, DateTime secondDate, string quiNumber)
        {
            return surgeries.getSurgeriesByQuiByDates(firstDate, secondDate, quiNumber);
        }
        public DataTable getDailyDiff(DateTime date)
        {
            return surgeries.getDailyDiff(date);
        }
        public DataTable getDailySurgeries(string date)
        {
            return surgeries.GetDailySurgeries(date);
        }

        public DataTable getDialySurgeriesByOperatingRoom(int id)
        {
            return surgeries.GetDailySurgeriesByRoom(id);
        }

        public DataTable getDoctorsByIdSurgerie(int id)
        {
            return surgeries.getDoctorsBySurgeries(id);
        }
        public DataTable getAssistantsBySurgerie(int id)
        {
            return surgeries.getAssistantsBySurgerie(id);
        }

        public DataTable getAnesthetistBySurgerie(int id)
        {
            return surgeries.getAnesthetistBySurgerie(id);
        }

        public DataTable getAnesthetistNameBySurgerie(int id)
        {
            return surgeries.getAnesthetistNameBySurgerie(id);
        }

        public string reSchedule(int idSurgerie, int idRoom, DateTime date, string time)
        {

            try
            {
                surgeries.reScheduleSurgerie(idSurgerie, idRoom, date, time);
                return "Cirugia reprogramada con exito";
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }

        public string diffSurgerie(int idSurgerie, string reason)
        {

            try
            {
                surgeries.diffSurgerie(idSurgerie, reason);
                return "Cirugia diferida con exito";
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }
        public string finishSurgerie(int idSurgerie)
        {
            return surgeries.finishSurgerie(idSurgerie);
        }

        public string assignSurgeryBasic(
             int userId, string anesthesiaType, string surgeryType, DateTime surgeryDate, string surgeryTime, int opRoomId
       , int programationId, string relevance, string interventionDetail, string time,
       List<ClassDTOAnesthethist> anesList, int surgerieId)
        {
            string response = "";
            DataTable infoSurgeries = surgeries.getSurgeriesByHour(surgeryDate, surgeryTime, opRoomId);
            if (infoSurgeries.Rows.Count < 1)
            {
                DataTable dataAnes = new DataTable() { Columns = { "anesthetistId" } };
                foreach (ClassDTOAnesthethist item in anesList)
                {
                    dataAnes.Rows.Add(item.IdAnesthetist);
                }
                response = surgeries.sp_assignSurgeryBasic(
                    userId,
                    anesthesiaType,
                    surgeryType,
                    surgeryDate.Date,
                    opRoomId,
                    programationId,
                    relevance,
                    interventionDetail,
                    surgeryTime,
                    dataAnes,
                    surgerieId
                    );
            }
            else
            {
                response = "Ya se encuentra asignada una intervención a las: " + time + " en el quirófano: " + opRoomId;

            }

            return response;


        }
        public string assignSurgeryAnesthetist(
                  int userId,
         string anesthesiaType,
         int anesthetistId,
         int programationId)
        {
            string response = "";

            response = surgeries.AssignSurgeryAnesthetist(
                userId,
                anesthesiaType,
                anesthetistId,
                programationId
                );


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
                string surgeryTime,
                int opRoomId,
           string relevance,
           string interventionDetail,
           List<ClassDtoAssistants> assistantsList,
           List<ClassDtoDoctors> doctorsList,
           List<ClassDTOAnesthethist> anesList)
        {
            string response = "";

            DataTable dataAssistants = new DataTable() { Columns = { "assistantId" } };
            foreach (ClassDtoAssistants item in assistantsList)
            {
                dataAssistants.Rows.Add(item.AssistandId);
            }
            DataTable dataDoctors = new DataTable() { Columns = { "doctorId" } };
            foreach (ClassDtoDoctors item in doctorsList)
            {
                dataDoctors.Rows.Add(item.DoctorId);
            }
            DataTable dataAnes = new DataTable() { Columns = { "anesthetistId" } };
            foreach (ClassDTOAnesthethist item in anesList)
            {
                dataAnes.Rows.Add(item.IdAnesthetist);
            }
            response = surgeries.EmergencyBasic(
                pacientId,
                serviceId,
                surgeryId,
                userId,
                finalHour,
                finalDate,
                anesthesiaType,
                surgeryType,
                surgeryDate,
                opRoomId,
                relevance,
                interventionDetail,
                surgeryTime,
                dataAssistants,
                dataDoctors,
                dataAnes
                );

            return response;

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
                 string surgeryTime,
                 int opRoomId,
            string relevance,
            string interventionDetail,
            List<ClassDtoAssistants> assistantsList,
            List<ClassDtoDoctors> doctorsList,
            List<ClassDTOAnesthethist> anesList)
        {
            string response = "";

            DataTable dataAssistants = new DataTable() { Columns = { "assistantId" } };
            foreach (ClassDtoAssistants item in assistantsList)
            {
                dataAssistants.Rows.Add(item.AssistandId);
            }
            DataTable dataDoctors = new DataTable() { Columns = { "doctorId" } };
            foreach (ClassDtoDoctors item in doctorsList)
            {
                dataDoctors.Rows.Add(item.DoctorId);
            }
            DataTable dataAnes = new DataTable() { Columns = { "anesthetistId" } };
            foreach (ClassDTOAnesthethist item in anesList)
            {
                dataAnes.Rows.Add(item.IdAnesthetist);
            }
            response = surgeries.EmergencyAndPatientNew(
                firstName,
                secondName,
                firstSurname,
                secondSurname,
                age,
                gender,
                serviceId,
                surgeryId,
                userId,
                finalHour,
                finalDate,
                anesthesiaType,
                surgeryType,
                surgeryDate,
                opRoomId,
                relevance,
                interventionDetail,
                surgeryTime,
                dataAssistants,
                dataDoctors,
                dataAnes
                );

            return response;

        }
        public string EmergencyBasicAndPatient(
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
                 string surgeryTime, 
                 int opRoomId,
            string relevance, 
            string interventionDetail, 
            List<ClassDtoAssistants> assistantsList, 
            List<ClassDtoDoctors> doctorsList,
            List<ClassDTOAnesthethist> anesList)
        {
            string response = "";
            
                DataTable dataAssistants = new DataTable() { Columns = { "assistantId" } };
                foreach (ClassDtoAssistants item in assistantsList)
                {
                    dataAssistants.Rows.Add(item.AssistandId);
                }
                DataTable dataDoctors = new DataTable() { Columns = { "doctorId" } };
                foreach (ClassDtoDoctors item in doctorsList)
                {
                    dataDoctors.Rows.Add(item.DoctorId);
                }
                DataTable dataAnes = new DataTable() { Columns = { "anesthetistId" } };
                foreach (ClassDTOAnesthethist item in anesList)
                {
                    dataAnes.Rows.Add(item.IdAnesthetist);
                }
            response = surgeries.EmergencyAndPatient(
                    historyNumber,
                    firstName,
                    secondName,
                    firstSurname,
                    secondSurname,
                    age,
                    gender,
                    serviceId,
                    surgeryId,
                    userId,
                    finalHour,
                    finalDate,
                    anesthesiaType,
                    surgeryType,
                    surgeryDate,
                    opRoomId,
                    relevance,
                    interventionDetail,
                    surgeryTime,
                    dataAssistants,
                    dataDoctors,
                    dataAnes
                    );

            return response;

        }

        public string AssignAssist(
                int surgeryId,
            List<ClassDtoAssistants> assistantsList)
        {
            string response = "";

            DataTable dataAssistants = new DataTable() { Columns = { "assistantId" } };
            foreach (ClassDtoAssistants item in assistantsList)
            {
                dataAssistants.Rows.Add(item.AssistandId);
            }
            
            response = surgeries.AssignAssists(
                    surgeryId,
                    dataAssistants
                    );

            return response;

        }

        public string assignSurgery(int userId, string anesthesiaType, string surgeryType, DateTime surgeryDate,string surgeryTime, int opRoomId
            , int programationId,string relevance,string interventionDetail,string time,List<ClassDtoAssistants> assistantsList,
            List<ClassDTOAnesthethist> anesList,int surgerieId)
        {
            string response = "";
            DataTable infoSurgeries = surgeries.getSurgeriesByHour(surgeryDate, surgeryTime, opRoomId);
            if (infoSurgeries.Rows.Count<1)
            {
                DataTable dataAssistants = new DataTable() { Columns = { "assistantId" } };
                foreach (ClassDtoAssistants item in assistantsList)
                {
                    dataAssistants.Rows.Add(item.AssistandId);
                }
                DataTable dataAnes = new DataTable() { Columns = { "anesthetistId" } };
                foreach (ClassDTOAnesthethist item in anesList)
                {
                    dataAnes.Rows.Add(item.IdAnesthetist);
                }
                response = surgeries.AssignSurgery(
                    userId,
                    anesthesiaType,
                    surgeryType,
                    surgeryDate.Date,
                    opRoomId,
                    programationId,
                    relevance,
                    interventionDetail,
                    surgeryTime,
                    dataAssistants,
                    dataAnes,
                    surgerieId
                    );
            }
            else
            {
                response = "Ya se encuentra asignada una intervención a las: " + time + " en el quirófano: " + opRoomId;

            }

            return response;
            
        }


        public string updateSurgerieData(int surgerieId, string anesthesiaType, string Proce)
        {
            try
            {
                surgeries.UpdateSurgerieData(surgerieId, anesthesiaType, Proce);
                return "DATOS ACTUALIZADOS";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }

    }
}
