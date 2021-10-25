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
        public string makeSurgeryRequest(int userId,string interventionDetail, int patientId, int serviceId)
        {
            string response = "";
            response=surgeries.requestSurgery( userId,interventionDetail,patientId,serviceId);
            return response;
        }
        public string makeSurgeryRequestAndPatient(int userId,string interventionDetail, int serviceId,string historyNumber, string firstName, string secondName, string thirdName, string firstSurname
            ,string secondSurname, short age, string gender)
        {
            string response = "";
            response=surgeries.requestSurgeryAndPatient(userId,interventionDetail, serviceId,historyNumber,firstName,secondName,thirdName,firstSurname,secondSurname,age,gender);
            return response;
        }
    }
}
