using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.BaseClasses.Materials;
using ConquerorsBladeCraftingCalculator.Enums;
using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.UnitKits;
using Moq;
namespace ConquerorsBladeCraftingCalculator.Tests
{
    public class ProgramTests
    {
        //Unit kits:
        //Buy unit kits outright on Market(V, Auction house)
        //Trade colonies have a 2nd Smuggler who sells random unit kits, in the map legend they're under military trades
        //Buy with bronze in barracks
        //Buy materials on Market > craft unit Kit
        //Buy resources on Market > refine materials > craft unit kit
        //Openworld trading posts sells random exotics, needed to craft rare and up materials

        // Atillery:
        //Buy atillery outright on Market(V, Auction house)
        //Siege engineer sells only uncommon atillery 3200 - 3500
        //Openworld trading posts sells random rare atillery
        //Buy atillery components on Market > Trade with siege engineer
        //Buy materials on Market > craft atillery
        //Buy resources on Market > refine materials > craft atillery     
        [Fact]
        public void GivenUnitKit_CorrectlyTellsIfCraftingIsCheaper()
        {
            //Arrange
            var example = It.IsAny<UnitKit>();
            var mockMarket = new Mock<IMarketService>();
            var mockTradepost = new Mock<ITradeColonyService>();
            mockMarket.Setup(m => m.GetPrice(example, 1)).Returns(850);
            mockMarket.Setup(m => m.GetPrice(It.IsAny<IResource>(), 1)).Returns(2);
            mockTradepost.Setup(m => m.GetPrice(example)).Returns(860);
            var advisor = new Program(mockMarket.Object, mockTradepost.Object);            
            var expected = Advice.BuyMaterials;

            //Act
            var result = advisor.CalculateCheapestAdvice(example);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenUnitKit_CorrectlyTellsCheapestPrice()
        {
            //Arrange
            var example = new SpearSergeant(); //TODO figure out why It.IsAny<UnitKit>(); just doesn't make a random unit kit 
            var mockMarket = new Mock<IMarketService>();
            var mockTradepost = new Mock<ITradeColonyService>();
            mockMarket.Setup(m => m.GetPrice(example, 1)).Returns(850);
            mockMarket.Setup(m => m.GetPrice(It.IsAny<Material>(), 1)).Returns(30); //TODO figure out why this doesn't return 30 when you pass in a random material
            mockMarket.Setup(m => m.GetPrice(It.IsAny<IResource>(), 1)).Returns(2);//TODO figure out why this doesn't return 2 when you pass in a random Resource
            mockTradepost.Setup(m => m.GetPrice(example)).Returns(800);
            var advisor = new Program(mockMarket.Object, mockTradepost.Object);
            var expected = 800;

            //Act
            var result = advisor.CalculateCheapestPrice(example);

            Assert.Equal(expected, result);
        }
    }
}
