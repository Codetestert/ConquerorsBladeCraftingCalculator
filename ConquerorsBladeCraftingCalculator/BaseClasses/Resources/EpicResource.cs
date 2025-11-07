using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Resources
{
    public abstract class EpicResource : Resource
    {
        public override Rarity Rarity { get; } = Rarity.Epic;
    }
}
