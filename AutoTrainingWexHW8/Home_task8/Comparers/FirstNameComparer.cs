using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Home_task8.Comparers
{
    class FirstNameComparer : IComparer<DevEmployee>
    {
        public int Compare(DevEmployee x, DevEmployee y)
        {
            if (x.FirstName[0] > y.FirstName[0])
            {
                return 1;
            }
            else if (x.FirstName[0] == y.FirstName[0])
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
