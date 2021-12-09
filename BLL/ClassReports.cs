using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class ClassReports
    {
        private Surgeries surgeries = new Surgeries();
        private ClassOperatingRoom Operatigrooms = new ClassOperatingRoom();
        private ClassGetStrings GetStrings = new ClassGetStrings();

        public List<ClassDailySurgeries> dailySchedule(string date) {

            List<ClassDailySurgeries> surgeriesList = new List<ClassDailySurgeries>();
            ClassDailySurgeries surgerie = new ClassDailySurgeries();
            DataTable surgeriesData = surgeries.getDailySurgeries(date);
            foreach (DataRow item in surgeriesData.Rows)
            {
                string docName = "";
                string assistantName = "";
                surgerie = new ClassDailySurgeries();
                surgerie.IdCirugia = Convert.ToInt32(item.Field<int>(0));
                surgerie.Hora = item.Field<string>(1).ToString();
                surgerie.Qx = item.Field<string>(2).ToString();
                surgerie.No_Historia = item.Field<string>(3).ToString();
                surgerie.Nombre = item.Field<string>(4).ToString();
                surgerie.Edad = Convert.ToInt16(item.Field<short>(5));
                surgerie.Procedimiento = item.Field<string>(6).ToString();
                surgerie.Servicio = item.Field<string>(7).ToString();
                DataTable infoDoctor = surgeries.getDoctorsByIdSurgerie(surgerie.IdCirugia);
                if (infoDoctor.Rows.Count < 2)
                {
                    foreach (DataRow itemDoc in infoDoctor.Rows)
                    {
                        surgerie.Cirujano = itemDoc.Field<string>(1).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemDoc in infoDoctor.Rows)
                    {
                        docName = ' ' + docName + itemDoc.Field<string>(1).ToString() + " / ";
                    }
                    surgerie.Cirujano = docName.TrimEnd(' ');
                    surgerie.Cirujano = surgerie.Cirujano.TrimEnd('/');
                }
                surgerie.Anestesiólogo = item.Field<string>(8).ToString();
                DataTable infoAssistants = surgeries.getAssistantsBySurgerie(surgerie.IdCirugia);
                if (infoAssistants.Rows.Count < 2)
                {
                    foreach (DataRow itemAssistant in infoAssistants.Rows)
                    {
                        surgerie.Enfermería = itemAssistant.Field<string>(1).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemAssistant in infoAssistants.Rows)
                    {
                        assistantName = assistantName + itemAssistant.Field<string>(1).ToString() + '/';
                    }
                    surgerie.Enfermería = assistantName.TrimEnd('/');
                }
                surgeriesList.Add(surgerie);
            }
            return surgeriesList;
        }

        public List<ClassStatusOperatingRooms> StatusOperatingRooms()
        {
            List<ClassStatusOperatingRooms> ORList = new List<ClassStatusOperatingRooms>();
            ClassStatusOperatingRooms Rooms = new ClassStatusOperatingRooms();
            DataTable infoOperatingRooms = Operatigrooms.listoperatingRooms();

            foreach (DataRow item in infoOperatingRooms.Rows)
            {
                Rooms = new ClassStatusOperatingRooms();
                Rooms.IdQ = Convert.ToInt32(item.Field<int>(0));
                Rooms.Qx = item.Field<string>(1).ToString();
                Rooms.estado_actual = item.Field<string>(2).ToString();
                DataTable surgeriesData = surgeries.getDialySurgeriesByOperatingRoom(Rooms.IdQ);
                if (surgeriesData.Rows.Count > 0)
                {
                    foreach (DataRow item2 in surgeriesData.Rows)
                    {
                        Rooms.Nombre = item2.Field<string>(4).ToString();
                        Rooms.Procedimiento = item2.Field<string>(6).ToString();
                    }
                }
                else
                {
                    foreach (DataRow item2 in surgeriesData.Rows)
                    {
                        Rooms.Nombre = " ";
                        Rooms.Procedimiento = " ";
                    }
                }
                ORList.Add(Rooms);
            }
            return ORList;
        }

        public void ChangeStatusOperatingRoom()
        {
            string day = DateTime.Now.ToString("yyyy/MM/dd");
            DataTable dialySurgeries = surgeries.getDailySurgeries(day);

            foreach(DataRow item in dialySurgeries.Rows)
            {
                string hora = item.Field<string>(1).ToString();
                string numberQ = item.Field<string>(2).ToString();

                string[] timeSep = GetStrings.getStrings(hora, new char[] { ':', ' '});
                string h = timeSep[0];
                string m = timeSep[1];
                string AorP = timeSep[2];
                if (AorP == "A.M")
                {
                    if (h == "12")
                    {
                        h = "00";
                    }
                }
                else if (AorP == "P.M")
                {
                    h = ((Convert.ToInt32(h) % 12) + 12).ToString();
                }

                DateTime f1 = Convert.ToDateTime(h + ":" + m + ":00");
                string f2 = f1.ToString("HH:mm");
                string f3 = DateTime.Now.ToString("HH:mm");
                TimeSpan t1 = TimeSpan.Parse(f2);
                TimeSpan t2 = TimeSpan.Parse(f3);
                int i = TimeSpan.Compare(t1, t2);

        

                if (i == 0)
                {
                    DataTable infoOperatingRooms = Operatigrooms.listoperatingRooms();

                    foreach (DataRow OpRoom in infoOperatingRooms.Rows)
                    {
                        int IdQ = OpRoom.Field<int>(0);
                        string numQ = OpRoom.Field<string>(1).ToString();

                        if ((numQ == numberQ))
                        {
                            string resp = Operatigrooms.editoperatingRoom(numQ, "Ocupado", true, IdQ);

                        }
                    }
                }
                else
                {
                }
               
            }
        }
    }
}
