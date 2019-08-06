namespace ProductCart.App
{
    public interface ICart
    {
        string AddToCart(string productName, int quantity);
        double GetTotalPrice();
    }
}
