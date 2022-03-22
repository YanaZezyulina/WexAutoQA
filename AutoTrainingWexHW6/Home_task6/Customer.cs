using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task6
{
    abstract class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string GetCustomerInfo();
        //{
        //    return String.Format("First name: {0}, Last name: {1}", FirstName, LastName);
        //}
}
}
