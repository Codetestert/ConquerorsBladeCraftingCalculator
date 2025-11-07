using ConquerorsBladeCraftingCalculator.Enums;
using ConquerorsBladeCraftingCalculator.Records;
namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class Material
    {
        public abstract Rarity Rarity { get; }
        public abstract int CraftingCost { get; }
        public abstract IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public override string ToString()
        {
            var requiredResources = RequiredResources.Select(record => $"{record.Resource.GetType().Name} : {record.Quantity}");            

            string[] properties =
                [
                    $"Name material: {GetType().Name}",
                    $"Crafting cost: {CraftingCost}",
                    $"Rarity: {Rarity}",
                    string.Join(Environment.NewLine, requiredResources),
                ];

            return string.Join(Environment.NewLine, properties);
        }
    }
}