using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class DevEmployee: Employee, ICoder
    {
        public string ProgrammingLanguage { get; set; }
        public override string ToString()
        {
            return "Hello from Devs!";
        }

        public virtual string WriteCode()
        {
            return "Code is written: from Dev";
        }
    }
}
