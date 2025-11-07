using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class RareMaterial : Material //TODO Rare generic maken voor T = Material, Resource, UnitKit? 
    {
        public override Rarity Rarity { get; } = Rarity.Rare;
        public override int CraftingCost { get; } = 5;
        public int GetResourceQuantity(Rarity resourceRarity) => resourceRarity switch
        {
            Rarity.Common => 25,
            Rarity.Uncommon => 10,
            Rarity.Rare => 8,
            Rarity.Epic => 7,
            _ => throw new ArgumentOutOfRangeException(nameof(resourceRarity))
        };
    }
}