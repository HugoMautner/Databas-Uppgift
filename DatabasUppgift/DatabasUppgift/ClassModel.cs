﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasUppgift
{
    class ClassModel
    {
        public string name { get; private set; }
        public int teacher_id { get; private set; }

        public ClassModel(string name, int teacher_id)
        {
            this.name = name;
            this.teacher_id = teacher_id;
        }
        public ClassModel()
        {

        }
    }
}
