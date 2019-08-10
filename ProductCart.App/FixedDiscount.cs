using System.Collections.Generic;

namespace ProductCart.App
{
    public class FixedDiscount : IDiscount
    {
        private readonly double discountPercentage = 20;

        public double ApplyDiscount(Cart cart)
        {
            double discountedAmount = 0;
            discountedAmount = cart.GetTotalCartPrice() * (discountPercentage / 100);
            return discountedAmount;
        }
    }
}
