using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class CastIron : RareMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }
        public CastIron(IronOre ironOre)
        {           
            RequiredResources =
            [
                new(ironOre, GetResourceQuantity(ironOre.Rarity)),
                new(new Calamine(), 1),
            ];
        }
    }
}