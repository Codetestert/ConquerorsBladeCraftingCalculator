using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Hides;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    public class Leather : EpicMaterial
    {
        public Dictionary<IResource, int> RequiredResources { get; } = [];

        public Leather() : base()
        {            
            DiscretionaryResources[30] = new PigSkin();
            DiscretionaryResources[20] = new SheepSkin();
            DiscretionaryResources[15] = new GoatHide();
            DiscretionaryResources[10] = new CowHide();

            RequiredResources.Add(new GoatHide(), 15); //TODO figure out how to get a random option from discretionary resources
        }
    }
}