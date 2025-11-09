using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.Interfaces
{
    public interface IResource : ITradable //HACK don't like that now ICopperOre, IronOre, ICotton, IHide and ITimber are now also tradable items when they're not, only Resources are
    {
        Rarity Rarity { get; }
    }
}