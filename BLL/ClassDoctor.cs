using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetDoctorsTableAdapters;
using System.Data;
namespace BLL
{
    public class ClassDoctor
    {
        private doctoresTableAdapter doctors;
        public ClassDoctor()
        {
            doctors = new doctoresTableAdapter();
        }
        //Methods
        //get
        public DataTable getDoctors()
        {
            return doctors.GetDataDoctors();
        }
        //insert
        public string newDoctor(string dpi, string firstName, string secondName, string thirdName, string firstLastName, string secondLastName,
            string phoneNumber,string email)
        {
            try
            {
                DataTable doctor = doctors.GetDataByDpiDoctor(dpi);
                if (doctor.Rows.Count<1)
                {
                    doctors.InsertQueryDoctors(dpi,firstName,secondName,thirdName,firstLastName,secondLastName,phoneNumber,email);
                    return "SE HA GRABADO UN NUEVO REGISTRO";
                }
                else
                    return "ERROR: El Doctor ya existe:  " + firstName + " " + firstLastName;
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
        //update
        public string updateDoctor(string newDpi, string newFirstName, string newSecondName, string newThirdName, string newFirstLastName,
            string newSecondLastName, string newPhoneNumber, string newEmail, bool newStatus, int idDoctor)
        {
            try
            {
                doctors.UpdateQueryDoctor(newDpi,newFirstName,newSecondName,newThirdName,newFirstLastName,newSecondLastName,newPhoneNumber,newEmail,newStatus,
                    idDoctor);
                return "SE HA ACTUALIZADO EL REGISTRO";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
    }
}
