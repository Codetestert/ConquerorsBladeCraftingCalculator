using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public abstract class RareUnitKit : UnitKit
    {
        public override Rarity Rarity { get; } = Rarity.Rare;
        public override int CraftingCost { get; } = 50; //TODO some cost 100, so either override in kit implementations or have virtual 
    }
}