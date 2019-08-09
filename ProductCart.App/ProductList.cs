using System.Collections.Generic;

namespace ProductCart.App
{
    public class ProductList
    {
        private List<Product> _productList = new List<Product>();

        public void AddProduct(Product product)
        {
            _productList.Add(product);
        }
        public List<Product> GetProductList()
        {
            return _productList;
        }
    }
}
