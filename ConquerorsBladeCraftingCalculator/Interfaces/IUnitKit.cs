namespace ConquerorsBladeCraftingCalculator.Interfaces
{
    internal interface IUnitKit
    {
        ICollection<IMaterial> RequiredMaterials { get; set; }
        int ResupplyCost { get; }

        string Name { get; }
    }
}
