using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.BaseClasses.Resources;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Copper
{
    internal class RefinedCopper(ICopperOre copperOre) : EpicMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; } =
            [
                new((Resource)copperOre, GetResourceQuantity(copperOre.Rarity)),
                new(new Minium(), 1),
                new(new Charcoal(), 1)
            ];
    }
}