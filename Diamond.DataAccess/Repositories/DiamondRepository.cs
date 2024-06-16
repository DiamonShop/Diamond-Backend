using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Data;
using Diamond.Entities.DTO;
using Diamond.Entities.Model;
using DiamondShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Diamond.DataAccess.Repositories
{
    public class DiamondRepository : IDiamondRepository
    {
        private readonly DiamondDbContext _context;
        public DiamondRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<List<DiamondModel>> GetAllDiamonds()
        {
            var diamondList = await _context.Diamonds.ToListAsync();

            if (diamondList == null)
            {
                return null;
            }

            var diamondModelList = diamondList.Select(diamondModel => new DiamondModel
            {
                DiamondID = diamondModel.DiamondID,
                BasePrice = diamondModel.BasePrice,
                Carat = diamondModel.Carat,
                Clarity = diamondModel.Clarity,
                Color = diamondModel.Color,
                Cut = diamondModel.Cut,
                Origin = diamondModel.Origin,
                ProductID = diamondModel.ProductID
            }).ToList();

            return diamondModelList;
        }

        public async Task<DiamondModel> GetDiamondById(int id)
        {
            var diamond = await _context.Diamonds.FirstOrDefaultAsync(diamond => diamond.DiamondID.Equals(id));

            if (diamond == null)
            {
                return null!;
            }

            DiamondModel diamondModel = new DiamondModel()
            {
                DiamondID = diamond.DiamondID,
                BasePrice = diamond.BasePrice,
                Carat = diamond.Carat,
                Clarity = diamond.Clarity,
                Color = diamond.Color,
                Cut = diamond.Cut,
                Origin = diamond.Origin,
                ProductID = diamond.ProductID
            };

            return diamondModel;
        }

        public async Task<List<DiamondModel>> GetDiamondByClarity(string Clarity)
        {
            var diamonds = await _context.Diamonds
                        .Where(diamond => diamond.Clarity.Contains(Clarity)) //Tìm gần đúng
                        .ToListAsync();

            if (diamonds == null)
            {
                return null!;
            }

            var diamondModelList = diamonds.Select(diamondModel => new DiamondModel
            {
                DiamondID = diamondModel.DiamondID,
                BasePrice = diamondModel.BasePrice,
                Carat = diamondModel.Carat,
                Clarity = diamondModel.Clarity,
                Color = diamondModel.Color,
                Cut = diamondModel.Cut,
                Origin = diamondModel.Origin,
                ProductID = diamondModel.ProductID
            }).ToList();

            return diamondModelList;
        }

        public async Task<List<DiamondModel>> GetDiamondByCarat(decimal Carat)
        {
            var diamonds = await _context.Diamonds
                .Where(diamond => diamond.Carat == Carat)
                .ToListAsync();

            if (diamonds == null || !diamonds.Any())
            {
                return new List<DiamondModel>(); // or null if you prefer
            }

            var diamondModels = diamonds.Select(diamond => new DiamondModel
            {
                DiamondID = diamond.DiamondID,
                BasePrice = diamond.BasePrice,
                Carat = diamond.Carat,
                Clarity = diamond.Clarity,
                Color = diamond.Color,
                Cut = diamond.Cut,
                Origin = diamond.Origin,
                ProductID = diamond.ProductID
            }).ToList();

            return diamondModels;
        }

        public async Task<List<DiamondModel>> GetDiamondByColor(string Color)
        {
            var diamonds = await _context.Diamonds
                        .Where(diamond => diamond.Color.Contains(Color)) //Tìm gần đúng
                        .ToListAsync();

            if (diamonds == null)
            {
                return null!;
            }

            var diamondModelList = diamonds.Select(diamondModel => new DiamondModel
            {
                DiamondID = diamondModel.DiamondID,
                BasePrice = diamondModel.BasePrice,
                Carat = diamondModel.Carat,
                Clarity = diamondModel.Clarity,
                Color = diamondModel.Color,
                Cut = diamondModel.Cut,
                Origin = diamondModel.Origin,
                ProductID = diamondModel.ProductID
            }).ToList();

            return diamondModelList;
        }

        public async Task<bool> CreateDiamond(DiamondModel diamondModel)
        {
            bool result = false;

            if (diamondModel == null)
            {
                return result;
            }

            try
            {
                var diamond = new Diamonds()
                {
                    ProductID = diamondModel.ProductID,
                    BasePrice = diamondModel.BasePrice,
                    Carat = diamondModel.Carat,
                    Clarity = diamondModel.Clarity,
                    Color = diamondModel.Color,
                    Cut = diamondModel.Cut,
                    Origin = diamondModel.Origin
                };
                await _context.Diamonds.AddAsync(diamond);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteDiamond(int diamondId)
        {
            var diamond = await _context.Diamonds.FirstOrDefaultAsync(diamond => diamond.DiamondID == diamondId);

            if (diamond == null)
            {
                return false;
            }

            if (diamond.DiamondID == diamondId)
            {
                diamond.IsActive = false;
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }

            return true;
        }

        public Task<bool> UpdateDiamond(int diamondId, DiamondModel diamondModel)
        {
            throw new NotImplementedException();
        }
    }
}