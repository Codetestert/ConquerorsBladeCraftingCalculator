using ConquerorsBladeCraftingCalculator.Enums;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class Material : ITradable
    {
        public abstract Rarity Rarity { get; }
        public abstract int RefiningCost { get; }
        public abstract IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public override string ToString()
        {
            var requiredResources = RequiredResources.Select(record => $"{record.Resource.GetType().Name} : {record.Quantity}");            

            string[] properties =
                [
                    $"Name material: {GetType().Name}",
                    $"Refining cost: {RefiningCost}",
                    $"Rarity: {Rarity}",
                    string.Join(Environment.NewLine, requiredResources),
                ];

            return string.Join(Environment.NewLine, properties);
        }
    }
}