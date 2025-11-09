using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class UncommonMaterial : Material //TODO make Uncommon generic for T = Material, Resource, UnitKit? 
    {
        public override Rarity Rarity { get; } = Rarity.Uncommon;
        public override int RefiningCost { get; } = 2;

        public int GetResourceQuantity(Rarity resourceRarity) => resourceRarity switch
        {
            Rarity.Common => 10,
            Rarity.Uncommon => 8,
            Rarity.Rare => 7,
            Rarity.Epic => 6,
            _ => throw new ArgumentOutOfRangeException(nameof(resourceRarity))
        };
    }
}