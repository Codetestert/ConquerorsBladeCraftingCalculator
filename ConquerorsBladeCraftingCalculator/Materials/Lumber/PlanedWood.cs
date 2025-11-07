using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class PlanedWood : RareMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public PlanedWood(ITimber timber)
        {
            RequiredResources =
            [
                new(timber, GetResourceQuantity(timber.Rarity)),
                new(new Sinews(), 1),
            ];               
        }
    }
}