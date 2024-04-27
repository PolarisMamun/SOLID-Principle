using System;
using Single_Responsibility_Principle.Refactor;

namespace Single_Responsibility_Principle
{
    public class Program
    {
        /*Single Responsibility Principle (SRP):
         * Problem: 
           Imagine you have a class called Employee which is responsible for both handling employee data
           and calculating their payroll. How would you refactor this class to adhere to the 
           Single Responsibility Principle?
         */
        /*static void Main(string[] args)
        {
            EmployeeDataAndCalculatingTheirPayroll employeeData = new EmployeeDataAndCalculatingTheirPayroll
            (1,"Mamun",7500.00m);

            decimal payroll = employeeData.CalculateSalary();

            Console.WriteLine($"Payroll for {employeeData.Name} (Employee Id {employeeData.Id}) : Employee Salary {employeeData.Salary}");

            Console.ReadLine();
        }*/

        static void Main(string[] args)
        {
            Employee employee = new Employee(4, "Munsi", 7500.00m);
            EmployeePayroll employeePayroll = new EmployeePayroll();

            decimal payroll = employeePayroll.CaculatePayroll(employee);

            Console.WriteLine($"Payroll for {employee.Name} (Employee Id : {employee.Id} and Employee Salary: {employee.Salary})");
            Console.WriteLine();
        }
    }
}
