using System;
using LSPDemo.Abstract;
using LSPDemo.Interface;

namespace LSPDemo.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployee()
        {

        }
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
