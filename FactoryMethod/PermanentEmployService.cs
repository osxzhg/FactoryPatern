using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PermanentEmployService : IEmployeeService
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }

        public decimal GetHouseAllowance()
        {
            return 15;
        }
    }
}
