using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class CompositeWood : EpicMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public CompositeWood(ITimber timber)
        {
            RequiredResources = 
            [
                new(timber, GetResourceQuantity(timber.Rarity)),
                new(new Yew(), 1),
                new(new Coal(), 1)
            ];
        }
    }
}