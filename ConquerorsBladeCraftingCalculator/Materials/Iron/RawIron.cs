using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class RawIron : UncommonMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public RawIron(IronOre ironOre)
        {
            RequiredResources =
            [
                new(ironOre, GetResourceQuantity(ironOre.Rarity)),
            ];
        }
    }
}