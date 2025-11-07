using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Lumber;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Hides;
using ConquerorsBladeCraftingCalculator.Resources.Iron;
using ConquerorsBladeCraftingCalculator.Resources.Timber;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class SpearSergeant : EpicUnitKit
    {
        public override IReadOnlyList<MaterialQuantity> RequiredMaterials { get; } =
        [
            new(new FinishedLeather(new Pig()), 3),
            new(new CompositeWood(new Oak()), 3),
            new(new PureIron(new Siderite()), 4),
        ];
        public override int ResupplyCost { get; } = 3371;
    }

}
