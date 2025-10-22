namespace ConquerorsBladeCraftingCalculator.Interfaces
{
    internal interface IMaterial
    {
        ICollection<IResource> RequiredResources { get; set; }
    }
}
