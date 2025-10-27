using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class TannedHide : UncommonLeather
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources { get; } = new Dictionary<IResource, int>()
        {
            //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity { get; } = Rarity.Uncommon;
    }
}