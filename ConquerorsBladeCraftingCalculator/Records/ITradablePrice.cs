using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.Records
{
    public sealed record ITradablePrice(ITradable Item, int Price)
    {
    }
}