using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasUppgift
{
    public abstract class PersonModel
    {
        public string first_name { get; private set; }
        public string last_name { get; private set; }

        public string adress { get; private set; }
        public string phone_number { get; private set; }
        public string e_mail { get; private set; }

        public int id { get; private set; }

        public PersonModel(string first_name, string last_name, string adress, string phone_number, string e_mail, int id)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.adress = adress;
            this.phone_number = phone_number;
            this.e_mail = e_mail;
            this.id = id;
        }

        public string FullName
        {
            get
            {
                return first_name + " " + last_name;
            }
        }
    }
}
