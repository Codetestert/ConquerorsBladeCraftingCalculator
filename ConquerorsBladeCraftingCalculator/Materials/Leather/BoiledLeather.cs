using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class BoiledLeather : EpicLeather
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources => new Dictionary<IResource, int>()
        {
            {new MountainWolfFur(), 1},
            {new Nitre(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity => Rarity.Epic;
    }
}