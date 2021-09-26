using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetPatientTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassPatient
    {
        private pacientesTableAdapter PATIENT;

        public ClassPatient()
        {
            PATIENT = new pacientesTableAdapter();
        }

        public DataTable listPatients()
        {
            return PATIENT.GetDataPatients();
        }

        public DataTable getPatientsByHistoryNumber(string historyNumber)
        {
            return PATIENT.GetDataByHistoryNumber(historyNumber);
        }

        public string newPatient(string historyNumber, string firstName, string secondName,
        string thirdName, string firstSurname, string secondSurname, short age,
        string gender)
        {
            try
            {
                PATIENT.InsertQueryNewPatient(historyNumber, firstName, secondName, thirdName,
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
                PATIENT.UpdateQueryEditPatient(historyNumber, firstName, secondName, thirdName,
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
