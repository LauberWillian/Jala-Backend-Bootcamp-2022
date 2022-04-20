namespace Shop.API.Models;

public class ShoppingCart
{
    List<Product> products = new List<Product>();
    public void removeFromStock(ShopItem item)
    {
        //remove from stock logic
    }
        
    public void getTotalPrice(CurrencyType currency)
    {
        //get total price logic
    }
    public int getItemCount()
    {
        return products.Count;
    }
}