using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetSurgeryTableAdapters;
using System.Data; 
namespace BLL
{
    public class Surgeries
    {
        private cirugiasTableAdapter surgeries;
        public Surgeries()
        {
            surgeries = new cirugiasTableAdapter();
        }

        public string assignSurgery(string anesthesiaType, string surgeryType, DateTime surgeryDate, int opRoomId, int doctorId, 
            int anesthetistId, int programationId,List<ClassDtoAssistants> assistantsList)
        {
            string response = "";
            DataTable data = new DataTable() { Columns = { "assistantId" } };
            foreach (ClassDtoAssistants item in assistantsList)
            {
                data.Rows.Add(item.AssistandId);
            }
            surgeries.sp_assignSurgeryTransactional(anesthesiaType,surgeryType,surgeryDate,opRoomId,doctorId,anesthetistId,programationId,data,ref response);
            return response;
        }
    }
}
