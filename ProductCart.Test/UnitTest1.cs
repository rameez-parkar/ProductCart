using ProductCart.App;
using System;
using System.Collections.Generic;
using Xunit;

namespace ProductCart.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Adding_Products_To_Store()
        {
            Product milk, notebook, sugar;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);

            var expected = new List<Product>(){ milk, notebook, sugar };
            var actual = store.ReadProductList();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Adding_Unavailable_Item_To_Cart()
        {
            Product milk, notebook, sugar;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);

            var expected = new List<CartItem>() { new CartItem(milk, 3), new CartItem(notebook, 1) };
            var actual = customer.ReadCartProductsList();

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void Adding_Available_Item_To_Cart()
        {
            Product milk, notebook, sugar;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);

            var expected = new List<CartItem>() { new CartItem(milk, 5), new CartItem(notebook, 2) };
            var actual = customer.ReadCartProductsList();

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void Get_Total_Cost_For_Items_In_Cart()
        {
            Product milk, notebook, sugar;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);

            var expected = 190.00;
            var actual = customer.GetTotalPrice();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Get_Category_Discount_Amount_For_Items_In_Cart()
        {
            Product milk, notebook, sugar, pen;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            pen = new Product("Pen", 10.00, Category.Educational);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);
            store.AddProductToList(pen);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(sugar, 2);
            customer.AddProductToCart(pen, 3);

            customer.ApplyDiscount("CATEGORYWISE");

            var expected = 35.96;
            var actual = customer.GetDiscountPrice();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Get_Fixed_Discount_Amount_For_Items_In_Cart()
        {
            Product milk, notebook, sugar, pen;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            pen = new Product("Pen", 10.00, Category.Educational);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);
            store.AddProductToList(pen);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(sugar, 2);
            customer.AddProductToCart(pen, 3);

            customer.ApplyDiscount("FIXED");

            var expected = 58.1;
            var actual = customer.GetDiscountPrice();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Get_No_Discount_Amount_For_Items_In_Cart()
        {
            Product milk, notebook, sugar, pen;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            pen = new Product("Pen", 10.00, Category.Educational);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);
            store.AddProductToList(pen);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(sugar, 2);
            customer.AddProductToCart(pen, 3);

            var expected = 0;
            var actual = customer.GetDiscountPrice();

            Assert.Equal(expected, actual, 2);
        }
        
        [Fact]
        public void Get_Final_Discounted_Amount_For_Items_In_Cart_With_Fixed_Discount()
        {
            Product milk, notebook, sugar, pen;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            pen = new Product("Pen", 10.00, Category.Educational);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);
            store.AddProductToList(pen);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(sugar, 2);
            customer.AddProductToCart(pen, 3);

            customer.ApplyDiscount("FIXED");

            var expected = 232.4;
            var actual = customer.GetFinalPriceAfterDiscount();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Get_Final_Discounted_Amount_For_Items_In_Cart_With_Category_Discount()
        {
            Product milk, notebook, sugar, pen;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            pen = new Product("Pen", 10.00, Category.Educational);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);
            store.AddProductToList(pen);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(sugar, 2);
            customer.AddProductToCart(pen, 3);

            customer.ApplyDiscount("CATEGORYWISE");

            var expected = 254.54;
            var actual = customer.GetFinalPriceAfterDiscount();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Get_Final_Discounted_Amount_For_Items_In_Cart_With_No_Discount()
        {
            Product milk, notebook, sugar, pen;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            pen = new Product("Pen", 10.00, Category.Educational);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);
            store.AddProductToList(pen);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(sugar, 2);
            customer.AddProductToCart(pen, 3);

            var expected = 290.5;
            var actual = customer.GetFinalPriceAfterDiscount();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Trying_To_Apply_Multiple_Discounts()
        {
            Product milk, notebook, sugar, pen;
            Store store = new Store();

            milk = new Product("Milk", 22.00, Category.Dairy);
            notebook = new Product("Notebook", 40.00, Category.Educational);
            sugar = new Product("Sugar", 35.25, Category.Grocery);
            pen = new Product("Pen", 10.00, Category.Educational);
            store.AddProductToList(milk);
            store.AddProductToList(notebook);
            store.AddProductToList(sugar);
            store.AddProductToList(pen);

            Customer customer = new Customer();
            customer.AddProductToCart(milk, 3);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(milk, 2);
            customer.AddProductToCart(notebook, 1);
            customer.AddProductToCart(sugar, 2);
            customer.AddProductToCart(pen, 3);

            customer.ApplyDiscount("FIXED");
            customer.ApplyDiscount("CATEGORYWISE");

            var expected = 232.4;
            var actual = customer.GetFinalPriceAfterDiscount();

            Assert.Equal(expected, actual, 2);
        }
    }
}
