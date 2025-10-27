using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Hides.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class FinishedLeather : EpicLeather
    {
        public IReadOnlyDictionary<IResource, int> RequiredResources { get; } = new Dictionary<IResource, int>()
        {
            { new BisonHide(), 1 },
            { new Sinews(), 1 } //TODO add DiscretionaryResource from Parent to this dictionary
        };
        public Rarity Rarity { get; } = Rarity.Epic;
    }
}