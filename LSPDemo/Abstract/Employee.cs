﻿using LSPDemo.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Abstract
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        /*public int ID { get; set; }
         public string Name { get; set; }
        */

        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            ID = id;
            Name = name;

        }
        //public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", ID, Name);
        }

        public abstract decimal GetMinimumSalary();
        

        public abstract decimal CalculateBonus(decimal salary);
        
    }
}
