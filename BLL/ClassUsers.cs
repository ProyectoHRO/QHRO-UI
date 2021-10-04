using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ClassUsers
    {
        private Users users;
        public ClassUsers()
        {
            users = new Users();
        }

        public DataTable GetRoles()
        {
            return users.GetRoles();
        }
        public string Login(string userName, string password)
        {

            try
            {
                DataTable UserData = new DataTable();
                UserData = users.GetDataUsers(userName,password);
                if (UserData.Rows.Count == 1)
                {
                    return "Bienvenido " + UserData.Rows[0][1].ToString();
                }

                else
                    return "Usuario y/o contraseña incorrectos";
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }

        }

        public DataTable getDataUser(string userName, string password)
        {
            return users.GetDataUsers(userName, password);
        }

        public string addLoginCount(int iduser,int logCount, DateTime lastConnection)
        {
            try
            {
                users.addLoginCount(iduser,logCount, lastConnection);
                return "EXITO";
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }

        public string addUser(string email, int roleId, int serviceId)
        {
            try
            {
                string response =users.makeUser(email,roleId, serviceId);
                return response;
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }

    }
}
