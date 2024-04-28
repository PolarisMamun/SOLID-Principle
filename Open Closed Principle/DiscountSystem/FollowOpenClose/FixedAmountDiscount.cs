using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.DiscountSystem.FollowOpenClose
{
    public class FixedAmountDiscount : DiscountBase
    {
        private double amount;
        public FixedAmountDiscount(double amount)
        {
            this.amount = amount;
        }
        public override double CalculateDiscount(double originalPrice)
        {
            return amount;
        }
    }
}
