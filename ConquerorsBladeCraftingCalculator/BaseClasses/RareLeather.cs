using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Hides;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    internal class RareLeather : Material //TODO fix inheritance for Leather so that EpicLeather, UncommonLeather and RareLeather can be merged. Requires different TValue's for DiscretionaryResources, ALL Materials with Rarity.Rare require the same TValue's for DiscretionaryResources
    {
        public IReadOnlyDictionary<IResource, int> DiscretionaryResources { get; } = new Dictionary<IResource, int>()
        {
            {new PigSkin(), 25 },
            {new SheepSkin(), 10 },
            {new GoatHide(), 8 },
            {new CowHide(), 7 }
        };
    }
}