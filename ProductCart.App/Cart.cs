using System.Collections.Generic;
using System.Linq;

namespace ProductCart.App
{
    public class Cart
    {
        private List<CartItem> _cartProducts = new List<CartItem>();
        
        public void AddNewProductToList(CartItem cartItem)
        {
            _cartProducts.Add(cartItem);
        }

        public bool CheckIfAlreadyInCart(Product product)
        {
            for (int i = 0; i < _cartProducts.Count; i++)
            {
                if (_cartProducts[i].Product == product)
                {
                    return true;
                }
            }
            return false;
        }

        public List<CartItem> GetCartProductsList()
        {
            return _cartProducts;
        }

        public double GetTotalCartPrice()
        {
            double totalCartPrice = 0;
            for(int i=0; i<_cartProducts.Count; i++)
            {
                totalCartPrice += _cartProducts.ElementAt(i).CumulativeProductCost;
            }
            return totalCartPrice;
        }
    }
}
