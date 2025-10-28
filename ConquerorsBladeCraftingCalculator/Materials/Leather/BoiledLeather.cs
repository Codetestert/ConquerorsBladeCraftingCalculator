using ConquerorsBladeCraftingCalculator.Resources.Hides.Exotics;
using ConquerorsBladeCraftingCalculator.Resources.Stone.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Leather
{
    internal class BoiledLeather : BaseClasses.Leather
    {
        //TODO public override IReadOnlyDictionary<IResource, int> RequiredResources { get; }
        //public BoiledLeather()
        //{
        //    RequiredResources = new Dictionary<IResource, int>(base.RequiredResources)
        //    {
        //        { new MountainWolfFur(), 1 },
        //        { new Nitre(), 1 }
        //    };
        //}

        public BoiledLeather() : base()
        {
            RequiredResources.Add(new MountainWolfFur(), 1);
            RequiredResources.Add(new Nitre(), 1);
        }
    }
}