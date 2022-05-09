using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Home_task8
{
   
    class DevEmployee : Employee, IComparable<DevEmployee>
    {
        public string ProgrammingLanguage { get; set; }

        //public DevEmployee() : base("i", "p", 123)
        //{
        //}

        public DevEmployee(string firstName, string lastName, int taxId, string language) : base(firstName, lastName, taxId)
        {
            ProgrammingLanguage = language;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + TaxId + " " + ProgrammingLanguage;
        }

        public int CompareTo( DevEmployee other)
        {
            if (this.FirstName[0] > other.FirstName[0])
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /* public int CompareTo([AllowNull] DevEmployee other) //объяснение, как сортировать
         {
             if (this.FirstName[0] > other.FirstName[0])
             { 
                 return 1;
             }
             else
             {
                 return -1;
             }
         }*/
    }
}
