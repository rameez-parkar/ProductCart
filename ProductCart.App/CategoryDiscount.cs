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
            for(int i=0; i<cart.GetCartProductsList().Count; i++)
            {
                discountedAmount += (cart.GetCartProductsList()[i].CumulativeProductCost * (_categoryDiscountValues.GetValueOrDefault(cart.GetCartProductsList()[i].Product.GetProductCategory())/100));
            }
            return discountedAmount;
        }
    }
}
