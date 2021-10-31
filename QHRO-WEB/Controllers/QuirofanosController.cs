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
        // GET: Quirofanos
        public ActionResult Estado()
        {
            var Status = reports.StatusOperatingRooms();
            return View(Status.ToList());
        }

        public ActionResult Programaciones()
        {
            var schedule = reports.dailySchedule();
            return View(schedule.ToList());
        }

        public ActionResult Solicitar()
        {
            return View();
        }

        public ActionResult No_Historia()
        {
            return View();
        }
    }
}