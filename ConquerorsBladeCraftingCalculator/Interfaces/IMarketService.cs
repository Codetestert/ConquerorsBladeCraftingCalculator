namespace ConquerorsBladeCraftingCalculator.Interfaces
{
    public interface IMarketService
    {
        int? GetPrice(ITradable item, int quantity = 1);
        int? GetPriceResultIncrement(ITradable item, int increment);
    }

}