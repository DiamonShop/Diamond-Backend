using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IDiamondUpdateService
    {
        Task UpdateAllDiamondPrices();
    }
}
