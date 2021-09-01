using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetAnesthetistTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassAnesthetist
    {
        private anestesiaTableAdapter ANESTHETIST;

        public ClassAnesthetist()
        {
            ANESTHETIST = new anestesiaTableAdapter();
        }

        public DataTable listAnesthetist()
        {
            return ANESTHETIST.GetDataAnesthetist();
        }

        public string newAnesthetist(string dpi, string firstName, string secondName,
            string thirdName, string firstSurname, string secondSurname, string phoneNumber, string email, bool status)
        {
            try
            {
                ANESTHETIST.InsertQueryNewAnesthetist(dpi, firstName, secondName, thirdName,
                    firstSurname, secondSurname, phoneNumber, email, status);
                return "Nuevo anestesista agregado";
            }
            catch (Exception error)
            {
                return "ERROR" + error.Message;
            }
        }

        public string editAnesthetist(string dpi, string firstName, string secondName,
            string thirdName, string firstSurname, string secondSurname, string phoneNumber, string email,
            bool status, int idPatient)
        {
            try
            {
                ANESTHETIST.UpdateQueryEditAnesthetist(dpi, firstName, secondName, thirdName, firstSurname, 
                    secondSurname, phoneNumber, email, status, idPatient);
                return "Se actualizaron los datos del anestesista";
            }
            catch (Exception error)
            {

                return "ERROR" + error.Message;
            }
        }

    }
}
