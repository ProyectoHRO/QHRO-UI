using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassDtoPermits
    {
        int idPermit;
        int idUser;

        public int IdPermit { get => idPermit; set => idPermit = value; }
        public int IdUser { get => idUser; set => idUser = value; }
    }
}
