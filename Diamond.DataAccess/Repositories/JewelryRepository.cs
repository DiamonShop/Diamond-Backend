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

        /*private async Task<string> GetNextProductIdAsync(int categoryId)
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
        }*/

        public async Task<bool> CreateJewelry(JewelryCreateModel jewelryModel)
        {
            if (jewelryModel == null)
            {
                return false;
            }

            try
            {
                var newProduct = new Product()
                {
                    ProductId = jewelryModel.ProductID,
                    ProductName = jewelryModel.ProductName,
                    Description = jewelryModel.Description,
                    MarkupRate = jewelryModel.MarkupRate,
                    MarkupPrice = jewelryModel.MarkupPrice,
                    ProductType = "Diamond",
                    IsActive = true
                };

                var priceMainDiamond = _context.MainDiamonds.SingleOrDefault(m => m.MainDiamondID == jewelryModel.MainDiamondID);
                var priceSideDiamond = _context.SideDiamonds.SingleOrDefault(s => s.SideDiamondID == jewelryModel.SideDiamondID);
                var priceSetting = _context.JewelrySetting.SingleOrDefault(s => s.JewelrySettingID == jewelryModel.JewelrySettingID);

                var jewelry = new Jewelry()
                {
                    CategoryId = jewelryModel.CategoryId,
                    JewelrySettingID = jewelryModel.JewelrySettingID,
                    MainDiamondID = jewelryModel.MainDiamondID,
                    MainDiamondQuantity = jewelryModel.MainDiamondQuantity,
                    SideDiamondID = jewelryModel.SideDiamondID,
                    SideDiamondQuantity = jewelryModel.SideDiamondQuantity,
                    ProductID = jewelryModel.ProductID,
                    BasePrice = jewelryModel.BasePrice
                };

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
                jewelry.Product.IsActive = false;

                _context.Jewelry.Update(jewelry);
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
                                .Include(j => j.Category)
                                .Include(j => j.JewelrySizes)
                                .Include(j => j.JewelrySetting)
                                .Include(j => j.MainDiamond)
                                .Include(j => j.SideDiamond)
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
                Material = j.JewelrySetting.Material,
                SideDiamondName = j.SideDiamond.SideDiamondName,
                ProductID = j.ProductID,
                CategoryName = j.Category.CategoryName,
                ProductName = j.Product.ProductName,
                Description = j.Product.Description,
                MarkupRate = j.Product.MarkupRate,
                MarkupPrice = j.Product.MarkupPrice,
                IsActive = j.Product.IsActive,
                CategoryId = j.CategoryId,
                BasePrice = j.BasePrice,
                MainDiamondName = j.MainDiamond.MainDiamondName,
                MainDiamondID = j.MainDiamondID,
                MainDiamondQuantity = j.MainDiamondQuantity,
                SideDiamondID = j.SideDiamondID,
                SideDiamondQuantity = j.SideDiamondQuantity,
                JewelrySizes = j.JewelrySizes
                                    .Where(js => js.JewelryID == j.JewelryID)
                                    .Select(js => new JewelrySizeModel
                                    {
                                        JewelrySizeID = js.JewelrySizeID,
                                        JewelryID = js.JewelryID,
                                        Size = js.Size,
                                        Quantity = js.Quantity
                                    }).ToList()
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
            }).ToList();

            return jewelryModels;
        }

        public async Task<JewelryModel> GetJewelryByProductId(string productId)
        {
            var jewelry = await _context.Jewelry
                .Include(j => j.Category)
                .Include(j => j.Product)
                .Include(j => j.JewelrySetting)
                .Include(j => j.MainDiamond)
                .Include(j => j.SideDiamond)
                .FirstOrDefaultAsync(j => j.Product.ProductId.Equals(productId));

            if (jewelry == null)
            {
                return null;
            }

            var productModel = new JewelryModel()
            {
                JewelryID = jewelry.JewelryID,
                CategoryName = jewelry.Category.CategoryName,
                JewelrySettingID = jewelry.JewelrySettingID,
                ProductID = jewelry.ProductID,
                SideDiamondName = jewelry.SideDiamond.SideDiamondName,
                Material = jewelry.JewelrySetting.Material,
                IsActive = jewelry.Product.IsActive,
                MainDiamondQuantity = jewelry.MainDiamondQuantity,
                MainDiamondID = jewelry.MainDiamondID,
                MarkupPrice = jewelry.Product.MarkupPrice,
                ProductName = jewelry.Product.ProductName,
                MarkupRate = jewelry.Product.MarkupRate,
                Description = jewelry.Product.Description!,
                MainDiamondName = jewelry.MainDiamond.MainDiamondName,
                SideDiamondID = jewelry.SideDiamondID,
                SideDiamondQuantity = jewelry.SideDiamondQuantity,
                BasePrice = jewelry.BasePrice,
                CategoryId = jewelry.CategoryId,
                JewelrySizes = jewelry.JewelrySizes
                                    .Where(js => js.JewelryID == js.JewelryID)
                                    .Select(js => new JewelrySizeModel
                                    {
                                        JewelrySizeID = js.JewelrySizeID,
                                        JewelryID = js.JewelryID,
                                        Size = js.Size,
                                        Quantity = js.Quantity
                                    }).ToList()
            };

            return productModel;
        }

        public async Task<bool> UpdateJewelry(JewelryModel jewelryModel)
        {
            var jewelry = await _context.Jewelry
                .FirstOrDefaultAsync(p => p.ProductID.Equals(jewelryModel.ProductID));

            if (jewelry == null)
            {
                return false;
            }

            try
            {

                jewelry.JewelryID = jewelry.JewelryID;
                jewelry.ProductID = jewelry.ProductID;
                jewelry.BasePrice = jewelryModel.BasePrice;
                jewelry.CategoryId = jewelryModel.CategoryId;
                jewelry.JewelrySettingID = jewelryModel.JewelrySettingID;

                _context.Jewelry.Update(jewelry);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<int> GetJewelryCountByCategoryId(int categoryId)
        {
            var count = await _context.Jewelry
                .Where(d => d.CategoryId == categoryId)
                .CountAsync();
            return count;
        }
    }
}