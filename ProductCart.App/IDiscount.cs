using System.Collections.Generic;

namespace ProductCart.App
{
    public interface IDiscount
    {
        double ApplyDiscount(Cart cart);
    }
}
