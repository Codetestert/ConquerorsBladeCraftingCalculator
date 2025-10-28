using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator.BaseClasses
{
    public class EpicMaterial : Material
    {
        public Dictionary<int, IResource> DiscretionaryResources { get; } = new()
        {
            {30, null},
            {20, null},
            {15, null},
            {10, null}
        };

        public int CraftingCost { get; } = 20;       
    }
}