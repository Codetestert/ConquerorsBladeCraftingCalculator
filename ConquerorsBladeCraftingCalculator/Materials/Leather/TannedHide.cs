using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    public class TannedHide : UncommonMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public TannedHide(IHide hide)
        {
            RequiredResources =
            [
                new(hide, GetResourceQuantity(hide.Rarity)),
            ];
        }
    }
}