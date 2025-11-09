using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public abstract class UncommonUnitKit : UnitKit
    {
        public override Rarity Rarity { get; } = Rarity.Uncommon;
        public override int CraftingCost { get; } = 25;
    }
}