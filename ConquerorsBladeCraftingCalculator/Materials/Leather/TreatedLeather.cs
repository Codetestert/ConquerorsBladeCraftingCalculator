using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class TreatedLeather : RareLeather
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources => new Dictionary<IResource, int>()
        {
            {new Shellac(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity => Rarity.Rare;
    }
}