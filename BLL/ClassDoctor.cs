using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class ClassDoctor
    {
        private Doctor doctors;
        public ClassDoctor()
        {
            doctors = new Doctor();
        }
        //Methods
        //get
        public DataTable getDoctorByDpi(string dpi)
        {
            return doctors.GetDoctorByDpi(dpi);
        }
        //public DataTable getDoctorByName(string firstName, string secondName, string thirdName, string firstSurname, string secondSurname)
        //{
        //    return doctors.GetDataByDoctorName(firstName, secondName, thirdName, firstSurname, secondSurname);
        //}
        public DataTable getDoctors()
        {
            return doctors.GetDoctors();
        }
        //insert
        public string newDoctor(string dpi, string firstName, string secondName, string thirdName, string firstLastName, string secondLastName,
            string phoneNumber,string email)
        {
            try
            {
                DataTable doctor = doctors.GetDoctorByDpi(dpi);
                if (doctor.Rows.Count<1)
                {
                    doctors.InsertDoctor(dpi,firstName,secondName,thirdName,firstLastName,secondLastName,phoneNumber,email);
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
                doctors.UpdateDoctor(newDpi,newFirstName,newSecondName,newThirdName,newFirstLastName,newSecondLastName,newPhoneNumber,newEmail,newStatus,
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
