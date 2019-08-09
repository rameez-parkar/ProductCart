namespace ProductCart.App
{
    public class Product
    {        
        public string _productName { get; private set; }
        private double _price;
        private Category _category;

        public Product(string productName, double price, Category category)
        {
            this._productName = productName;
            if (this._price >= 0)
                this._price = price;
            else
                throw new NegativePriceException();
            this._category = category;
        }

        public string GetProductName()
        {
            return this._productName;
        }

        public double GetProductPrice()
        {
            return this._price;
        }

        public Category GetProductCategory()
        {
            return this._category;
        }
    }
}
