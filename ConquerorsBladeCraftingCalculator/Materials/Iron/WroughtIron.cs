using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class WroughtIron : EpicMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public WroughtIron(IronOre ironOre)
        {
            RequiredResources =
            [
                new(ironOre, GetResourceQuantity(ironOre.Rarity)),
                new(new Tungsten(), 1),
                new(new BlackManganese(), 1),
            ];
        }
    }
}