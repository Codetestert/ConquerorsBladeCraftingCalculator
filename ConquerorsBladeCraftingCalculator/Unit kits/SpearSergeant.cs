using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Lumber;

namespace ConquerorsBladeCraftingCalculator.Models
{
    internal class SpearSergeant : IUnitKit
    {
        public IReadOnlyDictionary<Material, int> RequiredMaterials => new Dictionary<Material, int>()
        {
            {new FinishedLeather(), 3},
            {new CompositeWood(), 3},
            {new PureIron(), 4}
        };
        public Rarity Rarity => Rarity.Epic;
        public int ResupplyCost => 3371;
    }
}
