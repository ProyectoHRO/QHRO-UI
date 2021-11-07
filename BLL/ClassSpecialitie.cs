using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ClassSpecialitie
    {
        private Specialities specialities;
        public ClassSpecialitie()
        {
            specialities = new Specialities();
        }

        public DataTable getSpecialities()
        {
            return specialities.GetSpecialities();
        }

        public string insertSpecialitie(string specialitieName)
        {
            try
            {
                DataTable specialitie = specialities.GetSpecialitieByName(specialitieName);
                if (specialitie.Rows.Count < 1)
                {
                    specialities.InsertSpecialitie(specialitieName);
                    return "Se ha registrado una nueva especialidad";
                }
                else
                {
                    return "ERROR: La especialidad ya existe: " + specialitieName;
                }
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }

        public string updateSpecialitie(string specialitieName, int Id)
        {
            try
            {
                specialities.UpdateSpecialitie(specialitieName, Id);
                return "SE HA ACTUALIZADO EL REGISTRO";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
    }
}
