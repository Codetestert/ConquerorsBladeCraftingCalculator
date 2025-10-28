using ConquerorsBladeCraftingCalculator.Resources.Hides.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class FinishedLeather : BaseClasses.Leather
    {
        public FinishedLeather() : base()
        {
            RequiredResources.Add(new BisonHide(), 1);
            RequiredResources.Add(new Sinews(), 1);
        }      
    }
}