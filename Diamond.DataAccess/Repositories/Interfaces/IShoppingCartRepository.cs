using DiamondShop.Data;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IShoppingCartRepository
    {
        public Task<List<ShoppingCartViewModel>> GetAll();
		public Task<ShoppingCartViewModel> GetById(int id);
		public Task<bool> CreateCart(ShoppingCartViewModel cartModel);
		public Task<bool> UpdateCart(ShoppingCartViewModel cartModel);
        public Task<bool> DeleteCart(int id);
    }
}
