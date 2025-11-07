using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    public class FinishedLeather : EpicMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public FinishedLeather(IHide hide)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {hide, GetResourceQuantity(hide.Rarity)},
                {new BisonHide(), 1},
                {new Sinews(), 1}
            };
        }
    }
}