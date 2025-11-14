using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class RareMaterial : Material
    {
        public override Rarity Rarity { get; } = Rarity.Rare;
        public override int RefiningCost { get; } = 5;
        public static int GetResourceQuantity(Rarity resourceRarity) => resourceRarity switch
        {
            Rarity.Common => 25,
            Rarity.Uncommon => 10,
            Rarity.Rare => 8,
            Rarity.Epic => 7,
            _ => throw new ArgumentOutOfRangeException(nameof(resourceRarity))
        };
    }
}