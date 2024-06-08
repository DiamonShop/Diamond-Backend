using DiamondShop.Data;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryName(string categoryName);
        Task<IEnumerable<Product>> GetProductsByName(string productName);
        Task<IEnumerable<Product>> GetProductsByFirstLetter(char letter);
        Task<IEnumerable<Product>> GetProductsByPriceDesc();
        Task<IEnumerable<Product>> GetProductsByPriceAsc();
        Task<IEnumerable<Product>> GetProductsBySimilarName(string keyword);
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}
