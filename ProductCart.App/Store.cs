using System.Collections.Generic;

namespace ProductCart.App
{
    public class Store
    {
        private ProductList _productList = new ProductList();
        
        public void AddProductToList(Product product)
        {
            if (!(_productList.AvailableProductList.Contains(product)))
            {
                _productList.AddProduct(product);
            }
        }

        public List<Product> ReadProductList()
        {
            return _productList.AvailableProductList;
        }
    }
}
