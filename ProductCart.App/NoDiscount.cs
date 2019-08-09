using System.Collections.Generic;

namespace ProductCart.App
{
    public class NoDiscount : IDiscount
    {
        public double ApplyDiscount(Cart cart)
        {
            double discountedAmount = 0;
            return discountedAmount;
        }
    }
}
