using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.DiscountSystem.FollowOpenClose
{
    public class PercentageDiscount : DiscountBase
    {
        private double percentage;
        public PercentageDiscount(double percentage)
        {
            this.percentage = percentage;
        }
        public override double CalculateDiscount(double originalPrice)
        {
            return originalPrice * (percentage / 100);
        }
    }
}
