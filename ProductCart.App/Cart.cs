using System.Collections.Generic;

namespace ProductCart.App
{
    public class Cart : ICart
    {
        private CartItem _cartItem;
        public Dictionary<string, double> CartItems= new Dictionary<string, double>();

        public Cart()
        {
            _cartItem = new CartItem();
        }

        //Adds product to cart, and accepts ProductName and quantity as parameters 
        public string AddToCart(string productName, int quantity)
        {
            bool isProductAvailable = _cartItem.CalculateProductTotalCost(productName, quantity);
            if(isProductAvailable)
            {
                CartItems.Add(productName, _cartItem.ProductTotalCost);
                return $"{quantity} quantities of {productName} added to Cart.";
            }
            else
            {
                return $"{productName} not available.";
            }
        }

        //Calculates the total cost of all products in the cart without discount
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach(string product in CartItems.Keys)
            {
                totalPrice += CartItems.GetValueOrDefault(product);
            }
            return totalPrice;
        }

        //Calculates the discount amount on the total cost depending on Discount Percentage
        public double GetTotalDiscount(double discountPercentage)
        {
            double totalPrice = GetTotalPrice();
            double totalDiscount = (discountPercentage / 100) * totalPrice;
            return totalDiscount;
        }

        //Calculates Final Amount to be paid after Discount
        public double GetFinalDiscountedAmount(double discountPercentage)
        {
            double totalPrice = GetTotalPrice();
            double totalDiscount = GetTotalDiscount(discountPercentage);
            double finalAmount = totalPrice - totalDiscount;
            return finalAmount;
        }
    }
}
