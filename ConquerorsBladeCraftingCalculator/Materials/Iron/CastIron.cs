using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.BaseClasses.Resources;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class CastIron(IronOre ironOre) : RareMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; } =
            [
                new((Resource)ironOre, GetResourceQuantity(ironOre.Rarity)),
                new(new Calamine(), 1),
            ];
    }
}