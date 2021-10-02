using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ClassOperatingRoom
    {
        private OperatingRooms operatingRoom;
        public ClassOperatingRoom()
        {
            operatingRoom = new OperatingRooms();
        }

        public DataTable listoperatingRooms()
        {
            return operatingRoom.GetOperatingRooms();
        }

        public string newoperatingRoom(string operatingroomNumber, string currentState)
        {
            try
            {
                operatingRoom.InsertOperatingRoom(operatingroomNumber, currentState);
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
                operatingRoom.UpdateOperatingRoom(operatingroomNumber, currentState, status, operatingroomId);
                return "Se actualizaron los datos del quirofano";
            }
            catch (Exception error)
            {

                return "ERROR" + error.Message;
            }
        }
    }
}
