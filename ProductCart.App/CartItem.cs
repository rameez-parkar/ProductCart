using System.Collections.Generic;

namespace ProductCart.App
{
    public class CartItem
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double CumulativeProductCost { get; private set; }

        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.CumulativeProductCost = this.SetCumulativeProductCost(this.Product, this.Quantity);
        }

        public double SetCumulativeProductCost(Product product, int quantity)
        {
            this.CumulativeProductCost = product.Price * quantity;
            return this.CumulativeProductCost;
        }

        public void ChangeQuantity(int quantity)
        {
            this.Quantity += quantity;
        }
    }
}
