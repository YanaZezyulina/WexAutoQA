using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class DevTeamLead: DevEmployee, ITaskAssigner, IReviewer, ICoder
    {
        public string AssignTask()
        {
            return "Dev task is assigned!";
        }

        public string GetCodeReview()
        {
            return "Code review is done! (Dev TL)";
        }
        public override string WriteCode()
        {
            return "Code is written: from Dev TeamLead";
        }
    }
}
