using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public abstract class CommonUnitKit : UnitKit
    {
        public override Rarity Rarity { get; } = Rarity.Common;
        public override int CraftingCost { get; } = 10;
    }
}