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

        public DataTable getDailyDiff(DateTime date)
        {
            return surgeries.getDailyDiff(date);
        }
        public DataTable getDailySurgeries()
        {
            return surgeries.GetDailySurgeries();
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

        public string assignSurgery(string anesthesiaType, string surgeryType, DateTime surgeryDate, int opRoomId, 
            int anesthetistId, int programationId,string relevance,string interventionDetail,List<ClassDtoAssistants> assistantsList,List<ClassDtoDoctors> doctorsList)
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
                response= surgeries.AssignSurgery(
                    anesthesiaType,
                    surgeryType,
                    surgeryDate,
                    opRoomId,
                    anesthetistId,
                    programationId,
                    relevance,
                    interventionDetail,
                    dataAssistants,
                    dataDoctors
                    );
                return response;
            
        }
    }
}
