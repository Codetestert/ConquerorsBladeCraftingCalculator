using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Materials.Iron;
using ConquerorsBladeCraftingCalculator.Materials.Leather;
using ConquerorsBladeCraftingCalculator.Materials.Copper;
using ConquerorsBladeCraftingCalculator.Resources.Hides;
using ConquerorsBladeCraftingCalculator.Resources.Iron;
using ConquerorsBladeCraftingCalculator.Resources.Copper;

namespace ConquerorsBladeCraftingCalculator.UnitKits
{
    public class ManAtArms : EpicUnitKit
    {
        public override IReadOnlyDictionary<Material, int> RequiredMaterials { get; } = new Dictionary<Material, int>()
        {
            {new FinishedLeather(new Pig()), 3},
            {new RefinedCopper(new Chalcocite()), 4}, //TODO pick a random ICopperOre
            {new PureIron(new Siderite()), 4}
        };
        public override int ResupplyCost { get; } = 3371;
    }
}
