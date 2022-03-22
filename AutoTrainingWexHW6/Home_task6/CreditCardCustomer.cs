using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task6
{
    class CreditCardCustomer: Customer
    {
        public override string GetCustomerInfo()
        {
            return String.Format("Payment method - Credit card");
        }
    }
}
