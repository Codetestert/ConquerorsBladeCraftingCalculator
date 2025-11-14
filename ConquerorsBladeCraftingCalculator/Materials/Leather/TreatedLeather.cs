using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.BaseClasses.Resources;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    public class TreatedLeather(IHide hide) : RareMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; } =
            [
                new((Resource) hide, GetResourceQuantity(hide.Rarity)),
                new(new Shellac(), 1),
            ];
    }
}