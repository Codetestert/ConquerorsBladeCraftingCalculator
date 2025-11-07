using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class CastIron : RareMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public CastIron(IronOre ironOre)
        {           
            RequiredResources = new Dictionary<IResource, int>()
            {
                {ironOre, GetResourceQuantity(ironOre.Rarity)},
                {new Calamine(), 1}
            };
        }
    }
}