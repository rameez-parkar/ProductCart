using System.Collections.Generic;

namespace ProductCart.App
{
    public class Product
    {
        //Products and their prices stored in the form of key-value pair
        public Dictionary<string, double> ProductPricesMapper = new Dictionary<string, double>()
        {
            {"Milk", 22.00},
            {"Bread", 35.00},
            {"Cheese", 15.00}
        };
    }
}
