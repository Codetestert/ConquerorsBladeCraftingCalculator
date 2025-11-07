using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Copper
{
    internal class RefinedCopper : EpicMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }    
        public RefinedCopper(ICopperOre copperOre)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {copperOre, GetResourceQuantity(copperOre.Rarity)},
                {new Minium(), 1},
                {new Charcoal(), 1}
            };
        }
    }
}