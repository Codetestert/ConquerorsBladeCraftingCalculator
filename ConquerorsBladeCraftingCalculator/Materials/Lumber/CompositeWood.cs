using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Resources.Stone.Exotics;
using ConquerorsBladeCraftingCalculator.Resources.Timber;
using ConquerorsBladeCraftingCalculator.Resources.Timber.Exotics;

namespace ConquerorsBladeCraftingCalculator.Materials.Lumber
{
    public class CompositeWood
    {
        public Dictionary<IResource, int> RequiredResources { get; } = new()
        {
            {new Yew(), 1},
            {new Coal(), 1}
        };

        public CompositeWood(Timber timber)
        {
            int quantity = timber switch
            {
                PineTimber => 30,
                AshTimber => 20,
                OakTimber => 15,
                CedarTimber => 10,
                _ => throw new ArgumentException("Unknown timber type", nameof(timber))
            };

            RequiredResources.Add(timber, quantity);
            //switch (timber)
            //      {
            //          case PineTimber:
            //              quantity = 30;
            //              break;
            //          case AshTimber:
            //              quantity = 20;
            //              break;
            //          case OakTimber:
            //              quantity = 15;
            //              break;
            //          case CedarTimber:
            //              quantity = 10;
            //              break;
            ////          default:
            //              throw new ArgumentException("Unknown timber type", nameof(timber));     

        }
        public Rarity Rarity { get; } = Rarity.Epic;
    }

    public class Timber : IResource
    {
        public Rarity Rarity => throw new NotImplementedException();
    }
}