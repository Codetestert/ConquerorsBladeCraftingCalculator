using ConquerorsBladeCraftingCalculator.Enums;
using ConquerorsBladeCraftingCalculator.Interfaces;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConquerorsBladeCraftingCalculator.BaseClasses.Materials
{
    public abstract class Material
    {
        public abstract Rarity Rarity { get; }
        public abstract int CraftingCost { get; }
        public abstract IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        public override string ToString()
        {
            return $"Name material: {GetType().Name}" +
                   $"Crafting cost: {CraftingCost}" +
                   $"Rarity: {Rarity}" +
            string.Join(Environment.NewLine, RequiredResources.Select(kvp => $"{kvp.Key} : {kvp.Value.ToString()}")); 
        }
    }
}