using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task8
{
    //class ITOffice
    //{
    //    List<Employee> _employees;
    //    public List<Employee> Employees
    //    {
    //        get
    //        {
    //            return _employees;
    //        }
    //    }

    //    public ITOffice()
    //    {
    //        _employees = new List<Employee>();
    //    }
    //}
    class ITOffice: ICloneable
    {
        List<DevEmployee> _employees;
        public List<DevEmployee> Employees
        {
            get
            {
                return _employees;
                    }
        }
        public ITOffice()
        {
            _employees = new List<DevEmployee>();
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

    }
}
