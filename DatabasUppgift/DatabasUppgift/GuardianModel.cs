using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasUppgift
{
    class GuardianModel : PersonModel
    {
        public GuardianModel(int id, string first_name, string last_name, string adress, string phone_number, string e_mail) : base(id, first_name, last_name, adress, phone_number, e_mail)
        {

        }
        public GuardianModel()
        {

        }
    }
}
