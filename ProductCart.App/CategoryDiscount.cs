using System.Collections.Generic;

namespace ProductCart.App
{
    public class CategoryDiscount : IDiscount
    {
        private Dictionary<Category, double> _categoryDiscountValues = new Dictionary<Category, double>()
        {
            {Category.Dairy, 15 },
            {Category.Educational, 10 },
            {Category.Grocery, 12 }
        };
        
        public double ApplyDiscount(Cart cart)
        {
            double discountedAmount = 0;
            for(int i=0; i<cart.CartProducts.Count; i++)
            {
                discountedAmount += (cart.CartProducts[i].CumulativeProductCost * (_categoryDiscountValues.GetValueOrDefault(cart.CartProducts[i].Product.Category)/100));
            }
            return discountedAmount;
        }
    }
}
