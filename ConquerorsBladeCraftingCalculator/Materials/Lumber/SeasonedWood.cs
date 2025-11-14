using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.BaseClasses.Resources;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class SeasonedWood(ITimber timber) : UncommonMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; } =
            [
                new((Resource)timber, GetResourceQuantity(timber.Rarity)),
            ];
    }
}