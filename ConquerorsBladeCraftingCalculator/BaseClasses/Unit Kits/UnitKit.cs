using ConquerorsBladeCraftingCalculator.Enums;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    public abstract class UnitKit : ITradable
    {
        public abstract IReadOnlyList<MaterialQuantity> RequiredMaterials { get; } //TODO some kits require exotic resources, Outriders requires resources exclusively
        public abstract Rarity Rarity { get; }
        public abstract int ResupplyCost { get; }
        public abstract int CraftingCost { get; }
        public override string ToString()
        {
            var requiredMaterials = RequiredMaterials.Select(record => $"{record.Material.GetType().Name} : {record.Quantity}");

            string[] properties =
                [
                    $"Name kit: {GetType().Name}",
                    $"Crafting cost: {CraftingCost}",
                    $"Rarity: {Rarity}",
                    string.Join(Environment.NewLine, requiredMaterials),
                ];

            return string.Join(Environment.NewLine, properties);
        }
    }
}
