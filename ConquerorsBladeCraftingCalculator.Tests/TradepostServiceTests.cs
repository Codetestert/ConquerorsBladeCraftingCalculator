using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Services;
using Moq;

namespace ConquerorsBladeCraftingCalculator.Tests
{
    public class TradepostServiceTests
    {

        [Fact]
        public void GivenItem_LooksUpPriceCorrectly()
        {
            //Arrange
            var example = It.IsAny<ITradable>();
            var tradepostService = new TradeColonyService();

            //Act
            var result = tradepostService.GetPrice(example);

            Assert.NotNull(result);
        }
    }
}
