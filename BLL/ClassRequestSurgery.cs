using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class ClassRequestSurgery
    {
        private Surgery surgeries;
        public ClassRequestSurgery()
        {
            surgeries = new Surgery();
        
        }

        public DataTable getRequestedSurgeries()
        {
            return surgeries.GetRequestedSurgeries();
        }
        public string makeSurgeryRequest(string interventionDetail, int patientId, int serviceId)
        {
            string response = "";
            surgeries.requestSurgery( interventionDetail,patientId,serviceId,ref response);
            return response;
        }
        public string makeSurgeryRequestAndPatient(string interventionDetail, int serviceId,string historyNumber, string firstName, string secondName, string thirdName, string firstSurname
            ,string secondSurname, short age, string gender)
        {
            string response = "";
            surgeries.requestSurgeryAndPatient(interventionDetail, serviceId,historyNumber,firstName,secondName,thirdName,firstSurname,secondSurname,age,gender, ref response);
            return response;
        }
    }
}
