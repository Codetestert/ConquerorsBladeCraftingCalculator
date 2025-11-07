using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Resources
{
    public abstract class CommonResource : Resource
    {
        public override Rarity Rarity { get; } = Rarity.Common;
    }
}
