using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
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

		public async Task<List<ProductViewModel>> GetAllProducts()
		{
			var productList = await _context.Products.ToListAsync();

			if (productList == null) { return null; }

			var productModels = productList.Select(p => new ProductViewModel
			{
				ProductId = p.ProductId,
				CategoryId = p.CategoryId,
				Description = p.Description,
				Price = p.Price,
				IsActive = p.IsActive,
				Stock = p.Stock,
				ProductName = p.ProductName
			}).ToList();

			return productModels;
		}

		public async Task<ProductViewModel> GetProductById(int id)
		{
			var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);

			if (product == null) { return null; }

			var productModel = new ProductViewModel()
			{
				ProductId = product.ProductId,
				CategoryId = product.CategoryId,
				Description = product.Description,
				Price = product.Price,
				IsActive = product.IsActive,
				Stock = product.Stock,
				ProductName = product.ProductName
			};

			return productModel;
		}

		public async Task<List<ProductViewModel>> GetProductsByCategoryName(string categoryName)
		{
			var productList = await _context.Products
				.Include(p => p.Category)
				.Where(p => p.Category.CategoryName.Contains(categoryName)) //Tìm gần đúng
				.ToListAsync();

			if (productList == null) { return null; }

			var productModel = productList.Select(product => new ProductViewModel
			{
				ProductId = product.ProductId,
				CategoryId = product.CategoryId,
				Description = product.Description,
				Price = product.Price,
				IsActive = product.IsActive,
				Stock = product.Stock,
				ProductName = product.ProductName
			}).ToList();

			return productModel;
		}

		public async Task<List<ProductViewModel>> GetProductsByName(string productName)
		{
			var productList = await _context.Products
				.Include(p => p.Category)
				.Where(p => p.ProductName.Contains(productName)) //Tìm gần đúng
				.ToListAsync();

			if (productList == null) { return null; }

			var productModel = productList.Select(product => new ProductViewModel
			{
				ProductId = product.ProductId,
				CategoryId = product.CategoryId,
				Description = product.Description,
				Price = product.Price,
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
				.Include(p => p.ProductDetail)
				.OrderByDescending(p => p.Price)
				.ToListAsync();

			if (productList == null) { return null; }

			var productModel = productList.Select(p => new ProductViewModel()
			{
				ProductId = p.ProductId,
				CategoryId = p.CategoryId,
				Description = p.Description,
				Price = p.Price,
				IsActive = p.IsActive,
				Stock = p.Stock,
				ProductName = p.ProductName
			}).ToList();

			return productModel;
		}

		public async Task<List<ProductViewModel>> GetProductsByPriceAsc()
		{
			var productList = await _context.Products
				.Include(p => p.Category)
				.Include(p => p.ProductDetail)
				.OrderBy(p => p.Price)
				.ToListAsync();

			if (productList == null) { return null; }

			var productModel = productList.Select(p => new ProductViewModel()
			{
				ProductId = p.ProductId,
				CategoryId = p.CategoryId,
				Description = p.Description,
				Price = p.Price,
				IsActive = p.IsActive,
				Stock = p.Stock,
				ProductName = p.ProductName
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
					Description = productModel.Description,
					Price = productModel.Price,
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
				.Include(u => u.Category)
				.FirstOrDefaultAsync(u => u.ProductId == id);

			if (product == null)
			{
				return result;
			}

			try
			{
				product.ProductName = productModel.ProductName;
				product.CategoryId = productModel.CategoryId;
				product.Description = productModel.Description;
				product.Price = productModel.Price;
				product.IsActive = productModel.IsActive;
				product.ProductName = product.ProductName;

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
			var product = await _context.Products.FirstOrDefaultAsync(u => u.ProductId == id);

			if (product == null)
			{
				return false;
			}

			if (product.ProductId == id)
			{
				product.IsActive = false;
				_context.Products.Update(product);
				await _context.SaveChangesAsync();
			}

			return true;
		}
        public async Task<List<ProductViewModel>> GetProductsBySimilarName(string keyword)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Where(p => p.ProductName.Contains(keyword)) // Tìm kiếm sản phẩm với tên gần đúng
                .ToListAsync();

            if (products == null) { return null; }

            var productModels = products.Select(p => new ProductViewModel
            {
                ProductId = p.ProductId,
                CategoryId = p.CategoryId,
                Description = p.Description,
                Price = p.Price,
                IsActive = p.IsActive,
                Stock = p.Stock,
                ProductName = p.ProductName
            }).ToList();

            return productModels;
        }
    }
}
