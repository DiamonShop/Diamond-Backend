using Diamond.Entities.DTO;
using Diamond.Entities.Model;
using DiamondShop.Controllers;
using DiamondShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IDiamondRepository
    {
        public Task<List<DiamondModel>> GetAllDiamonds();
        public Task<DiamondModel> GetDiamondById(int id);
        public Task<List<DiamondModel>> GetDiamondByColor(string Color);
        public Task<List<DiamondModel>> GetDiamondByClarity(string Clarity);
        public Task<List<DiamondModel>> GetDiamondByCarat(decimal Carat);
        public Task<bool> CreateDiamond(DiamondModel diamondModel);
        public Task<bool> DeleteDiamond(int diamondId);
        public Task<bool> UpdateDiamond(int diamondId, DiamondModel diamondModel);
    }
}
