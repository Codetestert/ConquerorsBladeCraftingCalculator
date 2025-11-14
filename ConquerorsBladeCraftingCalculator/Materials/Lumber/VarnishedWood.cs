using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.BaseClasses.Resources;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class VarnishedWood(ITimber timber) : EpicMaterial //TODO Rename folder name to Wood?
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; } =
                [
                new((Resource)timber, GetResourceQuantity(timber.Rarity)),
                new(new LinseedOil(), 1),
                new(new Larch(), 1),
                ];
    }
}