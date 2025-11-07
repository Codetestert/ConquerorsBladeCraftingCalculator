using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Fabric
{
    internal class CheapFabric : RareMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }

        public CheapFabric(ICotton cotton)
        {
            RequiredResources =
            [
                new(cotton, GetResourceQuantity(cotton.Rarity)),
                new(new Flax(), 1)
            ];
        }
    }
}