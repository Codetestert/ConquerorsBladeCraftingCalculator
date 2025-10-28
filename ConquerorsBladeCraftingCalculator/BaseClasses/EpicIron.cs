using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Iron;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    internal class Iron : EpicMaterial
    {
        private ICollection<Type> AcceptedResources =
        [
            typeof(SideriteOre),
            typeof(Magnetite),
            typeof(Limonite),
            typeof(Haematite)
        ];
        public IReadOnlyDictionary<IResource, int> DiscretionaryResources { get; } = new Dictionary<IResource, int>()
        {
            {new SideriteOre(), 30 },
            {new Magnetite(), 20 },
            {new Limonite(), 15 },
            {new Haematite(), 10 }
        };
    }
}