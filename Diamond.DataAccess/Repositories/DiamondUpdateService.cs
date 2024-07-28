using Diamond.DataAccess.Repositories.Interfaces;
using DiamondShop.Repositories.Interfaces;

public class DiamondUpdateService : IDiamondUpdateService
{
    private readonly IDiamondPriceRepository _diamondPriceRepository;
    private readonly IDiamondsRepository _diamondsRepository;

    public DiamondUpdateService(IDiamondPriceRepository diamondPriceRepository, IDiamondsRepository diamondsRepository)
    {
        _diamondPriceRepository = diamondPriceRepository;
        _diamondsRepository = diamondsRepository;
    }

    public async Task UpdateAllDiamondPrices()
    {
        var diamondPrices = await _diamondPriceRepository.GetAllDiamondPrices();

        foreach (var diamondPrice in diamondPrices)
        {
            var diamondProducts = await _diamondsRepository.GetDiamondProductsByProperties(
                diamondPrice.Carat, diamondPrice.Clarity, diamondPrice.Color, diamondPrice.Cut);

            foreach (var diamondProduct in diamondProducts)
            {
                diamondProduct.BasePrice = diamondPrice.Price;
            }

            await _diamondsRepository.UpdateDiamonds(diamondProducts);
        }
    }
}
