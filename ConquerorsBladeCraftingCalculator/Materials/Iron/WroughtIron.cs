using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Iron
{
    public class WroughtIron : EpicMaterial
    {
        public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public WroughtIron(IronOre ironOre)
        {
            RequiredResources = new Dictionary<IResource, int>()
            {
                {ironOre, GetResourceQuantity(ironOre.Rarity)},
                {new Tungsten(), 1},
                {new BlackManganese(), 1}
            };
        }
    }
}