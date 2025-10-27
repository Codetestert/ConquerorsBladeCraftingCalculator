using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    public abstract class Material
    {
       public IReadOnlyDictionary<IResource, int> RequiredResources { get; }
       public Rarity Rarity { get; }

       public IReadOnlyDictionary<Rarity, int> CraftingCost { get; } = new Dictionary<Rarity, int>() //TODO should Material be an interface, and have an abstract class for Rarity? then have Crafting cost as an int on the abstract class, and have each material inherit from rarity and material?
        {
            {Rarity.Legendary, 20 },
            {Rarity.Epic, 20 },
            {Rarity.Rare, 5 },
            {Rarity.Uncommon, 2}
        };
    }
}
