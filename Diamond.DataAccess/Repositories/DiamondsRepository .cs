using Diamond.DataAccess.Repositories;
using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Data;
using Diamond.Entities.DTO;
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

        private readonly IDiamondPriceRepository _diamondPriceRepository;

        public DiamondsRepository(DiamondDbContext context, IDiamondPriceRepository diamondPriceRepository)
        {
            _context = context;
            _diamondPriceRepository = diamondPriceRepository;
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
                IsActive = d.Product.IsActive,
                MarkupPrice = d.Product.MarkupPrice,
                MarkupRate = d.Product.MarkupRate,
                Carat = d.Carat,
                BasePrice = d.BasePrice,
                Clarity = d.Clarity,
                Color = d.Color,
                Cut = d.Cut,
                DiameterMM = d.DiameterMM,
                Quantity = d.Quantity,
                Description = d.Product.Description,
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
                MarkupPrice = diamond.Product.MarkupPrice,
                MarkupRate = diamond.Product.MarkupRate,
                IsActive = diamond.Product.IsActive,
                Quantity = diamond.Quantity,
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
                var newProduct = new Product()
                {
                    ProductId = diamondModel.ProductID,
                    ProductName = diamondModel.ProductName,
                    Description = diamondModel.Description,
                    MarkupRate = diamondModel.MarkupRate,
                    MarkupPrice = diamondModel.MarkupPrice,
                    ProductType = "Diamond",
                    IsActive = true
                };

                var diamond = new Diamonds()
                {
                    Quantity = diamondModel.Quantity,
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
                DiameterMM = diamond.DiameterMM,
                ProductName = diamond.Product.ProductName,
                Description = diamond.Product.Description,
                Quantity = diamond.Quantity,
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
                DiameterMM = d.DiameterMM,
                Description = d.Product.Description,
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
                DiameterMM = d.DiameterMM,
                Description = d.Product.Description,
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
                DiameterMM = d.DiameterMM,
                Description = d.Product.Description,
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
            return await _context.Diamonds
                .Where(d => d.DiameterMM == diameterMM)
                .CountAsync();
        }

        public async Task<bool> UpdateDiamond(DiamondModel diamond)
        {
            var existingDiamond = await _context.Diamonds
                                .Include(d => d.Product)
                                .SingleOrDefaultAsync(d => d.DiamondID.Equals(diamond.DiamondID));

            if (existingDiamond == null)
            {
                return false;
            }

            var existingProduct = existingDiamond.Product;

            try
            {
                existingProduct.ProductId = existingProduct.ProductId;
                existingProduct.ProductName = diamond.ProductName;
                existingProduct.IsActive = diamond.IsActive;
                existingProduct.Description = diamond.Description;
                existingProduct.MarkupRate = diamond.MarkupRate;
                existingProduct.MarkupPrice = diamond.MarkupPrice;

                existingDiamond.ProductID = existingDiamond.ProductID;
                existingDiamond.Carat = diamond.Carat;
                existingDiamond.Clarity = diamond.Clarity;
                existingDiamond.Cut = diamond.Cut;
                existingDiamond.Color = diamond.Color;
                existingDiamond.Quantity = diamond.Quantity;
                existingDiamond.DiameterMM = diamond.DiameterMM;
                existingDiamond.BasePrice = diamond.BasePrice;

                _context.Products.Update(existingProduct);
                _context.Diamonds.Update(existingDiamond);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<MainDiamondDto> GetAllMainDiamonds()
        {
            return _context.MainDiamonds
                .Select(md => new MainDiamondDto
                {
                    MainDiamondID = md.MainDiamondID,
                    MainDiamondName = md.MainDiamondName,
                    Price = md.Price
                }).ToList();
        }

        public IEnumerable<SideDiamondDto> GetAllSideDiamonds()
        {
            return _context.SideDiamonds
                .Select(sd => new SideDiamondDto
                {
                    SideDiamondID = sd.SideDiamondID,
                    SideDiamondName = sd.SideDiamondName,
                    Price = sd.Price
                }).ToList();
        }

        public async Task<bool> UpdateDiamondQuantity(int userId)
        {
            var latestOrder = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .ThenInclude(p => p.Diamond)
                .Where(o => o.UserID == userId)
                .OrderByDescending(o => o.OrderDate)
                .FirstOrDefaultAsync();

            if (latestOrder == null)
            {
                return false;
            }

            try
            {
                foreach (var orderDetail in latestOrder.OrderDetails)
                {
                    var diamond = orderDetail.Product.Diamond;

                    if (diamond != null)
                    {
                        var diamondQuantity = await _context.Diamonds
                            .FirstOrDefaultAsync(js => js.DiamondID == diamond.DiamondID);

                        if (diamondQuantity != null)
                        {
                            diamondQuantity.Quantity -= orderDetail.Quantity;
                            _context.Diamonds.Update(diamondQuantity);
                        }
                    }
                }

                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log exception 
                return false;
            }
        }

        public async Task<List<DiamondModel>> GetDiamondsBySize(decimal size)
        {
            var diamondList = await _context.Diamonds
                .Include(d => d.Product)
                .Where(d => d.DiameterMM == size && d.Product.ProductType.Equals("Diamond"))
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
                DiameterMM = d.DiameterMM,
                Description = d.Product.Description,
                ProductName = d.Product.ProductName,
                MarkupPrice = d.Product.MarkupPrice,
                MarkupRate = d.Product.MarkupRate,
                IsActive = d.Product.IsActive
            }).ToList();

            return diamondModels;
        }

        public async Task<bool> CreateDiamondWithPrice(DiamondModel diamondModel)
        {
            if (diamondModel == null)
            {
                throw new ArgumentNullException(nameof(diamondModel));
            }

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var diamondPrice = await _context.DiamondPrices
                    .FirstOrDefaultAsync(dp => dp.Carat == diamondModel.Carat && dp.Clarity == diamondModel.Clarity && dp.Color == diamondModel.Color && dp.Cut == diamondModel.Cut);
                if (diamondPrice == null)
                {
                    throw new Exception("Price not found for the specified properties");
                }

                var newProduct = new Product()
                {
                    ProductId = diamondModel.ProductID,
                    ProductName = diamondModel.ProductName,
                    Description = diamondModel.Description,
                    MarkupRate = diamondModel.MarkupRate,
                    MarkupPrice = diamondModel.MarkupPrice,
                    ProductType = "Diamond",
                    IsActive = true
                };

                var diamond = new Diamonds()
                {
                    Quantity = diamondModel.Quantity,
                    Carat = diamondModel.Carat,
                    Clarity = diamondModel.Clarity,
                    Color = diamondModel.Color,
                    Cut = diamondModel.Cut,
                    DiameterMM = diamondModel.DiameterMM,
                    BasePrice = diamondPrice.Price,
                    ProductID = newProduct.ProductId
                };

                await _context.Products.AddAsync(newProduct);
                await _context.Diamonds.AddAsync(diamond);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception("Error creating diamond: " + ex.Message);
            }
        }

        public async Task<IEnumerable<Diamonds>> GetDiamondProductsByProperties(decimal carat, string clarity, string color, string cut)
        {
            return await _context.Diamonds
                .Include(d => d.Product)
                .Where(dp => dp.Carat == carat && dp.Clarity == clarity && dp.Color == color && dp.Cut == cut)
                .ToListAsync();
        }

        public async Task<bool> UpdateDiamonds(IEnumerable<Diamonds> diamonds)
        {
            foreach (var diamond in diamonds)
            {
                _context.Entry(diamond).State = EntityState.Modified;
                _context.Entry(diamond.Product).State = EntityState.Modified;
            }
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
