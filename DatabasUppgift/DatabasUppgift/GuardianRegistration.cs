using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasUppgift
{
    class GuardianRegistration
    {
        public int reg_number { get; private set; }

        public int student_id { get; private set; }

        public int guardian_id { get; private set; }

        public GuardianRegistration(int reg_number, int student_id, int guardian_id)
        {
            this.reg_number = reg_number;
            this.student_id = student_id;
            this.guardian_id = guardian_id;
        }
        public GuardianRegistration()
        {

        }
    }
}
