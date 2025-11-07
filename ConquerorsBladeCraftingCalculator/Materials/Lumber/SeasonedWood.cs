using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class SeasonedWood : UncommonMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public SeasonedWood(ITimber timber)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {timber, GetResourceQuantity(timber.Rarity)}
            };
        }
    }
}