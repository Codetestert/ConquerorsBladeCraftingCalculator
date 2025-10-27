using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Iron.Exotics;
using ConquerorsBladeCraftingCalculator.Resources.Stone.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    internal class PureIron : EpicIron
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources { get; } = new Dictionary<IResource, int>()
        {
            {new MountainBauxite(), 1},
            {new Coal(), 1} //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity { get; } = Rarity.Epic;
    }
}
