using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    public class BoiledLeather : EpicMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public BoiledLeather(IHide hide)
        {
            RequiredResources =
            [
                new(hide, GetResourceQuantity(hide.Rarity)),
                new(new MountainWolfFur(), 1),
                new(new Nitre(), 1),
            ];
        }
    }
}