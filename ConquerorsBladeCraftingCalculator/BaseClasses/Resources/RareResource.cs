using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Resources
{
    public abstract class RareResource : Resource
    {
        public override Rarity Rarity { get; } = Rarity.Rare;
    }
}
