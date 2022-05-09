using System;

namespace Home_task7
{
    class Program
    {
        static void Main(string[] args)
        {

            ITOffice issoft = new ITOffice();
            issoft.Employees.Add(new DevEmployee());
            issoft.Employees.Add(new QAEmployee());
            issoft.Employees.Add(new BAEmployee());
            issoft.Employees.Add(new DevEmployee());
            issoft.Employees.Add(new DevEmployee());
            issoft.Employees.Add(new DevTeamLead());
            issoft.Employees.Add(new QATeamLead());
            issoft.Employees.Add(new QAAutomationTeamLead());
            issoft.Employees.Add(new PMEmployee());
            issoft.Employees.Add(new DevTeamLead());
            issoft.Employees.Add(new QAAutomationEmployee());


            //foreach (Employee employee in issoft.Employees)
            //{
            //    Console.WriteLine(employee.ToString());
            //}

            foreach (Employee employee in issoft.Employees)
            {
                if (employee is ITaskAssigner)
                {
                    Console.WriteLine((employee as ITaskAssigner).AssignTask());
                   // break;                   
                }
               
            }
            foreach (Employee employee in issoft.Employees)
            {
                if (employee is ICoder)
                {
                    Console.WriteLine((employee as ICoder).WriteCode());
                    //break;
                }
            }
            foreach (Employee employee in issoft.Employees)
            {
                if (employee is IReviewer)
                {
                    Console.WriteLine((employee as IReviewer).GetCodeReview());
                    //break;
                }
            }
        }
    }
}
