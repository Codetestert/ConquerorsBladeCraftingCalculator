using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class RawIron : UncommonMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public RawIron(IronOre ironOre)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {ironOre, GetResourceQuantity(ironOre.Rarity)}
            };
        }
    }
}