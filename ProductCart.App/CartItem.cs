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

        private double GetCumulativeProductCost(Product product, int quantity)
        {
            return (product.GetProductPrice() * quantity);
        }
    }
}
