using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task8
{

    abstract class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int TaxId { get; private set; }

        public Employee() {}
            public Employee (string firstName, string lastName, int taxId)
            {
            FirstName = firstName;
            LastName = lastName;
            TaxId = taxId;
            }
            
        }
    
}
