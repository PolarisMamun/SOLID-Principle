using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.DiscountSystem.FollowOpenClose
{
    /// <summary>
    /// Here Following Open Close Principle
    /// </summary>
    public abstract class DiscountBase
    {
        public abstract double CalculateDiscount(double originalPrice);
    }

    /*public class FixedAmountDiscount : DiscountBase
    {
        public double _amount; 
        public FixedAmountDiscount(double amount)
        {
            _amount = amount;
        }
        public override double CalculateDiscount(double originalPrice)
        {
            return _amount;
        }
    }
    public class PercentageDiscount : DiscountBase
    {
        private double _percentage;
        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }
        public override double CalculateDiscount(double originalPrice)
        {
            return originalPrice * (_percentage / 100);
        }
    }*/
}
