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
        private ClassDoctor doctors = new ClassDoctor();
        string nombreUsuario="";
        

        public ActionResult Programaciones(string userName="")
        {
            nombreUsuario = userName;
            ViewBag.userName = nombreUsuario;
            return View();
        }

        public JsonResult fetchData()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(reports.dailySchedule(DateTime.Now.ToString("yyyy/MM/dd")));
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
            ViewBag.userName = nombreUsuario;
            return View();
        }

        [Authorize]
        public ActionResult Solicitar(string message="")
        {
            ViewBag.message = message;
            ViewBag.userName = nombreUsuario;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult No_Historia(string noHistorial)
        {
            ViewBag.userName = nombreUsuario;
            DataTable infoPatientsHro = patientsHro.getPatientsByHistoryNumber(noHistorial);
            string historyNumber = "";
            if (infoPatientsHro.Rows.Count < 1)
            {
                return RedirectToAction("Solicitar", new { message = "No se encuentra el número de historia" });
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

                ClassPacientInfo patientInfo = new ClassPacientInfo();
                patientInfo.HistoryNumber = historyNumber;
                patientInfo.FirstName = firstName;
                patientInfo.SecondName = secondName;
                patientInfo.FirstSurname = firstSurname;
                patientInfo.SecondSurname = secondSurname;
                patientInfo.Age = age;
                patientInfo.Gender = gender;
                patientInfo.Diagnosis = diagnosis;
                patientInfo.Band = band;
                patientInfo.IdPatient = idPatient;
                Session["dataPaciente"] = patientInfo;
                List<ClassDoctorsWeb> listadoDoctores = new List<ClassDoctorsWeb>();
                Session["listadoDocts"] = listadoDoctores;





                return RedirectToAction("obtenerDoctores");
            }
            else
            {
                return RedirectToAction("Solicitar", new { message = "Ha ocurrido un error, por favor inténtalo de nuevo." });
            }
            

            return RedirectToAction("Solicitar", new { message = "Ha ocurrido un error, por favor inténtalo de nuevo." });
        }

        public ActionResult obtenerDoctores()
        {
            return View();
        }

        [HttpPost]
        public ActionResult buscarDoctor(string nombreApellido)
        {
            DataTable doctorsInfo = doctors.getDoctorByName(nombreApellido);
            List<ClassDoctorsWeb> listadoDocts = new List<ClassDoctorsWeb>();
            ClassDoctorsWeb doc;
            foreach (DataRow item in doctorsInfo.Rows)
            {
                doc = new ClassDoctorsWeb();
                doc.IdDoctor = Convert.ToInt32(item.Field<int>(0));
                doc.DoctorName = item.Field<string>(2).ToString() + " " + item.Field<string>(5).ToString();
                listadoDocts.Add(doc);
            }
            ViewBag.doctors = listadoDocts;
            return View();
        }


        public ActionResult agregarDoctor(int idDoctor, string doctorName)
        {
            List<ClassDoctorsWeb> listado = Session["listadoDocts"] as List<ClassDoctorsWeb>;
            ClassDoctorsWeb doctor = new ClassDoctorsWeb();
            doctor.IdDoctor = idDoctor;
            doctor.DoctorName = doctorName;
            listado.Add(doctor);
            Session["listadoDocts"] = listado;
            return View();
        }

        public ActionResult eliminarDoctor(int idDoctor)
        {
            List<ClassDoctorsWeb> listado = Session["listadoDocts"] as List<ClassDoctorsWeb>;
            ClassDoctorsWeb doctorData;
            int listadoIndex=0;
            for (int i = 0; i < listado.Count; i++)
            {
                if (idDoctor == listado[i].IdDoctor)
                {
                    listadoIndex = i;
                }
            }

            listado.RemoveAt(listadoIndex);
            Session["listadoDocts"] = listado;
            if (listado.Count < 1)
            {
                return RedirectToAction("obtenerDoctores");
            }
            return View();
        }


        public ActionResult solicitarCirugia()
        {
            List<ClassDoctorsWeb> listado = Session["listadoDocts"] as List<ClassDoctorsWeb>;
            ClassPacientInfo infoPaciente = Session["dataPaciente"] as ClassPacientInfo;
            string response = "";
            if (listado.Count > 0)
            {
                if (Convert.ToInt32(infoPaciente.Band) == 1)
                {

                    List<ClassDtoDoctors> doctorsList = new List<ClassDtoDoctors>();
                    ClassDtoDoctors doctors;
                    foreach (ClassDoctorsWeb item in listado)
                    {
                        doctors = new ClassDtoDoctors();
                        doctors.DoctorId = item.IdDoctor;
                        doctorsList.Add(doctors);
                    }
                    response = requestSurgery.makeSurgeryRequestAndPatientWithDoctors(
                        Convert.ToInt32(Session["idUser"]),
                        infoPaciente.Diagnosis,
                        Convert.ToInt32(Session["serviceId"]),
                        infoPaciente.HistoryNumber,
                        infoPaciente.FirstName,
                        infoPaciente.SecondName,
                    infoPaciente.FirstSurname,
                    infoPaciente.SecondSurname,
                    Convert.ToInt16(infoPaciente.Age),
                    infoPaciente.Gender,
                    doctorsList);
                }
                else if (Convert.ToInt32(infoPaciente.Band) == 2)
                {
                    List<ClassDtoDoctors> doctorsList = new List<ClassDtoDoctors>();
                    ClassDtoDoctors doctors;
                    foreach (ClassDoctorsWeb item in listado)
                    {
                        doctors = new ClassDtoDoctors();
                        doctors.DoctorId = item.IdDoctor;
                        doctorsList.Add(doctors);
                    }
                    response = requestSurgery.makeSurgeryRequest(
                        Convert.ToInt32(Session["idUser"]),
                        infoPaciente.Diagnosis,
                        infoPaciente.FirstName,
                        infoPaciente.SecondName,
                    infoPaciente.FirstSurname,
                    infoPaciente.SecondSurname,
                    Convert.ToInt16(infoPaciente.Age),
                    infoPaciente.Gender,
                       Convert.ToInt32(infoPaciente.IdPatient),
                       Convert.ToInt32(Session["serviceId"]),
                       doctorsList);
                }

                return RedirectToAction("Solicitar", new { message = response });
            }
            else
            {
                return RedirectToAction("Solicitar", new { message = "Por favor asigne personal médico" });
            }
            return View();
        }
    }
}