using System;

namespace Home_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new CashCustomer();
            Customer customer2 = new CashCustomer();
            Customer customer3 = new CreditCardCustomer();
            Customer customer4 = new DebitCardCustomer();
            Customer customer5 = new CreditCardCustomer();
            Customer[] customers = { customer1, customer2, customer3, customer4, customer5 };

            foreach (Customer item in customers)
            {
               Console.WriteLine(item.GetCustomerInfo());
            }

        }
    }
}
