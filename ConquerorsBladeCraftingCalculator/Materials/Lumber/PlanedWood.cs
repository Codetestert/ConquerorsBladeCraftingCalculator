using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class PlanedWood : RareMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public PlanedWood(ITimber timber)
        {            
            RequiredResources = new Dictionary<IResource, int>()
            {
                {timber, GetResourceQuantity(timber.Rarity)},
                {new Sinews(), 1}
            };
        }
    }
}