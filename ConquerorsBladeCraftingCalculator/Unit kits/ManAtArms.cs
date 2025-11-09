using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Copper;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Interfaces;
using Moq;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class ManAtArms : EpicUnitKit
    {
        public override IReadOnlyList<MaterialQuantity> RequiredMaterials { get; } =
        [
            new(new FinishedLeather(It.IsAny<IHide>()), 3),
            new(new RefinedCopper(It.IsAny<ICopperOre>()), 4),
            new(new PureIron(It.IsAny<IronOre>()), 4),                      
        ];
        public override int ResupplyCost { get; } = 3371;
    }
}
