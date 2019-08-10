using System.Collections.Generic;
using System.Linq;

namespace ProductCart.App
{
    public class Cart
    {
        public List<CartItem> CartProducts { get; private set; } = new List<CartItem>();
        
        public void AddNewProductToList(CartItem cartItem)
        {
            CartProducts.Add(cartItem);
        }

        public bool CheckIfAlreadyInCart(Product product)
        {
            for (int i = 0; i < CartProducts.Count; i++)
            {
                if (CartProducts[i].Product == product)
                {
                    return true;
                }
            }
            return false;
        }

        public double GetTotalCartPrice()
        {
            double totalCartPrice = 0;
            for(int i=0; i<CartProducts.Count; i++)
            {
                totalCartPrice += CartProducts[i].CumulativeProductCost;
            }
            return totalCartPrice;
        }
    }
}
