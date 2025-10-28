using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.Resources.Hides.Exotics
{
    internal  class EpicResource : IResource
    {
        Rarity IResource.Rarity { get; } = Rarity.Epic;
    }
}