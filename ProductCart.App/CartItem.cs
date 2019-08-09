using System.Collections.Generic;

namespace ProductCart.App
{
    public class CartItem
    {
        public Product Product;
        public int Quantity;
        public double CumulativeProductCost;

        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.CumulativeProductCost = this.GetCumulativeProductCost(this.Product, this.Quantity);
        }

        //Calculates the total cost of a product based on its quantity, and returns boolean value depicting whether product is present or not.
        public double GetCumulativeProductCost(Product product, int quantity)
        {
            return (product.GetProductPrice() * quantity);
        }
    }
}
