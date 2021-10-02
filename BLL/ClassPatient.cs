using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ClassPatient
    {
        private Patient patient;

        public ClassPatient()
        {
            patient = new Patient();
        }

        public DataTable listPatients()
        {
            return patient.GetPatients();
        }

        public DataTable getPatientsByHistoryNumber(string historyNumber)
        {
            return patient.GetPatientByHistoryNumber(historyNumber);
        }

        public string newPatient(string historyNumber, string firstName, string secondName,
        string thirdName, string firstSurname, string secondSurname, short age,
        string gender)
        {
            try
            {
                patient.InsertPatient(historyNumber, firstName, secondName, thirdName,
                    firstSurname, secondSurname, age, gender);
                return "Nuevo paciente agregado";
            }
            catch (Exception error)
            {
                return "ERROR" + error.Message;
            }
        }

        public string editPatient(string historyNumber, string firstName, string secondName,
        string thirdName, string firstSurname, string secondSurname, short age,
        string gender, bool status, int idPatient)
        {
            try
            {
                patient.UpdatePatient(historyNumber, firstName, secondName, thirdName,
                    firstSurname, secondSurname, age, gender, status, idPatient);
                return "Se actualizaron los datos del paciente";
            }
            catch (Exception error)
            {

                return "ERROR" + error.Message;
            }
        }

    }
}
