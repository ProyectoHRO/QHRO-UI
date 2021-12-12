using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassDoctorsWeb
    {
        int idDoctor;
        string doctorName;

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
    }
}
