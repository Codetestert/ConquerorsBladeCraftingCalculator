using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    public abstract class UnitKit
    {
        public abstract IReadOnlyDictionary<Material, int> RequiredMaterials { get; } //TODO some kits require exotic resources, Outriders requires resources exclusively
        public abstract Rarity Rarity { get; }
        public abstract int ResupplyCost { get; }
        public abstract int CraftingCost { get; }
    }
}
