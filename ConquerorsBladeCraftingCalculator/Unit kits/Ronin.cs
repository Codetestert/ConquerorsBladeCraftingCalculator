using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Fabric;
using ConquerorsBladeCraftingCalculator.Resources.Hides;
using ConquerorsBladeCraftingCalculator.Resources.Iron;
using ConquerorsBladeCraftingCalculator.Resources.Cotton;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class Ronin : EpicUnitKit
    {
        public override IReadOnlyDictionary<Material, int> RequiredMaterials { get; } = new Dictionary<Material, int>()
        {
            {new CastIron(new Siderite()), 12},
            {new CheapFabric(new Coarse()), 8},
            {new TreatedLeather(new Goat()), 12}
        };
        public override int ResupplyCost { get; } = 3712;
        public override int CraftingCost { get; } = 100;
    }

}
