using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassGetStrings
    {
        public string[] getStrings(string str, char[] delimiters)
        {
            string[] response = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            return response;
        }

    }
}
