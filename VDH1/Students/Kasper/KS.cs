using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDH1.Students.Kasper
{
    class KS
    {
        private string FirstName = "Kasper ";
        private string LastName = "Sylvest";

        public string GetName()
        {
            string FullName = FirstName + LastName;

            return FullName;
        }
    }
}
