using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.DiscountSystem.BreakOpenClose
{
    public class PercentageDiscountCalculator
    {
        public double Calculate(double originalPrice,double percentage)
        {
            return originalPrice * (percentage / 100);
        }
    }
    public class FixedAmountDiscountCalculator
    {
        public double Calculate(double originalPrice, double amount)
        {
            return amount;
        }
    }
}
