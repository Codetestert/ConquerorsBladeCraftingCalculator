using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.Materials
{
    internal class FinishedLeather : IMaterial
    {
        public ICollection<IResource> RequiredResources = new List<IResource>()
        { 
        PigSkin,
        BisonHide,
        Sinews
        };
    }
}