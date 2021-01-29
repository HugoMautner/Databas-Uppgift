using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasUppgift
{
    public class PersonModel
    {
        public string first_name { get; set; }
        public string last_name { get; set; }

        public string adress { get; set; }
        public string phone_number { get; set; }
        public string e_ail { get; set; }

        public int id { get; set; }


        public string FullName
        {
            get
            {
                return first_name + " " + last_name;
            }
        }
    }
}
