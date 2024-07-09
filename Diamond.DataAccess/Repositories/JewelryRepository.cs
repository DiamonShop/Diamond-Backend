using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Data;
using Diamond.Entities.Model;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class JewelryRepository : IJewelryRepository
    {
        private readonly DiamondDbContext _context;

        public JewelryRepository(DiamondDbContext context)
        {
            _context = context;
        }

        private async Task<string> GetNextProductIdAsync(int categoryId)
        {
            string prefix;
            switch (categoryId)
            {
                case 1:
                    prefix = "N-";
                    break;
                case 2:
                    prefix = "DC-";
                    break;
                case 3:
                    prefix = "MDC-";
                    break;
                case 4:
                    prefix = "VT-";
                    break;
                default:
                    throw new ArgumentException("Invalid category ID");
            }

            var existingIds = await _context.Jewelry
                .Where(j => j.CategoryId == categoryId)
                .Select(j => j.ProductID)
                .ToListAsync();

            int maxNumber = 0;

            foreach (var id in existingIds)
            {
                if (id.StartsWith(prefix))
                {
                    var match = Regex.Match(id, @"\d+");
                    if (match.Success && int.TryParse(match.Value, out int number))
                    {
                        maxNumber = Math.Max(maxNumber, number);
                    }
                }
            }

            int nextNumber = maxNumber + 1;
            return $"{prefix}{nextNumber:D3}";
        }

        public async Task<bool> CreateJewelry(JewelryModel jewelryModel)
        {
            if (jewelryModel == null)
            {
                return false;
            }

            try
            {
                // Generate the next Product ID
                var productID = await GetNextProductIdAsync(jewelryModel.CategoryId);

                int markupRate = 1;

                var newProduct = new Product()
                {
                    ProductId = productID,
                    ProductName = jewelryModel.ProductName,
                    Description = "",
                    MarkupRate = markupRate,
                    Stock = jewelryModel.Stock,
                    MarkupPrice = jewelryModel.BasePrice * markupRate,
                    ProductType = "Jewelry",
                    IsActive = true
                };

                var jewelry = new Jewelry()
                {
                    CategoryId = jewelryModel.CategoryId,
                    ProductID = productID, // Link to the ProductID
                    JewelrySettingID = jewelryModel.JewelrySettingID,
                    BasePrice = jewelryModel.BasePrice
                };

                await _context.Products.AddAsync(newProduct);
                await _context.Jewelry.AddAsync(jewelry);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<bool> DeleteJewelry(int id)
        {
            var jewelry = await _context.Jewelry
                .Include(j => j.Product)
                .FirstOrDefaultAsync(p => p.JewelryID.Equals(id));

            if (jewelry == null)
            {
                return false;
            }

            try
            {
                jewelry.JewelryID = jewelry.JewelryID;
                jewelry.Product.IsActive = false;
                jewelry.BasePrice = jewelry.BasePrice;
                jewelry.JewelrySettingID = jewelry.JewelrySettingID;
                jewelry.CategoryId = jewelry.CategoryId;
                jewelry.Size = jewelry.Size;
                _context.Jewelry.Remove(jewelry);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<JewelryModel>> GetAllJewelry()
        {
            var jewelryList = await _context.Jewelry
                .Include(j => j.Product)
                .Where(d => d.Product.ProductType.Equals("Jewelry"))
                .ToListAsync();

            if (jewelryList == null || jewelryList.Count == 0)
            {
                return null;
            }

            var jewelryModels = jewelryList.Select(j => new JewelryModel
            {
                JewelryID = j.JewelryID,
                JewelrySettingID = j.JewelrySettingID,
                ProductID = j.ProductID,
                CategoryId = j.CategoryId,
                BasePrice = j.BasePrice,
                ProductName = j.Product.ProductName,
                ProductDescription = j.Product.Description,
                Stock = j.Product.Stock,
                Size = j.Size,
                IsActive = j.Product.IsActive
            }).ToList();

            return jewelryModels;
        }

        public async Task<List<JewelryModel>> GetJewelryByCategoryName(string categoryName)
        {
            var jewelryList = await _context.Jewelry
                .Include(j => j.Category)
                .Include(j => j.Product)
                .Where(p => p.Category.CategoryName == categoryName)
                .ToListAsync();

            if (jewelryList == null || jewelryList.Count == 0)
            {
                return null;
            }

            var jewelryModels = jewelryList.Select(j => new JewelryModel
            {
                JewelryID = j.JewelryID,
                JewelrySettingID = j.JewelrySettingID,
                ProductID = j.ProductID,
                CategoryId = j.CategoryId,
                BasePrice = j.BasePrice,
                ProductName = j.Product.ProductName,
                ProductDescription = j.Product.Description,
                Stock = j.Product.Stock,
                Size = j.Size,
                IsActive = j.Product.IsActive
            }).ToList();

            return jewelryModels;
        }

        public async Task<JewelryModel> GetJewelryById(int id)
        {
            var jewelry = await _context.Jewelry
                .Include(j => j.CategoryId)
                .Include(j => j.Product)
                .FirstOrDefaultAsync(j => j.JewelryID == id);

            if (jewelry == null)
            {
                return null;
            }

            var productModel = new JewelryModel()
            {
                JewelryID = jewelry.JewelryID,
                JewelrySettingID = jewelry.JewelrySettingID,
                ProductID = jewelry.ProductID,
                BasePrice = jewelry.BasePrice,
                CategoryId = jewelry.CategoryId,
                ProductDescription = jewelry.Product.Description,
                IsActive = jewelry.Product.IsActive,
                Size = jewelry.Size,
                ProductName = jewelry.Product.ProductName,
                Stock = jewelry.Product.Stock
            };

            return productModel;
        }

        public async Task<List<JewelryModel>> GetJewelryByName(string jewelryName)
        {
            if (string.IsNullOrEmpty(jewelryName))
            {
                return null;
            }

            string jewelryNameLowerCase = jewelryName.ToLower();

            var jewelryList = await _context.Jewelry
                .Include(j => j.Category)
                .Include(j => j.Product)
                .Where(j => j.Product.ProductName.ToLower().Contains(jewelryNameLowerCase))
                .ToListAsync();

            if (jewelryList == null || jewelryList.Count == 0)
            {
                return null;
            }

            var jewelryModels = jewelryList.Select(j => new JewelryModel
            {
                JewelryID = j.JewelryID,
                JewelrySettingID = j.JewelrySettingID,
                ProductID = j.ProductID,
                CategoryId = j.CategoryId,
                BasePrice = j.BasePrice,
                ProductName = j.Product.ProductName,
                ProductDescription = j.Product.Description,
                Stock = j.Product.Stock,
                Size = j.Size,
                IsActive = j.Product.IsActive
            }).ToList();

            return jewelryModels;
        }

        public async Task<List<JewelryModel>> GetJewelryByPriceAsc()
        {
            var jewelryList = await _context.Jewelry
                .Include(j => j.Category)
                .Include(j => j.Product)
                .OrderBy(p => p.BasePrice)
                .ToListAsync();

            if (jewelryList == null || jewelryList.Count == 0)
            {
                return null;
            }

            var jewelryModels = jewelryList.Select(j => new JewelryModel
            {
                JewelryID = j.JewelryID,
                JewelrySettingID = j.JewelrySettingID,
                ProductID = j.ProductID,
                CategoryId = j.CategoryId,
                BasePrice = j.BasePrice,
                ProductName = j.Product.ProductName,
                ProductDescription = j.Product.Description,
                Stock = j.Product.Stock,
                Size = j.Size,
                IsActive = j.Product.IsActive
            }).ToList();

            return jewelryModels;
        }

        public async Task<List<JewelryModel>> GetJewelryByPriceDesc()
        {
            var jewelryList = await _context.Jewelry
                .Include(j => j.Product)
                .Include(j => j.Category)
                .OrderByDescending(p => p.BasePrice)
                .ToListAsync();

            if (jewelryList == null || jewelryList.Count == 0)
            {
                return null;
            }

            var jewelryModels = jewelryList.Select(j => new JewelryModel
            {
                JewelryID = j.JewelryID,
                JewelrySettingID = j.JewelrySettingID,
                ProductID = j.ProductID,
                CategoryId = j.CategoryId,
                BasePrice = j.BasePrice,
                ProductName = j.Product.ProductName,
                ProductDescription = j.Product.Description,
                Stock = j.Product.Stock,
                Size = j.Size,
                IsActive = j.Product.IsActive
            }).ToList();

            return jewelryModels;
        }

        public async Task<JewelryModel> GetJewelryByProductId(string productId)
        {
            var jewelry = await _context.Jewelry
                .Include(j => j.Category)
                .Include(j => j.Product)
                .FirstOrDefaultAsync(j => j.Product.ProductId.Equals(productId));

            if (jewelry == null)
            {
                return null;
            }

            var productModel = new JewelryModel()
            {
                JewelryID = jewelry.JewelryID,
                JewelrySettingID = jewelry.JewelrySettingID,
                ProductID = jewelry.ProductID,
                BasePrice = jewelry.BasePrice,
                CategoryId = jewelry.CategoryId,
                ProductDescription = jewelry.Product.Description,
                IsActive = jewelry.Product.IsActive,
                Size = jewelry.Size,
                ProductName = jewelry.Product.ProductName,
                Stock = jewelry.Product.Stock
            };

            return productModel;
        }

        public async Task<bool> UpdateJewelry(int id, JewelryModel productModel)
        {
            var jewelry = await _context.Jewelry
                .FirstOrDefaultAsync(p => p.JewelryID == id);

            if (jewelry == null)
            {
                return false;
            }

            try
            {
                jewelry.JewelryID = jewelry.JewelryID;
                jewelry.BasePrice = productModel.BasePrice;
                jewelry.CategoryId = productModel.CategoryId;
                jewelry.ProductID = jewelry.ProductID;
                jewelry.JewelrySettingID = productModel.JewelrySettingID;
                jewelry.Size = productModel.Size;

                _context.Jewelry.Update(jewelry);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
