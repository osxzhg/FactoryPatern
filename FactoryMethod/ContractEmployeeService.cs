using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ContractEmployeeService : IEmployeeService
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }

        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}
