using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public abstract class EpicUnitKit : UnitKit
    {
        public override Rarity Rarity { get; } = Rarity.Epic;
        public override int CraftingCost { get; } = 100; //TODO some cost 200, so either override in kit implementations or have virtual     
    }
}