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

    }
}
