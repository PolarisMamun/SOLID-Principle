using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.Refactor
{
    public class EmployeePayroll
    {
        public decimal CaculatePayroll(Employee employee)
        {
            return employee.Salary;
        }
    }
}
