using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class EmployeeService
    {
        private readonly Employee _emp;

        public EmployeeService(Employee emp)
        {
            _emp = emp;
        }
        public IEmployeeService Create()
        {
            if (_emp.EmployeeTypeID == 1)
            {
                 return new PermanentEmployServiceFactory().Create();
            }
            else if (_emp.EmployeeTypeID == 2)
            {
                return new ContraceEmployeeSeriviceFactory().Create();
            }
            return null;
 
        }
        public void ApplySalary()
        {
          IEmployeeService _service=null;
            _service = Create();
            _emp.Bonus = _service.GetBonus();
            _emp.HourlyPay = _service.GetPay();
            if(_service is PermanentEmployService ps)
            {
                _emp.HouseAllowance = ps.GetHouseAllowance();
            }
            if (_service is ContractEmployeeService cs)
            {
                _emp.HouseAllowance = cs.GetMedicalAllowance();
            }

        }
    }
}
