using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    internal class EpicIron : Material
    {
        public IReadOnlyDictionary<IResource, int> DiscretionaryResources => new Dictionary<IResource, int>()
        {
            {new SideriteOre(), 30 },
            {new Magnetite(), 20 },
            {new Limonite(), 15 },
            {new Haematite(), 10 }
        };
    }
}