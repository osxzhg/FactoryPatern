using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PermanentEmployServiceFactory : IEmployServiceFactory
    {
        public IEmployeeService Create()
        {
            PermanentEmployService pEmployeeService = new PermanentEmployService();
            return pEmployeeService;
        }
    }
}
