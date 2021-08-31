using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetAssistantsTableAdapters;
using System.Data;
namespace BLL
{
    public class ClassAssistants
    {
        private Tipo_ayudanteTableAdapter typeAssistants;
        private ayudanteTableAdapter assistants;
        public ClassAssistants()
        {
            typeAssistants = new Tipo_ayudanteTableAdapter();
            assistants = new ayudanteTableAdapter();
        }
        //Methods
        //get
        public DataTable getAssistants()
        {
            return assistants.GetDataAssistant();
        }
        public DataTable getTypeAssistants()
        {
            return typeAssistants.GetDataTypeAssistant();
        }
        //Post
        public string newAssistant(string firstName, string secondName, string thirdName, string firstLastName, string secondLastName, string email, 
            string phone, int idType, string cui)
        {
            try
            {
                DataTable assistant = assistants.GetDataByCui(cui);
                if (assistant.Rows.Count < 1)
                {
                    assistants.InsertQueryAssistant(firstName,secondName,thirdName,firstLastName,secondLastName,email,phone,idType,cui);
                    return "SE HA GRABADO UN NUEVO REGISTRO";
                }
                else
                {
                    return "ERROR: El asistente ya existe:  " + firstName + " "+ firstLastName;
                }
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }
        //Put
        public string updateAssistant(string newFirstName, string newSecondName, string newThirdName, string newFirstLastName, string newSecondLastName, string newEmail, string newPhone, bool newStatus, int newIdType, string newCui, int idAssistant)
        {
            try
            {
                assistants.UpdateQueryAssistant(newFirstName, newSecondName, newThirdName, newFirstLastName, newSecondLastName, newEmail, newPhone, newStatus, newIdType, newCui, idAssistant);
                return "SE HA ACTUALIZADO EL REGISTRO";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
    }
}
