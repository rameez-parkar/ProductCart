namespace ProductCart.App
{
    public class Product
    {        
        public string ProductName { get; private set; }
        public double Price { get; private set; }
        public Category Category { get; private set; }

        public Product(string productName, double price, Category category)
        {
            this.ProductName = productName;
            if (this.Price >= 0)
                this.Price = price;
            else
                throw new NegativePriceException();
            this.Category = category;
        }
    }
}
