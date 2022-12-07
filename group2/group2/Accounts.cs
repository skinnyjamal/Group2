using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    public class Accounts
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public int salary { get; set; }
        public int customerID { get; set; }

        public int current { get; set; }
        public bool special = false;
        public int savings { get; set; }
        public int ISA { get; set; }

        public int pin { get; set; }
    }
}
