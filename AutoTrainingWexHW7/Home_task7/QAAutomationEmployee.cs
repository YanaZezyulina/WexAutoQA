using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class QAAutomationEmployee:Employee, ICoder
    {
        public override string ToString()
        {
            return "Hi from QAAuto";
        }

        public virtual string WriteCode()
        {
            return "Code is written: from QA Auto";
        }
    }
}
