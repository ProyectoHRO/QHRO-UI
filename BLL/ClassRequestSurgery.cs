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
        public DataTable getUnfinishedSurgeries()
        {
            return surgeries.GetUnfinishedSurgeries();
        }

        public DataTable getRequestedSurgeries()
        {
            return surgeries.ObtenerCirugiasSinLlenar();
        }

        public DataTable getInfoAnesthetist(int surgerieId)
        {
            return surgeries.getInfoAnesthetist(surgerieId);
        }
        
        public DataTable getInfoUnfinishiedSurgerie(int surgerieId)
        {
            return surgeries.getInfoUnfinishiedSurgerie(surgerieId);
        }
        public DataTable GetSurgeriesWithoutAnesthetist()
        {
            return surgeries.GetSurgeriesWithoutAnesthetist();
        }

        public string updateSurgerieAnesthetist(int surgerieId, int anesthetistId, string anesType)
        {
            try
            {
                surgeries.updateSurgerieAnesthetist(surgerieId, anesthetistId, anesType);
                return "Cirugía actualizada con éxito";
            }
            catch (Exception error)
            {
                return error.ToString();
            }
        }
        
        public string UpdateSurgerie(int surgerieId, string surgeryType, DateTime surgeryDate, string surgeryTime, int opRoomId
            , int programationId, string relevance, string interventionDetail, string time, List<ClassDtoAssistants> assistantsList, List<ClassDtoDoctors> doctorsList)
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
                   surgeries.UpdateSurgerie(
                    surgerieId,
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
                response = "Cirugía asignada con éxito";
            }
            else
            {
                response = "Ya se encuentra asignada una intervención a las: " + time + " en el quirófano: " + opRoomId;

            }

            return response;

        }

        public string makeSurgeryRequest(
            int userId,
            string interventionDetail,
            string firstName,
            string secondName,
            string firstSurname,
            string secondSurname,
            short age,
            string gender,
            int patientId,
            int serviceId,
            List<ClassDtoDoctors> doctorsList)
        {
            string response = "";
            DataTable dataDoctors = new DataTable() { Columns = { "doctorId" } };
            foreach (ClassDtoDoctors item in doctorsList)
            {
                dataDoctors.Rows.Add(item.DoctorId);
            }
            response =surgeries.requestSurgery( 
                userId,
                interventionDetail,
                firstName,
                secondName,
                firstSurname,
                secondSurname,
                age,
                gender,
                patientId,
                serviceId,
                dataDoctors);
            return response;
        }
        public string makeSurgeryRequestAndPatient(int userId,string interventionDetail, int serviceId,string historyNumber, string firstName, string secondName, string firstSurname
            ,string secondSurname, short age, string gender)
        {
            string response = "";
            response=surgeries.requestSurgeryAndPatient(userId,interventionDetail, serviceId,historyNumber,firstName,secondName,firstSurname,secondSurname,age,gender);
            return response;
        }

        public string makeSurgeryRequestAndPatientWithDoctors(int userId, string interventionDetail, int serviceId, string historyNumber, string firstName, string secondName, string firstSurname
           , string secondSurname, short age, string gender, List<ClassDtoDoctors> doctorsList)
        {
            string response = "";
            DataTable dataDoctors = new DataTable() { Columns = { "doctorId" } };
            foreach (ClassDtoDoctors item in doctorsList)
            {
                dataDoctors.Rows.Add(item.DoctorId);
            }
            response = surgeries.requestSurgeryAndPatientWithDoctors(userId, 
                interventionDetail, serviceId, historyNumber, firstName, secondName, firstSurname, secondSurname, age, gender, dataDoctors);
            return response;
        }
    }
}
