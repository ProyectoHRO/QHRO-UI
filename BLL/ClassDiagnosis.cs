using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassDiagnosis
    {
        public int id_diagnostico { get; set; }

        public string diagnostico { get; set; }

        public string fecha_diagnostico { get; set; }

        public int idpaciente { get; set; }
    }
}
