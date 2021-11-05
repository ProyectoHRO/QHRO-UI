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
        [Authorize]
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