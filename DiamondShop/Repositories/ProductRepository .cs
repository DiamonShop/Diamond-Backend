using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using FAMS.Entities.Data;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DiamondDbContext _context;

        public ProductRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryName(string categoryName)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Where(p => p.Category.CategoryName == categoryName)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByName(string productName)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Where(p => p.ProductName.Contains(productName))
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByFirstLetter(char letter)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Where(p => p.ProductName.StartsWith(letter.ToString()))
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByPriceDesc()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .OrderByDescending(p => p.Price)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByPriceAsc()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .OrderBy(p => p.Price)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsBySimilarName(string keyword)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Where(p => p.ProductName.Contains(keyword))
                .ToListAsync();
        }
    }
}
