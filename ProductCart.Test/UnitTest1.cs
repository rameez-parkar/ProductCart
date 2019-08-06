using ProductCart.App;
using System;
using Xunit;

namespace ProductCart.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Adding_Available_Item_To_Cart()
        {
            Cart cart = new Cart();
            string productName = "Milk";
            int quantity = 3;

            var expected = "3 quantities of Milk added to Cart.";
            var actual = cart.AddToCart(productName, quantity);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Adding_Unavailable_Item_To_Cart()
        {
            Cart cart = new Cart();
            string productName = "Biscuit";
            int quantity = 5;

            var expected = "Biscuit not available.";
            var actual = cart.AddToCart(productName, quantity);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Get_Total_Cost_For_Items_In_Cart()
        {
            Cart cart = new Cart();
            var message = "";

            message = cart.AddToCart("Cheese", 3);
            message = cart.AddToCart("Biscuit", 1);
            message = cart.AddToCart("Bread", 2);

            var expected = 115.00;
            var actual = cart.GetTotalPrice();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Get_Total_Discount_For_Items_In_Cart()
        {
            Cart cart = new Cart();
            var message = "";
            var discountPercentage = 15.00;

            message = cart.AddToCart("Cheese", 3);
            message = cart.AddToCart("Biscuit", 1);
            message = cart.AddToCart("Bread", 2);

            var expected = 17.25;
            var actual = cart.GetTotalDiscount(discountPercentage);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Get_Final_Discounted_Amount_For_Items_In_Cart()
        {
            Cart cart = new Cart();
            var message = "";
            var discountPercentage = 15.00;

            message = cart.AddToCart("Cheese", 3);
            message = cart.AddToCart("Biscuit", 1);
            message = cart.AddToCart("Bread", 2);

            var expected = 97.75;
            var actual = cart.GetFinalDiscountedAmount(discountPercentage);

            Assert.Equal(expected, actual, 2);
        }
    }
}
