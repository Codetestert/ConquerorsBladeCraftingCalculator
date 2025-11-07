using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    public class TannedHide : UncommonMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public TannedHide(IHide hide)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {hide, GetResourceQuantity(hide.Rarity)}
            };
        }
    }
}