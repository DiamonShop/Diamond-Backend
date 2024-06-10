using DiamondShop.Data;
using DiamondShop.Model;

public class ShoppingCartViewModel
{
    public int CartId { get; set; }
    public int UserId { get; set; }

    public List<CartItemModel>? CartItems { get; set; }
}