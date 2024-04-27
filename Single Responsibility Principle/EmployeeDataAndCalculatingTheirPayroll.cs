using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    /*a class called Employee which is responsible for both handling employee data and calculating their payroll. */
    public class EmployeeDataAndCalculatingTheirPayroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public EmployeeDataAndCalculatingTheirPayroll(int id,string name, decimal salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public decimal CalculateSalary()
        {
            return Salary;
        }
    }
}
