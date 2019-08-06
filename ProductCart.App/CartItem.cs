using System.Collections.Generic;

namespace ProductCart.App
{
    public class CartItem
    {
        private Product _product;
        private string _productName { get; set; }
        private int _quantity;
        public double ProductTotalCost = 0;

        public CartItem()
        {
            _product = new Product();
        }

        //Calculates the total cost of a product based on its quantity, and returns boolean value depicting whether product is present or not.
        public bool CalculateProductTotalCost(string productName, int quantity)
        {
            _productName = productName;
            _quantity = quantity;
            if(_product.ProductPricesMapper.ContainsKey(_productName))
            {
                ProductTotalCost = _product.ProductPricesMapper.GetValueOrDefault(_productName) * quantity;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
