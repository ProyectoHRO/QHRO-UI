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


        public string reSchedule(int idSurgerie, DateTime date)
        {

            try
            {
                surgeries.reScheduleSurgerie(idSurgerie, date);
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
            DataTable infoSurgeries = surgeries.getSurgeriesByHour(surgeryDate, time, opRoomId);
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
        public string assignSurgery(int userId, string anesthesiaType, string surgeryType, DateTime surgeryDate,string surgeryTime, int opRoomId, 
            int anesthetistId, int programationId,string relevance,string interventionDetail,string time,List<ClassDtoAssistants> assistantsList,List<ClassDtoDoctors> doctorsList)
        {
            string response = "";
            DataTable infoSurgeries = surgeries.getSurgeriesByHour(surgeryDate, time, opRoomId);
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
