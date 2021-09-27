using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetSurgeryTableAdapters;
using System.Data;
namespace BLL
{
    public class ClassRequestSurgery
    {
        private programacionesTableAdapter surgeryRequests;
        private requestSurgeryViewTableAdapter requestedSurgeries;
        public ClassRequestSurgery()
        {
            surgeryRequests = new programacionesTableAdapter();
            requestedSurgeries = new requestSurgeryViewTableAdapter();
        }

        public DataTable getRequestedSurgeries()
        {
            return requestedSurgeries.GetDataRequestedSurgeries();
        }
        public string makeSurgeryRequest(string interventionDetail, int patientId, int serviceId)
        {
            string response = "";
            surgeryRequests.sp_newRequestTransact( interventionDetail,patientId,serviceId,ref response);
            return response;
        }
        public string makeSurgeryRequestAndPatient(string interventionDetail, int serviceId,string historyNumber, string firstName, string secondName, string thirdName, string firstSurname
            ,string secondSurname, short age, string gender)
        {
            string response = "";
            surgeryRequests.sp_newRequestAndPatientTransactional(interventionDetail, serviceId,historyNumber,firstName,secondName,thirdName,firstSurname,secondSurname,age,gender, ref response);
            return response;
        }
    }
}
