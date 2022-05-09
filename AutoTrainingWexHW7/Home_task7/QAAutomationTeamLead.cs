using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class QAAutomationTeamLead: QAAutomationEmployee, ITaskAssigner, IReviewer, ICoder
    {
        public string AssignTask()
        {
            return "QA Auto task is assigned!";
        }

        public string GetCodeReview()
        {
            return "Code review is done! (QA Auto TL)";
        }
        public override string WriteCode()
        {
            return "Code is written: from QA Auto TeamLead";
        }
    }
}
