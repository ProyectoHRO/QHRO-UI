using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{

    public class ClassAnesthesia
    {
        private Anesthesia anesthesia;
        public ClassAnesthesia()
        {
            anesthesia = new Anesthesia();
        }

        public DataTable getAnesthesia()
        {
            return anesthesia.GetAnestheasia();
        }

        public DataTable getAnesthesiaById(int id)
        {
            return anesthesia.GetAnesthesiaById(id);
        }

        public DataTable getAnesthesiaByName(string name)
        {
            return anesthesia.GetAnesthesiaByAnesthesiaTypeReport(name);
        }

        public string newAnesthesiaType(string AnesthesiaType)
        {
            try
            {
                DataTable anesth = anesthesia.GetAnesthesiaByAnesthesiaType(AnesthesiaType);
                if (anesth.Rows.Count < 1)
                {
                    anesthesia.InsertAnesthesiaType(AnesthesiaType);
                    return "SE HA GRABADO UN NUEVO REGISTRO";
                }
                else
                    return "ERROR: El tipo de anestesia ya existe:  " + AnesthesiaType;
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }

        public string updateAnesthesiaType(string AnesthesiaType, short anesthesiaId)
        {
            try
            {
                anesthesia.UpdateAnesthesiaType(AnesthesiaType, anesthesiaId);
                return "SE HA ACTUALIZADO EL REGISTRO";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
    }
}
