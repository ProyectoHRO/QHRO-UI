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

        public DataTable getDoctorByName(string name)
        {
            return doctors.GetDoctorByName(name);
        }
        public DataTable getDoctors()
        {
            return doctors.GetDoctors();
        }

        public string getDoctorsById(int id)
        {
            return doctors.GetDoctorById(id);
        }

        //insert
        public string newDoctor(int userId,string dpi, string firstName, string secondName, string thirdName, string firstLastName, string secondLastName,
            string phoneNumber,string email, string specialty)
        {
            try
            {
                DataTable doctor = doctors.GetDoctorByDpi(dpi);
                if (doctor.Rows.Count<1)
                {
                    doctors.InsertDoctor(userId,dpi,firstName,secondName,thirdName,firstLastName,secondLastName,phoneNumber,email,specialty);
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
        public string updateDoctor(int userId,string newDpi, string newFirstName, string newSecondName, string newThirdName, string newFirstLastName,
            string newSecondLastName, string newPhoneNumber, string newEmail, bool newStatus, string specialty, int idDoctor)
        {
            try
            {
                doctors.UpdateDoctor(userId,newDpi,newFirstName,newSecondName,newThirdName,newFirstLastName,newSecondLastName,newPhoneNumber,newEmail,newStatus, specialty,
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
