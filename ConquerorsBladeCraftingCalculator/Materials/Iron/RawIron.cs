using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.BaseClasses.Resources;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class RawIron(IronOre ironOre) : UncommonMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; } =
            [
                new((Resource) ironOre, GetResourceQuantity(ironOre.Rarity)),
            ];
    }
}