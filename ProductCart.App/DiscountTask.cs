using System.Collections.Generic;

namespace ProductCart.App
{
    public class DiscountTask
    {
        private IDiscount _discountType;

        public DiscountTask(IDiscount discountType)
        {
            _discountType = discountType;
        }

        public double GetDiscount(Cart cart)
        {
            return _discountType.ApplyDiscount(cart);
        }
    }
}
