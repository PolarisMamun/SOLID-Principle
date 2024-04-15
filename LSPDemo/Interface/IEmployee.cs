﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Interface
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
