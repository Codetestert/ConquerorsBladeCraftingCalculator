using ConquerorsBladeCraftingCalculator.BaseClasses.Resources;

namespace ConquerorsBladeCraftingCalculator.Records
{
    public sealed record ResourceQuantity(Resource Resource, int Quantity)
    {
        //public ResourceQuantity(IResource Resource, int Quantity)
        //{
        //    if (Quantity <= 0)
        //        throw new ArgumentOutOfRangeException(nameof(Quantity), "Quantity must be positive.");
        //}
    }
}
