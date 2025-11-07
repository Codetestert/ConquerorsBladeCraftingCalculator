using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Copper;
using ConquerorsBladeCraftingCalculator.Resources.Hides;
using ConquerorsBladeCraftingCalculator.Resources.Iron;
using ConquerorsBladeCraftingCalculator.Resources.Copper;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class ManAtArms : EpicUnitKit
    {
        public override IReadOnlyList<MaterialQuantity> RequiredMaterials { get; } =
        [
            new(new FinishedLeather(new Pig()), 3),
            new(new RefinedCopper(new Chalcocite()), 4),//TODO pick a random ICopperOre  
            new(new PureIron(new Siderite()), 4),                      
        ];
        public override int ResupplyCost { get; } = 3371;
    }
}
