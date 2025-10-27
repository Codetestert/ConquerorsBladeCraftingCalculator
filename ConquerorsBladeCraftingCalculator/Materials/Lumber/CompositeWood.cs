using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    internal class CompositeWood : EpicLumber
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources => new Dictionary<IResource, int>()
        {
            {new Yew(), 1},
            {new Coal(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity => Rarity.Epic;
    }
}