using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Resources
{
    public abstract class UncommonResource : Resource
    {
        public override Rarity Rarity { get; } = Rarity.Uncommon;
    }
}
