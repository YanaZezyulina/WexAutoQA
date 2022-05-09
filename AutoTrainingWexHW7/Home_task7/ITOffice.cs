using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    class ITOffice
    {
        List<Employee> _employees;
        public List<Employee> Employees {
            get
            {
                return _employees;
            }
        }

        public ITOffice()
        {
            _employees = new List<Employee>();
        }
    }
}
