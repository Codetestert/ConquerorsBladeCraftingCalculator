using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    internal class EpicLeather : Material //TODO drop "epic" from leather so TreatedLeather and TannedHide can also inherit it, but that requires different TValue for DiscretionaryResources, also, ALL Materials with Rarity.Epic require the same TValue's for DiscretionaryResources
    {
        public IReadOnlyDictionary<IResource, int> DiscretionaryResources => new Dictionary<IResource, int>()
        {
            {new PigSkin(), 30 },
            {new SheepSkin(), 20 },
            {new GoatHide(), 15 },
            {new CowHide(), 10 }
        };       
    }
}