using ConquerorsBladeCraftingCalculator.Enums;
using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Resources
{  
    public abstract class Resource : IResource
    {
        public abstract Rarity Rarity { get; }
    }
}