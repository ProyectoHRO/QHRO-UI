using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ClassAnesthetist
    {
        private Anesthetist ANESTHETIST;

        public ClassAnesthetist()
        {
            ANESTHETIST = new Anesthetist();
        }
        
        public DataTable getAnesthetistByDpi(string dpi)
        {
            return ANESTHETIST.GetAnesthetistByCui(dpi);
        }

        //public DataTable getAnesthetistByName(string firstName, string secondName,string thirdName, string firstSurname, string secondSurname)
        //{
        //    return ANESTHETIST.GetDataByAnesthetistName(firstName,secondName,thirdName,firstSurname,secondSurname);
        //}
        public DataTable listAnesthetist()
        {
            return ANESTHETIST.GetAnesthetist();
        }


        public DataTable getAnesthetistByname(string name)
        {
            return ANESTHETIST.GetAnesthetistByName(name);
        }

        public string newAnesthetist(string dpi, string firstName, string secondName,
            string thirdName, string firstSurname, string secondSurname, string phoneNumber, string email)
        {
            try
            {
                DataTable anestethist = ANESTHETIST.GetAnesthetistByCui(dpi);
                if (anestethist.Rows.Count < 1)
                {
                    ANESTHETIST.InsertAnesthetist(dpi, firstName, secondName, thirdName,
                    firstSurname, secondSurname, phoneNumber, email);
                    return "Nuevo registro agregado";
                }
                else
                    return "Ya existe la persona con dpi: "+dpi;
            }
            catch (Exception error)
            {
                return "ERROR" + error.Message;
            }
        }

        public string editAnesthetist(string dpi, string firstName, string secondName,
            string thirdName, string firstSurname, string secondSurname, string phoneNumber, string email,
            bool status, int idAnesthetist)
        {
            try
            {
                ANESTHETIST.UpdateAnesthetist(dpi, firstName, secondName, thirdName, firstSurname,
                    secondSurname, phoneNumber, email, status, idAnesthetist);
                return "Se actualizaron los datos del anestesista";
            }
            catch (Exception error)
            {

                return "ERROR" + error.Message;
            }
        }

    }
}