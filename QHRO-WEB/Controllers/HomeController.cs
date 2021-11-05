using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography;
using BLL;
using System.Data;
namespace QHRO_WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }
        string hash = "@HR0";
        string queryResult;
        int idUser;
        int logCount;
        bool confirmation;
        int serviceId;
        string mail;
        DateTime lastConnection;
        [HttpPost]
        public ActionResult Login(string usuario, string password)
        {
          
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password))
            {
                 ClassUsers user = new ClassUsers();
                byte[] data = UTF8Encoding.UTF8.GetBytes(password);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        password = Convert.ToBase64String(results, 0, results.Length);
                    }
                }

                queryResult = user.Login(usuario,password);

                if (queryResult.Contains("incorrectos"))
                {
                    return RedirectToAction("Index", new { message = "Inicio de sesión no valido" });
                }
                else
                {
                    DataTable userData = user.getDataUser(usuario, password);

                    foreach (DataRow item in userData.Rows)
                    {
                        idUser = Convert.ToInt32(item.Field<int>(0));
                        lastConnection = Convert.ToDateTime(item.Field<System.DateTime>(8));
                        confirmation = item.Field<bool>(9);
                        logCount = Convert.ToInt32(item.Field<int>(10));
                        serviceId = Convert.ToInt32(item.Field<int>(11));
                        mail = item.Field<string>(12).ToString();
                    }
                    if (confirmation == false)
                    {
                        return RedirectToAction("Index", new { message = "Inicio de sesión no valido" });
                    }
                    else
                    {
                        if (logCount == 0)
                        {

                            ClassMail mails = new ClassMail();
                            mails.MakeMail(mail, "Has iniciado sesión por primera vez en el sistema de quirófanos. \n Con el usuario: " + user + " \n A las: " + DateTime.Now.ToString(), "PRIMER INICIO DE SESIÓN SISTEMA DE QUIRÓFANOS", "");
                        }

                        logCount++;
                        user.addLoginCount(idUser, logCount, lastConnection);

                        FormsAuthentication.SetAuthCookie(password, true);
                        DataTable permits=user.getPermitsByUserId(idUser);
                        int idPermit = 0;
                        foreach (DataRow item in permits.Rows)
                        {
                            if (Convert.ToInt32(item.Field<int>(1))==7)
                            {
                                idPermit = 7;
                            }
                        }
                        Session["serviceId"] = serviceId;
                        if (idPermit==7)
                        {
                            Session["idPermit"] = idPermit;
                        }
                        return RedirectToAction("Programaciones", "Quirofanos");
                    }
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "Llena los campos para poder inicar sesión" });

            }

        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["serviceId"] = null;
            Session["idPermit"] = null;
            return RedirectToAction("Index");
        }
        public ActionResult Nuevo()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}