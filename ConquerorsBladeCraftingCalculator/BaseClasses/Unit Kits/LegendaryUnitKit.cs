using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public abstract class LegendaryUnitKit : UnitKit
    {
        public override Rarity Rarity { get; } = Rarity.Legendary;
        public override int CraftingCost { get; } = 200; //TODO some cost 400 or 300, so override in kit implementations
    }
}