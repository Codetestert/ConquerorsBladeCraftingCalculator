using ConquerorsBladeCraftingCalculator.Enums;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class EpicMaterial : Material //TODO Epic generic maken voor T = Material, Resource, UnitKit? 
    {
        public override Rarity Rarity { get; } = Rarity.Epic;
        public override int CraftingCost { get; } = 20;
        public int GetResourceQuantity(Rarity resourceRarity) => resourceRarity switch
        {
            Rarity.Common => 30,
            Rarity.Uncommon => 20,
            Rarity.Rare => 15,
            Rarity.Epic => 10,
            _ => throw new ArgumentOutOfRangeException(nameof(resourceRarity))
        };
    }
}