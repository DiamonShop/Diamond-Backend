using Diamond.Entities.Data;
using Diamond.Entities.Model;
using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories
{
    public class DiamondsRepository : IDiamondsRepository
    {
        private readonly DiamondDbContext _context;

        public DiamondsRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<List<DiamondModel>> GetAllDiamonds()
        {
            var diamondList = await _context.Diamonds
                .Include(d => d.Product)
                .Where(d => d.Product.ProductType.Equals("Diamond"))
                .ToListAsync();

            if (diamondList == null || diamondList.Count == 0)
            {
                return null;
            }

            var diamondModels = diamondList.Select(d => new DiamondModel
            {
                DiamondID = d.DiamondID,
                ProductID = d.ProductID,
                Carat = d.Carat,
                BasePrice = d.BasePrice,
                Clarity = d.Clarity,
                Color = d.Color,
                Cut = d.Cut,
                DiameterMM = d.DiameterMM,
                Quantity = d.Quantity,
                Description = d.Product.Description,
                IsActive = d.Product.IsActive,
                ProductName = d.Product.ProductName
            }).ToList();

            return diamondModels;
        }

        public async Task<DiamondModel> GetDiamondByProductId(string productId)
        {
            var diamond = await _context.Diamonds
                .Include(j => j.Product)
                .FirstOrDefaultAsync(j => j.Product.ProductId.Equals(productId));

            if (diamond == null)
            {
                return null;
            }

            var productModel = new DiamondModel()
            {
                ProductID = diamond.ProductID,
                DiamondID = diamond.DiamondID,
                BasePrice = diamond.BasePrice,
                Cut = diamond.Cut,
                Color = diamond.Color,
                Clarity = diamond.Clarity,
                Carat = diamond.Carat,
                DiameterMM = diamond.DiameterMM,
                ProductName = diamond.Product.ProductName,
                Description = diamond.Product.Description,
                Quantity = diamond.Quantity,
                IsActive = diamond.Product.IsActive
            };

            return productModel;
        }

        public async Task<bool> CreateDiamond(DiamondModel diamondModel)
        {
            if (diamondModel == null)
            {
                return false;
            }

            try
            {
                int MarkupRate = 1;

                var newProduct = new Product()
                {
                    ProductId = diamondModel.ProductID,
                    ProductName = diamondModel.ProductName,
                    Description = diamondModel.Description,
                    MarkupRate = MarkupRate,
                    MarkupPrice = diamondModel.BasePrice * MarkupRate,
                    ProductType = "Diamond",
                    IsActive = true
                };

                var diamond = new Diamonds()
                {
                    Carat = diamondModel.Carat,
                    Clarity = diamondModel.Clarity,
                    Color = diamondModel.Color,
                    Cut = diamondModel.Cut,
                    DiameterMM = diamondModel.DiameterMM,
                    BasePrice = diamondModel.BasePrice,
                    ProductID = newProduct.ProductId
                };

                await _context.Products.AddAsync(newProduct);
                await _context.Diamonds.AddAsync(diamond);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /*private async Task<string> GenerateProductIDAsync(decimal diameterMM)
        {
            string prefix = $"KC-{diameterMM:F1}-";
            var maxIdNumberQuery = await _context.Diamonds
                .Where(d => d.ProductID.StartsWith(prefix))
                .Select(d => d.ProductID.Substring(prefix.Length))
                .ToListAsync();

            int maxIdNumber = 0;
            if (maxIdNumberQuery.Any())
            {
                maxIdNumber = maxIdNumberQuery
                    .Select(id => int.TryParse(id, out int num) ? num : 0)
                    .Max();
            }

            int newIdNumber = maxIdNumber + 1;
            return $"{prefix}{newIdNumber:D3}";
        }*/

        public async Task<bool> UpdateDiamond(int id, DiamondModel diamond)
        {
            var existingDiamond = await _context.Diamonds.FindAsync(diamond.DiamondID);

            if (existingDiamond == null)
            {
                return false;
            }

            try
            {
                existingDiamond.ProductID = diamond.ProductID;
                existingDiamond.Carat = diamond.Carat;
                existingDiamond.Clarity = diamond.Clarity;
                existingDiamond.Cut = diamond.Cut;
                existingDiamond.Color = diamond.Color;
                existingDiamond.BasePrice = diamond.BasePrice;

                _context.Diamonds.Update(existingDiamond);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<DiamondModel> GetDiamondById(int id)
        {
            var diamond = await _context.Diamonds
                .Include(x => x.Product)
                .Where(d => d.Product.ProductType.Equals("Diamond"))
                .FirstOrDefaultAsync(d => d.DiamondID == id);

            if (diamond == null)
            {
                return null;
            }

            var productModel = new DiamondModel()
            {
                ProductID = diamond.ProductID,
                DiamondID = diamond.DiamondID,
                BasePrice = diamond.BasePrice,
                Cut = diamond.Cut,
                Color = diamond.Color,
                Clarity = diamond.Clarity,
                Carat = diamond.Carat,
                ProductName = diamond.Product.ProductName,
                Description = diamond.Product.Description,
                Quantity = diamond.Quantity,
                IsActive = diamond.Product.IsActive
            };

            return productModel;
        }

        public async Task<List<DiamondModel>> GetDiamondByName(string diamondName)
        {
            if (string.IsNullOrEmpty(diamondName))
            {
                return null;
            }

            string diamondNameLowerCase = diamondName.ToLower();

            var diamondList = await _context.Diamonds
                .Include(j => j.Product)
                .Where(d => d.Product.ProductType.Equals("Diamond"))
                .Where(j => j.Product.ProductName.ToLower().Contains(diamondNameLowerCase))
                .ToListAsync();

            if (diamondList == null || diamondList.Count == 0)
            {
                return null;
            }

            var diamondModels = diamondList.Select(d => new DiamondModel
            {
                DiamondID = d.DiamondID,
                ProductID = d.ProductID,
                Carat = d.Carat,
                BasePrice = d.BasePrice,
                Clarity = d.Clarity,
                Color = d.Color,
                Cut = d.Cut,
                Quantity = d.Quantity,
                Description = d.Product.Description,
                IsActive = d.Product.IsActive,
                ProductName = d.Product.ProductName
            }).ToList();

            return diamondModels;
        }

        public async Task<List<DiamondModel>> GetDiamondByPriceDesc()
        {
            var diamondList = await _context.Diamonds
                .Where(d => d.Product.ProductType.Equals("Diamond"))
                .OrderByDescending(p => p.BasePrice)
                .ToListAsync();

            if (diamondList == null || diamondList.Count == 0)
            {
                return null;
            }

            var diamondModels = diamondList.Select(d => new DiamondModel
            {
                DiamondID = d.DiamondID,
                ProductID = d.ProductID,
                Carat = d.Carat,
                BasePrice = d.BasePrice,
                Clarity = d.Clarity,
                Color = d.Color,
                Cut = d.Cut,
                Quantity = d.Quantity,
                Description = d.Product.Description,
                IsActive = d.Product.IsActive,
                ProductName = d.Product.ProductName
            }).ToList();

            return diamondModels;
        }

        public async Task<List<DiamondModel>> GetDiamondByPriceAsc()
        {
            var diamondList = await _context.Diamonds
                .Where(d => d.Product.ProductType.Equals("Diamond"))
                .OrderBy(p => p.BasePrice)
                .ToListAsync();

            if (diamondList == null || diamondList.Count == 0)
            {
                return null;
            }

            var diamondModels = diamondList.Select(d => new DiamondModel
            {
                DiamondID = d.DiamondID,
                ProductID = d.ProductID,
                Carat = d.Carat,
                BasePrice = d.BasePrice,
                Clarity = d.Clarity,
                Color = d.Color,
                Cut = d.Cut,
                Quantity = d.Quantity,
                Description = d.Product.Description,
                IsActive = d.Product.IsActive,
                ProductName = d.Product.ProductName
            }).ToList();

            return diamondModels;
        }

        public async Task<bool> DeleteDiamond(int id)
        {
            var diamond = await _context.Diamonds
                .Where(d => d.Product.ProductType.Equals("Diamond"))
                .Include(j => j.Product)
                .FirstOrDefaultAsync(p => p.DiamondID.Equals(id));

            if (diamond == null)
            {
                return false;
            }

            try
            {
                diamond.Product.IsActive = false;
                diamond.DiamondID = diamond.DiamondID;
                diamond.ProductID = diamond.ProductID;
                diamond.BasePrice = diamond.BasePrice;
                diamond.Cut = diamond.Cut;
                diamond.Color = diamond.Color;
                diamond.Clarity = diamond.Clarity;
                diamond.Carat = diamond.Carat;
                _context.Diamonds.Update(diamond);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<int> GetDiamondCountByDiameter(decimal diameterMM)
        {
            var count = await _context.Diamonds
                .Where(d => d.DiameterMM == diameterMM)
                .CountAsync();
            return count;
        }
    }
}
