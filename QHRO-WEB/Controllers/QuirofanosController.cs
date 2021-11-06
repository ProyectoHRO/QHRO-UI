using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace QHRO_WEB.Controllers
{
    public class QuirofanosController : Controller
    {
      
        private ClassReports reports = new ClassReports();

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

        public ActionResult programacionesInfo()
        {

            return View();
        }
        // GET: Quirofanos
        [Authorize]
        public ActionResult Estado()
        {
            var Status = reports.StatusOperatingRooms();
            return View(Status.ToList());
        }

        [Authorize]
        public ActionResult Solicitar()
        {
            return View();
        }
        [Authorize]
        public ActionResult No_Historia()
        {
            return View();
        }
    }
}