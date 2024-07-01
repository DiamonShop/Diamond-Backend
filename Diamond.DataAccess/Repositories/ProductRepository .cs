using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace DiamondShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DiamondDbContext _context;

        public ProductRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductViewModel>> GetAllProducts()
        {
            var productList = await _context.Products.ToListAsync();

            if (productList == null) { return null; }

            var productModels = productList.Select(p => new ProductViewModel
            {
                ProductId = p.ProductId,
                CategoryId = p.CategoryId,
                JewelrySettingID = p.JewelrySettingID,
                MarkupRate = p.MarkupRate,
                Description = p.Description,
                BasePrice = p.BasePrice,
                IsActive = p.IsActive,
                Stock = p.Stock,
                ProductName = p.ProductName
            }).ToList();

            return productModels;
        }

        public async Task<ProductViewModel> GetProductById(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId.Equals(id));

            if (product == null) { return null; }

            var productModel = new ProductViewModel()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                Description = product.Description,
                BasePrice = product.BasePrice,
                JewelrySettingID = product.JewelrySettingID,
                MarkupRate = product.MarkupRate,
                IsActive = product.IsActive,
                Stock = product.Stock,
                ProductName = product.ProductName
            };

            return productModel;
        }

        public async Task<List<ProductViewModel>> GetProductsByCategoryName(string categoryName)
        {
            var productList = await _context.Products
                .Where(p => p.Category.CategoryName.Contains(categoryName)) //Tìm gần đúng
                .ToListAsync();

            if (productList == null) { return null; }

            var productModel = productList.Select(product => new ProductViewModel
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                JewelrySettingID= product.JewelrySettingID,
                MarkupRate = product.MarkupRate,
                Description = product.Description,
                BasePrice = product.BasePrice,
                IsActive = product.IsActive,
                Stock = product.Stock,
                ProductName = product.ProductName
            }).ToList();

            return productModel;
        }

        public async Task<List<ProductViewModel>> GetProductsByName(string productName)
        {
            if (productName.IsNullOrEmpty())
            {
                return null;
            }

            string productNameLowerCase = productName.ToLower();

            var productList = await _context.Products
                .Where(p => p.ProductName.ToLower().Contains(productNameLowerCase)) 
                .ToListAsync(); //Tìm gần đúng

            if (productList == null) { return null; }

            var productModel = productList.Select(product => new ProductViewModel
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                JewelrySettingID = product.JewelrySettingID,
                MarkupRate = product.MarkupRate,
                Description = product.Description,
                BasePrice = product.BasePrice,
                IsActive = product.IsActive,
                Stock = product.Stock,
                ProductName = product.ProductName
            }).ToList();

            return productModel;
        }

        public async Task<List<ProductViewModel>> GetProductsByPriceDesc()
        {
            var productList = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Diamond)
                .OrderByDescending(p => p.BasePrice)
                .ToListAsync();

            if (productList == null) { return null; }

            var productModel = productList.Select(product => new ProductViewModel()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                JewelrySettingID = product.JewelrySettingID,
                MarkupRate = product.MarkupRate,
                Description = product.Description,
                BasePrice = product.BasePrice,
                IsActive = product.IsActive,
                Stock = product.Stock,
                ProductName = product.ProductName
            }).ToList();

            return productModel;
        }

        public async Task<List<ProductViewModel>> GetProductsByPriceAsc()
        {
            var productList = await _context.Products
                .OrderBy(p => p.BasePrice)
                .ToListAsync();

            if (productList == null) { return null; }

            var productModel = productList.Select(product => new ProductViewModel()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                JewelrySettingID = product.JewelrySettingID,
                MarkupRate = product.MarkupRate,
                Description = product.Description,
                BasePrice = product.BasePrice,
                IsActive = product.IsActive,
                Stock = product.Stock,
                ProductName = product.ProductName
            }).ToList();

            return productModel;
        }

        public async Task<bool> CreateProduct(ProductViewModel productModel)
        {
            bool result = false;
            if (productModel == null) { return result; }

            try
            {
                var product = new Product()
                {
                    ProductId = productModel.ProductId,
                    CategoryId = productModel.CategoryId,
                    JewelrySettingID = productModel.JewelrySettingID,
                    MarkupRate = productModel.MarkupRate,
                    Description = productModel.Description,
                    BasePrice = productModel.BasePrice,
                    IsActive = productModel.IsActive,
                    Stock = productModel.Stock,
                    ProductName = productModel.ProductName
                };
                await _context.Products.AddAsync(product);
                result = _context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            return result;
        }

        public async Task<bool> UpdateProduct(int id, ProductViewModel productModel)
        {
            bool result = false;

            var product = await _context.Products
                .FirstOrDefaultAsync(u => u.ProductId.Equals(id));

            if (product == null)
            {
                return result;
            }

            try
            {
                product.ProductName = productModel.ProductName;
                product.CategoryId = productModel.CategoryId;
                product.JewelrySettingID= productModel.JewelrySettingID;
                product.Description = productModel.Description;
                product.BasePrice = productModel.BasePrice;
                product.IsActive = productModel.IsActive;
                product.ProductName = product.ProductName;
                product.Stock = productModel.Stock;
                product.MarkupRate = productModel.MarkupRate;

                _context.Products.Update(product);
                result = await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            return result;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(u => u.ProductId.Equals(id));

            if (product == null)
            {
                return false;
            }

            if (product.ProductId.Equals(id))
            {
                product.IsActive = false;
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }

            return true;
        }
    }
}
