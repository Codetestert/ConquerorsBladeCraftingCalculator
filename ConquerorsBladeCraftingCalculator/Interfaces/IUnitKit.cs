using ConquerorsBladeCraftingCalculator.BaseClasses;

namespace ConquerorsBladeCraftingCalculator.Interfaces
{
    internal interface IUnitKit
    {
        IReadOnlyDictionary<Material, int> RequiredMaterials { get; } //TODO If UnitKit is used as interface, this needs to be fetched from child      
        Rarity Rarity { get; }//TODO If UnitKit is used as interface, this needs to be fetched from child
        int ResupplyCost { get; } //TODO If Material is used as interface, this needs to be fetched from child
        public IReadOnlyDictionary<Rarity, int> CraftingCost => new Dictionary<Rarity, int>() //TODO Now IUnitKit can't be an interface, because this implementation is needed
        {
            {Rarity.Legendary, 200 },
            {Rarity.Epic, 100 },
            {Rarity.Rare, 50 }, //TODO some specific rare kits cost 100
            {Rarity.Uncommon, 25},
            {Rarity.Common, 10}
        };
    }
}
