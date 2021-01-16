using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
        public int EmployeeTypeID { get; set; }
        public decimal? HouseAllowance { get; set; }
        public decimal? MedicalAllowance { get; set; }
    }
}
