using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Home_task8.Comparers
{
    class FullNameLenghtComparer : IComparer<DevEmployee>
    {
        public int Compare( DevEmployee x, DevEmployee y)
        {
            int xLength = x.FirstName.Length + x.LastName.Length;
            int yLength = y.FirstName.Length + y.LastName.Length;    


            if (xLength > yLength)
            {
                return 1;
            }
            else if (xLength == yLength)
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
