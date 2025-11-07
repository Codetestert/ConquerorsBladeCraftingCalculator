using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Fabric;
using ConquerorsBladeCraftingCalculator.Resources.Hides;
using ConquerorsBladeCraftingCalculator.Resources.Iron;
using ConquerorsBladeCraftingCalculator.Resources.Cotton;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class Ronin : EpicUnitKit
    {
        public override IReadOnlyList<MaterialQuantity> RequiredMaterials { get; } =
        [
            new(new CastIron(new Siderite()), 12),
            new(new CheapFabric(new Coarse()), 8),
            new(new TreatedLeather(new Goat()), 12),
        ];
        public override int ResupplyCost { get; } = 3712;
        public override int CraftingCost { get; } = 100;
    }

}
