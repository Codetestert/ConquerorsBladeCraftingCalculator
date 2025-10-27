using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Timber.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class TreatedLeather : RareLeather
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources { get; } = new Dictionary<IResource, int>()
        {
            {new Shellac(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity { get; } = Rarity.Rare;
    }
}