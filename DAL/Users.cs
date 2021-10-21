using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Users
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();
       
        public DataTable GetDataUsers(string user, string password)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "IniciarSesion";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@usuario", user);
            command.Parameters.AddWithValue("@contra", password);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetDataUsersByUserName(string userName)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerUsuarioPorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", userName);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable GetPermitsById(int idPermit)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerPermisosPorId";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idservicio", idPermit);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetPermits()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarPermisos";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }


        public DataTable GetRoles()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarRoles";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }

        public void addLoginCount(int iduser, int logCount, DateTime lastConnection) 
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "ActualizarLogueo";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", iduser);
            command.Parameters.AddWithValue("@contadorLogueos", logCount);
            command.Parameters.AddWithValue("@ultima_conexion", lastConnection);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public string makeUser(
            string email,
            int roleId,
            int serviceId)
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@idrol", roleId);
            command.Parameters.AddWithValue("@idServicio", serviceId);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }

        public void makeUserPass(
           int userId,
           string pass)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "CrearContraUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idUsuario", userId);
            command.Parameters.AddWithValue("@contra", pass);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void confirmUser(
          int userId,
          string userName,
          string pass,
          DateTime lastConnection)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "ConfirmarUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idUsuario", userId);
            command.Parameters.AddWithValue("@usuario", userName);
            command.Parameters.AddWithValue("@contra", pass);
            command.Parameters.AddWithValue("@ultima_conexion", lastConnection);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public string assignPermits(
            DataTable permitsDetail
            )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_assignPermits";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@detalle", permitsDetail);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }


        public string modifyPermits(
            int userId,
            DataTable permitsDetail
            )
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "sp_modifyPermits";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@detalle", permitsDetail);
            command.Parameters.Add("@mensaje", SqlDbType.NVarChar, 250);
            command.Parameters["@mensaje"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@mensaje"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }

        public void ModifyUserData(string user, string email, string password, DateTime fecha_modificacion, int id)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "UpdateUserData";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@usuario", user);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@contraseña", password);
            command.Parameters.AddWithValue("@fecha_modificacion", fecha_modificacion);
            command.Parameters.AddWithValue("@idusuario", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void restartPasswordUser(
          int userId,
          string userName,
          string pass)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "RestablecerUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@usuario", userName);
            command.Parameters.AddWithValue("@contraseña", pass);
            command.Parameters.AddWithValue("@idUsuario", userId);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public DataTable getUserMail(string email)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerCorreo";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@correo", email);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public DataTable getPermitsByUser(int idUser)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "ObtenerPermisosPorUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", idUser);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

    }
}
