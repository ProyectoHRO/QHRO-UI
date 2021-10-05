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

        public DataTable GetPermits()
        {
            return users.GetPermits();
        }
        public DataTable GetRoles()
        {
            return users.GetRoles();
        }
        public DataTable GetUserByUserName(string userName)
        {
            return users.GetDataUsersByUserName(userName);
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

        public DataTable getUserByEmail(string email)
        {
            return users.getUserMail(email);
        }

        public DataTable getPermitsByUserId(int userId)
        {
            return users.getPermitsByUser(userId);
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

        public string makeUserPass(int idUser, string pass)
        {
            try
            {
                users.makeUserPass(idUser,pass);
                return " ";
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }

        public string restoreUserPass(int idUser, string userName,string pass)
        {
            try
            {
                users.restartPasswordUser(idUser, userName, pass);
                return "Usuario restablecido con exito por favor revisar correo";
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

                DataTable getuser = users.getUserMail(email);
                if (getuser.Rows.Count < 1)
                {
                    string response = users.makeUser(email, roleId, serviceId);
                    return response;
                }
                else
                    return "ERROR: El correo ya esta registrado:  ";

              
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }

        public string ConfirmUser(int idUser, string userName, string pass, DateTime lastConnection)
        {
            try
            {
                users.confirmUser(idUser, userName, pass, lastConnection);
                return "Usuario confirmado correctamente!";
            }
            catch (Exception error)
            {

                return "ERROR: " + error.Message;
            }
        }


        public string assignPermits(List<ClassDtoPermits> permitsList)
        {
            string response = "";
            DataTable dataPermits = new DataTable() { Columns = { "idPermit", "idUser" } };
            foreach (ClassDtoPermits item in permitsList)
            {
                dataPermits.Rows.Add(item.IdPermit,item.IdUser);
            }
            response = users.assignPermits(dataPermits);
            return response;

        }

    }
}
