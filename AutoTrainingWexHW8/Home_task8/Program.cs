using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using Home_task8.Comparers;

namespace Home_task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> list = new MyList<int>();
            //list.Add(new MyNode<int>(5));
            //list.Add(new MyNode<int>(3));

            //MyList<float> listFloat = new MyList<float>();
            //listFloat.Add(new MyNode<float>(5f));
            //listFloat.Add(new MyNode<float>(3f));

            ITOffice issoft = new ITOffice();

            //Employee employee1 = new DevEmployee("p", "s", 111, "c");

            //List<int> taxId = new List<int>();

            //taxId.Add(5);
            //taxId.Add(3);
            //taxId.Add(-1);
            //foreach (int item in taxId)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            issoft.Employees.Add(new DevEmployee("Ivan", "Petrov", 123, "c++"));
            issoft.Employees.Add(new DevEmployee("Vasily", "Ivanov", 741, "c"));
            issoft.Employees.Add(new DevEmployee("Sergey", "Sidorov", 852, "JavaScript"));
            issoft.Employees.Add(new DevEmployee("Semen", "Vasnetsov", 159, "PHP"));

            int choiseRedult = 2;
            IComparer<DevEmployee> comparer = null;

            switch (choiseRedult)
            {
                case 1:
                    comparer = new FirstNameComparer();
                    break;
                case 2:
                    comparer = new TaxIdComparer();
                    break;
                default:
                    comparer = new FullNameLenghtComparer();
                    break;
            }

            issoft.Employees.Sort(comparer);
            //issoft.Employees.Sort(new FirstNameComparer());
            //issoft.Employees.Sort(new TaxIdComparer());
            //issoft.Employees.Sort(new FullNameLenghtComparer());

            foreach (Employee employee in issoft.Employees)
            {
                Console.WriteLine(employee.ToString());
            }
          

        } 
    }
}
