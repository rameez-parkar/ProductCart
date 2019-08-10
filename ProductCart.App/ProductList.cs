using System.Collections.Generic;

namespace ProductCart.App
{
    public class ProductList
    {
        public List<Product> AvailableProductList { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            AvailableProductList.Add(product);
        }
    }
}
