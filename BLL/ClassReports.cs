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

        public List<ClassDailySurgeries> dailySchedule() {

            List<ClassDailySurgeries> surgeriesList = new List<ClassDailySurgeries>();
            ClassDailySurgeries surgerie = new ClassDailySurgeries();
            DataTable surgeriesData = surgeries.getDailySurgeries();


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
                surgerie.Anestesista = item.Field<string>(8).ToString();
                DataTable infoAssistants = surgeries.getAssistantsBySurgerie(surgerie.IdCirugia);
                if (infoAssistants.Rows.Count < 2)
                {
                    foreach (DataRow itemAssistant in infoAssistants.Rows)
                    {
                        surgerie.Asistentes = itemAssistant.Field<string>(1).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemAssistant in infoAssistants.Rows)
                    {
                        assistantName = assistantName + itemAssistant.Field<string>(1).ToString() + '/';
                    }
                    surgerie.Asistentes = assistantName.TrimEnd('/');
                }
                surgeriesList.Add(surgerie);
            }
            return surgeriesList;
        }

        public List<ClassStatusOperatingRooms> StatusOperatingRooms()
        {
            List<ClassStatusOperatingRooms> ORList = new List<ClassStatusOperatingRooms>();
            ClassStatusOperatingRooms Rooms = new ClassStatusOperatingRooms();
            DataTable surgeriesData = surgeries.getDailySurgeries();

            DataTable infoOperatingRooms = Operatigrooms.listoperatingRooms();
            foreach (DataRow item in infoOperatingRooms.Rows)
            {
                Rooms = new ClassStatusOperatingRooms();

                    foreach (DataRow item2 in surgeriesData.Rows)
                    {
                        Rooms.Qx = item2.Field<string>(2).ToString();
                        Rooms.Nombre = item2.Field<string>(4).ToString();
                        Rooms.Procedimiento = item2.Field<string>(6).ToString();
                        Rooms.estado_actual = item.Field<string>(2).ToString();
                        ORList.Add(Rooms);
                    }
                
            }

            return ORList;
        }
    }
}
