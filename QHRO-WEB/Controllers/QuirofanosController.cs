using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using System.Data;
namespace QHRO_WEB.Controllers
{
    public class QuirofanosController : Controller
    {
        private ClassPatient patients = new ClassPatient();
        private ClassReports reports = new ClassReports();
        private ClassPHro patientsHro = new ClassPHro();
        private ClassRequestSurgery requestSurgery = new ClassRequestSurgery();

        public ActionResult Programaciones()
        {
            return View();
        }

        public JsonResult fetchData()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(reports.dailySchedule());
            reports.ChangeStatusOperatingRoom();
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public JsonResult fetchQData()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(reports.StatusOperatingRooms());
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public ActionResult programacionesInfo()
        {

            return View();
        }
        // GET: Quirofanos
        public ActionResult Estado()
        {
            //var Status = reports.StatusOperatingRooms();
            return View();
        }

        [Authorize]
        public ActionResult Solicitar(string message="")
        {
            ViewBag.message = message;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult No_Historia(string noHistorial)
        {
            DataTable infoPatientsHro = patientsHro.getPatientsByHistoryNumber(noHistorial);
            string historyNumber = "";
            if (infoPatientsHro.Rows.Count < 1)
            {
                return RedirectToAction("Solicitar", new { message = "Inicio de sesión no valido" });
            }
            else
            {
                foreach (DataRow item in infoPatientsHro.Rows)
                {
                    historyNumber = item.Field<string>(0);
                    ViewBag.historyNumber = item.Field<string>(0);
                    ViewBag.FirstName = item.Field<string>(1);
                    ViewBag.SecondName = item.Field<string>(2);
                    ViewBag.FirstSurname = item.Field<string>(3);
                    ViewBag.secondSurname = item.Field<string>(4);
                    string sex = item.Field<string>(5);
                    if (sex == "0")
                    {
                        ViewBag.Gender = "Masculino";
                    }
                    else if (sex == "1")
                    {
                        ViewBag.Gender = "Femenino";
                    }
                    ViewBag.Age = item.Field<int>(6).ToString();
                }
                DataTable getPatient = patients.getPatientsByHistoryNumber(historyNumber);
                if (getPatient.Rows.Count < 1)
                {
                    ViewBag.band = 1;
                }
                else
                {
                    ViewBag.band = 2;
                    foreach (DataRow item in getPatient.Rows)
                    {
                        ViewBag.idPatient = item.Field<int>(0).ToString();

                    }
                }
                return View();
            }
            
        }
        [Authorize]
        [HttpPost]
        public ActionResult RequestSurgerie(
            string historyNumber,
            string firstName,
            string secondName,
            string firstSurname,
            string secondSurname,
            string age,
            string gender,
            string diagnosis,
            string band,
            string idPatient
            )
        {
          
            if (Session["idUser"]!=null)
            {
                if (Session["serviceId"]!=null)
                {
                    if (band == "1")
                    {
                        string response = requestSurgery.makeSurgeryRequestAndPatient(
                            Convert.ToInt32(Session["idUser"]), 
                            diagnosis, 
                            Convert.ToInt32(Session["serviceId"]), 
                            historyNumber,
                            firstName,
                            secondName,
                            firstSurname,
                            secondSurname, 
                            Convert.ToInt16(age),
                            gender
                        );
                        return RedirectToAction("Solicitar", new { message = response });
                    }
                    else if (band == "2")
                    {
                        string response = requestSurgery.makeSurgeryRequest(
                             Convert.ToInt32(Session["idUser"]),
                            diagnosis,
                            firstName,
                            secondName,
                            firstSurname,
                            secondSurname,
                            Convert.ToInt16(age),
                            gender,
                           Convert.ToInt32(idPatient),
                           Convert.ToInt32(Session["serviceId"])
                           );
                        return RedirectToAction("Solicitar", new { message = response });
                    }
                }
                else
                {
                    if (band == "1")
                    {

                        string response = requestSurgery.makeSurgeryRequestAndPatient(
                             Convert.ToInt32(Session["idUser"]),
                            diagnosis,
                            23,
                            historyNumber,
                            firstName,
                            secondName,
                            firstSurname,
                            secondSurname,
                            Convert.ToInt16(age),
                            gender
                        );
                        return RedirectToAction("Solicitar", new { message = response });
                    }
                    else if (band == "2")
                    {
                        string response = requestSurgery.makeSurgeryRequest(
                           Convert.ToInt32(Session["idUser"]),
                            diagnosis,
                            firstName,
                            secondName,
                            firstSurname,
                            secondSurname,
                            Convert.ToInt16(age),
                            gender,
                           Convert.ToInt32(idPatient),
                           23);
                        return RedirectToAction("Solicitar", new { message = response });
                    }
                }
             
                return RedirectToAction("Solicitar", new { message = "Ha ocurrido un error, por favor inténtalo de nuevo." });
            }
            else
            {
                return RedirectToAction("Solicitar", new { message = "Ha ocurrido un error, por favor inténtalo de nuevo." });
            }
            

            return RedirectToAction("Solicitar", new { message = "Ha ocurrido un error, por favor inténtalo de nuevo." });
        }
    }
}