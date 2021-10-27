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
            return View();
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
    }
}