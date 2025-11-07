using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Copper
{
    internal class RefinedCopper : EpicMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }    
        public RefinedCopper(ICopperOre copperOre)
        {
            RequiredResources =
            [
                new(copperOre, GetResourceQuantity(copperOre.Rarity)),
                new(new Minium(), 1),
                new(new Charcoal(), 1)
            ];
        }
    }
}