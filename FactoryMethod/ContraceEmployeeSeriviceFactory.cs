using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ContraceEmployeeSeriviceFactory : IEmployServiceFactory
    {
        public IEmployeeService Create()
        {
            ContractEmployeeService pEmployeeService = new ContractEmployeeService();
            return pEmployeeService;
        }
    }
}
