using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    internal class EpicLumber : Material
    {
        public IReadOnlyDictionary<IResource, int> DiscretionaryResources => new Dictionary<IResource, int>()
        {
            {new PineTimber(), 30 },
            {new AshTimber(), 20 },
            {new OakTimber(), 15 },
            {new CedarTimber(), 10 }
        };
    }
}