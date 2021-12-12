using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassPacientInfo
    {
        string historyNumber;
        string firstName;
        string secondName;
        string firstSurname;
        string secondSurname;
        string age;
        string gender;
        string diagnosis;
        string band;
        string idPatient;

        public string HistoryNumber { get => historyNumber; set => historyNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string FirstSurname { get => firstSurname; set => firstSurname = value; }
        public string SecondSurname { get => secondSurname; set => secondSurname = value; }
        public string Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Diagnosis { get => diagnosis; set => diagnosis = value; }
        public string Band { get => band; set => band = value; }
        public string IdPatient { get => idPatient; set => idPatient = value; }
    }
}
