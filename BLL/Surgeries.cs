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

        public DataTable getDoctorsByIdSurgerie(int id)
        {
            return surgeries.getDoctorsBySurgeries(id);
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
