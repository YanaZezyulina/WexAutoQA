using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class QATeamLead: QAEmployee, ITaskAssigner
    {
        public string AssignTask()
        {
            return "QA task is assigned!";
        }
    }
}
