namespace Shop.API.Models;

public class ShopItem
{
    private readonly Product product;
    private int quantity = 0;

    public ShopItem(Product product, int quantity)
    {
        this.product = product;
        this.quantity = quantity;
    }
        
    public int IncrementQunatity()
    {
        this.quantity++;
        return quantity;
    }
}