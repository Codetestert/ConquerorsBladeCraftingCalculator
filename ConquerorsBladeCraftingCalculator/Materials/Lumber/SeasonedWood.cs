using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class SeasonedWood : UncommonMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public SeasonedWood(ITimber timber)
        {
            RequiredResources =
            [
                new(timber, GetResourceQuantity(timber.Rarity)),
            ];
        }
    }
}