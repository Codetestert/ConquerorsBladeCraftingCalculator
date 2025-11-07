using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class PureIron : EpicMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }        
        public PureIron(IronOre ironOre)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {ironOre, GetResourceQuantity(ironOre.Rarity)},
                {new MountainBauxite(), 1},
                {new Coal(), 1}
            };
        }
    }
}