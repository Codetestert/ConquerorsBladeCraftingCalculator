using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    public abstract class UnitKit
    {
        public IReadOnlyDictionary<Material, int> RequiredMaterials { get; } 
        public Rarity Rarity { get; }
        public int ResupplyCost { get; }
        public IReadOnlyDictionary<Rarity, int> CraftingCost { get; } = new Dictionary<Rarity, int>()
        {
            {Rarity.Legendary, 200 },
            {Rarity.Epic, 100 },
            {Rarity.Rare, 50 }, //TODO some specific rare kits cost 100
            {Rarity.Uncommon, 25},
            {Rarity.Common, 10}
        };
    }
}
