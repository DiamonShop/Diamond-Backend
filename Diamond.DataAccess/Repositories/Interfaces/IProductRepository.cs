using DiamondShop.Data;
using DiamondShop.Model;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductViewModel>> GetAllProducts();
        Task<ProductViewModel> GetProductById(int id);
        Task<List<ProductViewModel>> GetProductsByCategoryName(string categoryName);
        Task<List<ProductViewModel>> GetProductsByName(string productName);
        Task<List<ProductViewModel>> GetProductsByPriceDesc();
        Task<List<ProductViewModel>> GetProductsByPriceAsc();
        Task<bool> CreateProduct(ProductViewModel productModel);
        Task<bool> UpdateProduct(int id, ProductViewModel productModel);
        Task<bool> DeleteProduct(int id);
        Task<List<ProductViewModel>> GetProductsBySimilarName(string keyword);
    }
}
