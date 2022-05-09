using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task7
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TaxID { get; set; }
        public abstract string ToString();
        //{
        //  //  return "Basic method";
        //    //return FirstName + " " + LastName + " " + TaxID;
        //}
    }
}
  