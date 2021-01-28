using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasUppgift
{
    class Guardian : Person
    {
        public Guardian(string firstName, string lastName, string adress, string phonenumber, string mail, int id) : base(firstName, lastName, adress, phonenumber, mail, id)
        {

        }
    }
}
