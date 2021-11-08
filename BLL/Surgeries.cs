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

       
        public DataTable getSurgeriesByHistoryNumber(string historyNumber)
        {
            return surgeries.getSurgeriesByHistoryNumber(historyNumber);
        }

        public DataTable getSurgeriesByDates(DateTime firstDate, DateTime secondDate)
        {
            return surgeries.getSurgeriesByDates(firstDate,secondDate);
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
            return surgeries.getSurgeriesByQuiByDates(firstDate, secondDate,quiNumber);
        }
        public DataTable getDailyDiff(DateTime date)
        {
            return surgeries.getDailyDiff(date);
        }
        public DataTable getDailySurgeries()
        {
            return surgeries.GetDailySurgeries();
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


        public string reSchedule(int idSurgerie, int idRoom, DateTime date)
        {

            try
            {
                surgeries.reScheduleSurgerie(idSurgerie, idRoom, date);
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
                  int userId,
            string surgeryType,
            DateTime surgeryDate,
            int opRoomId,
            int programationId,
            string relevance,
            string interventionDetail,
            string surgeryTime,
            string time, List<ClassDtoAssistants> assistantsList, List<ClassDtoDoctors> doctorsList)
        {
            string response = "";
            DataTable infoSurgeries = surgeries.getSurgeriesByHour(surgeryDate, surgeryTime, opRoomId);
            if (infoSurgeries.Rows.Count < 1)
            {
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
                response = surgeries.sp_assignSurgeryBasic(
                    userId,
                    surgeryType,
                    surgeryDate.Date,
                    opRoomId,
                    programationId,
                    relevance,
                    interventionDetail,
                    surgeryTime,
                    dataAssistants,
                    dataDoctors
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
           int anesthetistId,
           string relevance,
           string interventionDetail,
           List<ClassDtoAssistants> assistantsList,
           List<ClassDtoDoctors> doctorsList)
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
                anesthetistId,
                relevance,
                interventionDetail,
                surgeryTime,
                dataAssistants,
                dataDoctors
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
            int anesthetistId,
            string relevance,
            string interventionDetail,
            List<ClassDtoAssistants> assistantsList,
            List<ClassDtoDoctors> doctorsList)
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
                anesthetistId,
                relevance,
                interventionDetail,
                surgeryTime,
                dataAssistants,
                dataDoctors
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
            int anesthetistId,
            string relevance, 
            string interventionDetail, 
            List<ClassDtoAssistants> assistantsList, 
            List<ClassDtoDoctors> doctorsList)
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
                    anesthetistId,
                    relevance,
                    interventionDetail,
                    surgeryTime,
                    dataAssistants,
                    dataDoctors
                    );

            return response;

        }
        public string assignSurgery(int userId, string anesthesiaType, string surgeryType, DateTime surgeryDate,string surgeryTime, int opRoomId, 
            int anesthetistId, int programationId,string relevance,string interventionDetail,string time,List<ClassDtoAssistants> assistantsList,List<ClassDtoDoctors> doctorsList)
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
                DataTable dataDoctors = new DataTable() { Columns = { "doctorId" } };
                foreach (ClassDtoDoctors item in doctorsList)
                {
                    dataDoctors.Rows.Add(item.DoctorId);
                }
                response = surgeries.AssignSurgery(
                    userId,
                    anesthesiaType,
                    surgeryType,
                    surgeryDate.Date,
                    opRoomId,
                    anesthetistId,
                    programationId,
                    relevance,
                    interventionDetail,
                    surgeryTime,
                    dataAssistants,
                    dataDoctors
                    );
            }
            else
            {
                response = "Ya se encuentra asignada una intervención a las: " + time + " en el quirófano: " + opRoomId;

            }

            return response;
            
        }
    }
}
