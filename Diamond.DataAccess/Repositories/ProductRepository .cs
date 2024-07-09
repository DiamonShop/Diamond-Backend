using Diamond.Entities.Data;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            if (productList == null || productList.Count == 0)
            {
                return null;
            }

            var productModels = productList.Select(p => new ProductViewModel
            {
                ProductId = p.ProductId,
                Description = p.Description,
                ProductType = p.ProductType,
                MarkupPrice = p.MarkupPrice,
                MarkupRate = p.MarkupRate,
                IsActive = p.IsActive,
                Stock = p.Stock,
                ProductName = p.ProductName
            }).ToList();

            return productModels;
        }

        public async Task<ProductViewModel> GetProductById(string id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId.Equals(id));

            if (product == null)
            {
                return null;
            }

            var productModel = new ProductViewModel()
            {
                ProductId = product.ProductId,
                Description = product.Description,
                MarkupPrice = product.MarkupPrice,
                MarkupRate = product.MarkupRate,
                ProductType = product.ProductType,
                IsActive = product.IsActive,
                Stock = product.Stock,
                ProductName = product.ProductName
            };

            return productModel;
        }

        public async Task<List<ProductViewModel>> GetProductsByCategoryName(string productType)
        {
            var productList = await _context.Products
                .Where(p => p.ProductType.Contains(productType))
                .ToListAsync();

            if (productList == null || productList.Count == 0)
            {
                return null;
            }

            var productModels = productList.Select(p => new ProductViewModel
            {
                ProductId = p.ProductId,
                Description = p.Description,
                MarkupPrice = p.MarkupPrice,
                MarkupRate = p.MarkupRate,
                ProductType = p.ProductType,
                IsActive = p.IsActive,
                Stock = p.Stock,
                ProductName = p.ProductName
            }).ToList();

            return productModels;
        }

        public async Task<List<ProductViewModel>> GetProductsByName(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                return null;
            }

            string productNameLowerCase = productName.ToLower();

            var productList = await _context.Products
                .Where(p => p.ProductName.ToLower().Contains(productNameLowerCase))
                .ToListAsync(); //Tìm gần đúng

            if (productList == null || productList.Count == 0)
            {
                return null;
            }

            var productModels = productList.Select(p => new ProductViewModel
            {
                ProductId = p.ProductId,
                Description = p.Description,
                MarkupRate = p.MarkupRate,
                ProductType = p.ProductType,
                MarkupPrice = p.MarkupPrice,
                IsActive = p.IsActive,
                Stock = p.Stock,
                ProductName = p.ProductName
            }).ToList();

            return productModels;
        }

        public async Task<List<ProductViewModel>> GetProductsByPriceDesc()
        {
            var productList = await _context.Products
                .OrderByDescending(p => p.MarkupPrice)
                .ToListAsync();

            if (productList == null || productList.Count == 0)
            {
                return null;
            }

            var productModels = productList.Select(p => new ProductViewModel
            {
                ProductId = p.ProductId,
                Description = p.Description,
                MarkupPrice = p.MarkupPrice,
                ProductType = p.ProductType,
                MarkupRate = p.MarkupRate,
                IsActive = p.IsActive,
                Stock = p.Stock,
                ProductName = p.ProductName
            }).ToList();

            return productModels;
        }

        public async Task<List<ProductViewModel>> GetProductsByPriceAsc()
        {
            var productList = await _context.Products
                .OrderBy(p => p.MarkupPrice)
                .ToListAsync();

            if (productList == null || productList.Count == 0)
            {
                return null;
            }

            var productModels = productList.Select(p => new ProductViewModel
            {
                ProductId = p.ProductId,
                ProductType = p.ProductType,
                MarkupRate = p.MarkupRate,
                Description = p.Description,
                MarkupPrice = p.MarkupPrice,
                IsActive = p.IsActive,
                Stock = p.Stock,
                ProductName = p.ProductName
            }).ToList();

            return productModels;
        }

        public async Task<bool> CreateProduct(ProductViewModel productModel)
        {
            if (productModel == null)
            {
                return false;
            }

            try
            {
                // Đảm bảo MarkupRate có giá trị mặc định là 1
                if (productModel.MarkupRate == 0)
                {
                    productModel.MarkupRate = 1;
                }

                var product = new Product()
                {
                    ProductId = productModel.ProductId,
                    MarkupRate = productModel.MarkupRate,
                    ProductType = productModel.ProductType,
                    Description = productModel.Description,
                    IsActive = productModel.IsActive,
                    Stock = productModel.Stock,
                    ProductName = productModel.ProductName
                };

                // Tính toán MarkupPrice dựa trên BasePrice và MarkupRate
                product.UpdateDiamondsAndJewelryPrice();

                await _context.Products.AddAsync(product);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    
    public async Task<bool> UpdateProduct(string id, ProductViewModel productModel)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.ProductId.Equals(id));

            if (product == null)
            {
                return false;
            }

            try
            {
                product.ProductName = productModel.ProductName;
                product.Description = productModel.Description;
                product.MarkupRate = productModel.MarkupRate;
                product.IsActive = productModel.IsActive;
                product.Stock = productModel.Stock;

                // Tính toán lại MarkupPrice dựa trên các thuộc tính đã cập nhật
                product.UpdateDiamondsAndJewelryPrice();

                _context.Products.Update(product);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<bool> DeleteProduct(string id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId.Equals(id));

            if (product == null)
            {
                return false;
            }

            try
            {
                _context.Products.Remove(product);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateMarkupRate(string productId, int newMarkupRate)
        {
            var product = await _context.Products
                                        .Include(p => p.Jewelry)
                                        .Include(p => p.Diamond)
                                        .FirstOrDefaultAsync(p => p.ProductId.Equals(productId));

            if (product == null)
            {
                return false;
            }

            try
            {
                product.MarkupRate = newMarkupRate;

                // Tính toán lại MarkupPrice dựa trên MarkupRate mới
                product.UpdateDiamondsAndJewelryPrice();

                _context.Products.Update(product);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<bool> UpdateAllMarkupRates(int newMarkupRate)
        {
            try
            {
                var products = await _context.Products
                    .Include(p => p.Jewelry)
                    .Include(p => p.Diamond)
                    .ToListAsync();

                foreach (var product in products)
                {
                    product.MarkupRate = newMarkupRate;
                    product.UpdateDiamondsAndJewelryPrice();
                }

                _context.Products.UpdateRange(products);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }





    }
}
