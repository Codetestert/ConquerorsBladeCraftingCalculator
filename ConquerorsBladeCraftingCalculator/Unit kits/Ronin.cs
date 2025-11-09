using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Materials.Fabric;
using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Records;
using Moq;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class Ronin : EpicUnitKit
    {
        public override IReadOnlyList<MaterialQuantity> RequiredMaterials { get; } =
        [
            new(new CastIron(It.IsAny<IronOre>()), 12),
            new(new CheapFabric(It.IsAny<ICotton>()), 8),
            new(new TreatedLeather(It.IsAny<IHide>()), 12),
        ];
        public override int ResupplyCost { get; } = 3712;
        public override int CraftingCost { get; } = 100;
    }

}
