using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetOperatingRoomsTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassOperatingRoom
    {
        private quirofanosTableAdapter operatingRoom;
        public ClassOperatingRoom()
        {
            operatingRoom = new quirofanosTableAdapter();
        }

        public DataTable listoperatingRooms()
        {
            return operatingRoom.GetDataOperatingRooms();
        }

        public string newoperatingRoom(string operatingroomNumber, string currentState)
        {
            try
            {
                operatingRoom.InsertQueryNewOperatingRoom(operatingroomNumber, currentState);
                return "Nuevo quirofano agregado";
            }
            catch (Exception error)
            {
                return "ERROR" + error.Message;
            }
        }

        public string editoperatingRoom(string operatingroomNumber, string currentState, bool status, int operatingroomId)
        {
            try
            {
                operatingRoom.UpdateQueryEditOperatingRoom(operatingroomNumber, currentState, status, operatingroomId);
                return "Se actualizaron los datos del quirofano";
            }
            catch (Exception error)
            {

                return "ERROR" + error.Message;
            }
        }
    }
}
