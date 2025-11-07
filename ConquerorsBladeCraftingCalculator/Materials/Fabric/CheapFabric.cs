using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Fabric
{
    internal class CheapFabric : RareMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }

        public CheapFabric(ICotton cotton)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {cotton, GetResourceQuantity(cotton.Rarity)},
                {new Flax(), 1}
            };
        }
    }
}