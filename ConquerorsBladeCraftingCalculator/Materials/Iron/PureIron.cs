using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Records;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class PureIron : EpicMaterial
    {
        public override IReadOnlyList<ResourceQuantity> RequiredResources { get; }        
        public PureIron(IronOre ironOre)
        {
            RequiredResources =
            [
                new(ironOre, GetResourceQuantity(ironOre.Rarity)),
                new(new MountainBauxite(), 1),
                new(new Coal(), 1),
            ];
        }
    }
}