using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new Employee();
            employeeA.Id = 1;
            employeeA.Name = "Nick";
            employeeA.Number = "601";
            employeeA.Department = "Computer";
            employeeA.EmployeeTypeID = 1;
            var employeeSevice = new EmployeeService(employeeA);
            employeeSevice.ApplySalary();
            Employee employee = new Employee();
            employee.Id = 2;
            employee.Name = "Hans";
            employee.Number = "602";
            employee.Department = "Math";
            employee.EmployeeTypeID = 2;
            employeeSevice = new EmployeeService(employee);
            employeeSevice.ApplySalary();
        }
    }
}
