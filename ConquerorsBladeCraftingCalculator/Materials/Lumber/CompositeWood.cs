using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Stone.Exotics;
using ConquerorsBladeCraftingCalculator.Resources.Timber.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    internal class CompositeWood : EpicLumber
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources { get; } = new Dictionary<IResource, int>()
        {
            {new Yew(), 1},
            {new Coal(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity { get; } = Rarity.Epic;
    }
}