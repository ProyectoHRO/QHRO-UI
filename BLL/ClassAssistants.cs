using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class ClassAssistants
    {
        private Assistant assistants;
        public ClassAssistants()
        {
            assistants = new Assistant();
        }
        //Methods
        //get

        public DataTable getAssistantByDpi(string dpi)
        {
            return assistants.GetAssistantByDPI(dpi);
        }
        
        public DataTable getTypeAssistantById(int id)
        {
            return assistants.GetTypeAssistantById(id);
        }

        public DataTable getAssistantByName(string name)
        {
            return assistants.GetAssistantByName(name);
        }
        //public DataTable getAssistantByName(string firstName, string secondName, string thirdName, string firstSurname, string secondSurname)
        //{
        //    return assistants.GetDataByAssistantName(firstName, secondName, thirdName, firstSurname, secondSurname);
        //}
        public DataTable getAssistants()
        {
            return assistants.GetAssistants();
        }
        public DataTable getTypeAssistants()
        {
            return assistants.GetTypeAssistant();
        }
        //insert
        public string newAssistant(string firstName, string secondName, string thirdName, string firstLastName, string secondLastName, string email, 
            string phone, int idType, string cui)
        {
            try
            {
                DataTable assistant = assistants.GetAssistantByDPI(cui);
                if (assistant.Rows.Count < 1)
                {
                    assistants.InsertAssistant(firstName,secondName,thirdName,firstLastName,secondLastName,email,phone,idType,cui);
                    return "SE HA GRABADO UN NUEVO REGISTRO";
                }
                else
                    return "ERROR: El asistente ya existe:  " + firstName + " "+ firstLastName;
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
        //update
        public string updateAssistant(string newFirstName, string newSecondName, string newThirdName, string newFirstLastName, string newSecondLastName, string newEmail, string newPhone, bool newStatus, int newIdType, string newCui, int idAssistant)
        {
            try
            {
                assistants.UpdateAssistant(newFirstName, newSecondName, newThirdName, newFirstLastName, newSecondLastName, newEmail, newPhone, newStatus, newIdType, newCui, idAssistant);
                return "SE HA ACTUALIZADO EL REGISTRO";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
    }
}
