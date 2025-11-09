using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.Services
{
    public class MarketService : IMarketService
    {     
        public int? GetPrice(ITradable item, int x = 1)
        {       
            int? total;
            throw new NotImplementedException();//TODO figure out how to get live data from market, return the x cheapest results
            IReadOnlyCollection<ITradablePrice> itemPrices = [];
            foreach (var itemPrice in itemPrices)
            {
                total += itemPrice.Price;
            }
            return total;
        }

        public int? GetPriceResultIncrement(ITradable item, int x)
        {
            throw new NotImplementedException(); //TODO needs to return the xth cheapest result           
        }
    }
}
