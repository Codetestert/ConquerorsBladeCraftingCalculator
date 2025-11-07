using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    public class FinishedLeather : EpicMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public FinishedLeather(IHide hide)
        {
            RequiredResources =
            [
                new(hide, GetResourceQuantity(hide.Rarity)),
                new(new BisonHide(), 1),
                new(new Sinews(), 1),
            ];
        }
    }
}