using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Home_task8.Comparers
{
    class TaxIdComparer : IComparer<DevEmployee>
    {
        public int Compare( DevEmployee x, DevEmployee y)
        {
            if (x.TaxId > y.TaxId)
            {
                return 1;
            }
            else if (x.TaxId == y.TaxId)
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
