using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Lumber;
using ConquerorsBladeCraftingCalculator.Records;
using Moq;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class SpearSergeant : EpicUnitKit
    {
        public override IReadOnlyList<MaterialQuantity> RequiredMaterials { get; } =
        [
            new(new FinishedLeather(It.IsAny<IHide>()), 3),
            new(new CompositeWood(It.IsAny<ITimber>()), 3),
            new(new PureIron(It.IsAny<IronOre>()), 4),
        ];
        public override int ResupplyCost { get; } = 3371;
    }

}
