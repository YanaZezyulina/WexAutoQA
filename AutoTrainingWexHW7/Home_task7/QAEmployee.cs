using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class QAEmployee: Employee
    {
        public string Specialization{ get; set; }
        public override string ToString()
        {
            return "Hi from QA";
        }
    }
}
