using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    internal class PureIron : EpicIron
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources => new Dictionary<IResource, int>()
        {
            {new MountainBauxite(), 1},
            {new Coal(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity => Rarity.Epic;
    }
}
