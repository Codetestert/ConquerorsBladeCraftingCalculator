using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class UncommonMaterial : Material 
    {
        public override Rarity Rarity { get; } = Rarity.Uncommon;
        public override int RefiningCost { get; } = 2;

        public static int GetResourceQuantity(Rarity resourceRarity) => resourceRarity switch
        {
            Rarity.Common => 10,
            Rarity.Uncommon => 8,
            Rarity.Rare => 7,
            Rarity.Epic => 6,
            _ => throw new ArgumentOutOfRangeException(nameof(resourceRarity))
        };
    }
}