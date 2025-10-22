using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Materials;

namespace ConquerorsBladeCraftingCalculator.Models
{
    internal class SpearSergeantKit : IUnitKit
    {
        public ICollection<IMaterial> RequiredMaterials = new List<IMaterial>[
            new FinishedLeather(),
            new CompositeWood(),
             new PureIron()
            ];

        public int ResupplyCost => throw new NotImplementedException();

        public string Name => "Spear Sergeant Kit";
    }
}
