using DiamondShop.Data;
using DiamondShop.Model;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductViewModel>> GetAllProducts();
        Task<ProductViewModel> GetProductById(string id);
        Task<List<ProductViewModel>> GetProductsByCategoryName(string categoryName);
        Task<List<ProductViewModel>> GetProductsByName(string productName);
        Task<List<ProductViewModel>> GetProductsByPriceDesc();
        Task<List<ProductViewModel>> GetProductsByPriceAsc();
        Task<bool> CreateProduct(ProductViewModel productModel);
        Task<bool> UpdateProduct(string id, ProductViewModel productModel);
        Task<bool> DeleteProduct(string id);
        Task<bool> UpdateMarkupRate(string productId, int newMarkupRate);
    }
}
