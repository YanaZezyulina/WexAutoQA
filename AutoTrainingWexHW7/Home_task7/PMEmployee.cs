using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class PMEmployee : Employee, ITaskAssigner
    {
        public override string ToString()
        {
            return "Hi from PM";
        }
        public string AssignTask()
        {
            return "PM task is assigned!";
        }
    }
}
