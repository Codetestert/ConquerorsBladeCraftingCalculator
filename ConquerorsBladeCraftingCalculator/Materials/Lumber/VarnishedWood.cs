using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class VarnishedWood : EpicMaterial //TODO Rename folder name to Wood?
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public VarnishedWood(ITimber timber)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {timber, GetResourceQuantity(timber.Rarity)},
                {new LinseedOil(), 1},
                {new Larch(), 1}
            };
        }
    }
}