using System.Collections.Generic;

namespace ProductCart.App
{
    public class Discount
    {
        private DiscountFactory _discountFactory = new DiscountFactory();
        private DiscountTask _discountTask;
        private bool isDiscountApplied = false;
        private double _discountedAmount = 0;

        public void ApplyDiscount(string discountType, Cart cart)
        {
            if (!(isDiscountApplied))
            {
                _discountTask = new DiscountTask(_discountFactory.GetDiscount(discountType));
                isDiscountApplied = true;
                _discountedAmount = _discountTask.GetDiscount(cart);
            }
        }

        public double GetDiscountAmount()
        {
            return _discountedAmount;
        }
    }
}
