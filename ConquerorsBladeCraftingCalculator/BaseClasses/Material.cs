using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    public class Material
    {
        IReadOnlyDictionary<IResource, int> RequiredResources { get; } //TODO If Material is used as interface, this needs to be fetched from child of child
        Rarity Rarity { get; } //TODO If Material is used as interface, this needs to be fetched from child of child

        public IReadOnlyDictionary<Rarity, int> CraftingCost => new Dictionary<Rarity, int>() //TODO Now Material can't be an interface, because we want this implementation
        {
            {Rarity.Legendary, 20 },
            {Rarity.Epic, 20 },
            {Rarity.Rare, 5 },
            {Rarity.Uncommon, 2}
        };
    }
}
