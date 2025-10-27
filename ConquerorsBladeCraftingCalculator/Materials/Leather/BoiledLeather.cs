using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Hides.Exotics;
using ConquerorsBladeCraftingCalculator.Resources.Stone.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class BoiledLeather : EpicLeather
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources { get; } = new Dictionary<IResource, int>()
        {
            {new MountainWolfFur(), 1},
            {new Nitre(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity { get; } = Rarity.Epic;
    }
}