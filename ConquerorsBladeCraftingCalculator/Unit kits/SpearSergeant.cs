using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Lumber;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class SpearSergeant : UnitKit
    {
        public IReadOnlyDictionary<Material, int> RequiredMaterials { get; } = new Dictionary<Material, int>()
        {
            {new FinishedLeather(), 3},
            {new CompositeWood(), 3},
            {new PureIron(), 4}
        };
        public Rarity Rarity { get; } = Rarity.Epic;
        public int ResupplyCost { get; } = 3371;
    }
}
