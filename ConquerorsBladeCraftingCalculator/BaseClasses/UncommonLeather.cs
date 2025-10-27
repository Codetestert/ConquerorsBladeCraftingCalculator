using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Hides;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    internal class UncommonLeather : Material //TODO fix inheritance for Leather so that UncommonLeather, RareLeather and EpicLeather can be merged. Requires different TValue's for DiscretionaryResources, ALL Materials with Rarity.Uncommon require the same TValue's for DiscretionaryResources
    {
        public IReadOnlyDictionary<IResource, int> DiscretionaryResources { get; } = new Dictionary<IResource, int>()
        {
            {new PigSkin(), 10 },
            {new SheepSkin(), 8 },
            {new GoatHide(), 7 },
            {new CowHide(), 6 }
        };
    }
}