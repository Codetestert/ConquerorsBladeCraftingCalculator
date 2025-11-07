using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    public class TreatedLeather : RareMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public TreatedLeather(IHide hide)
        {
            RequiredResources =
            [
                new(hide, GetResourceQuantity(hide.Rarity)),
                new(new Shellac(), 1),
            ];
        }
    }
}