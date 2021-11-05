using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class ClassPHro
    {
        private ClassPatientHro patientHro;

        public ClassPHro()
        {
            patientHro = new ClassPatientHro();
        }

        public DataTable getPatientsByHistoryNumber(string historyNumber)
        {
            return patientHro.GetPatientByHistoryNumberHro(historyNumber);
        }
    }
}
