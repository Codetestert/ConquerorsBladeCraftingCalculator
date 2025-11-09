using ConquerorsBladeCraftingCalculator.Interfaces;
using ConquerorsBladeCraftingCalculator.Services;
using Moq;

namespace ConquerorsBladeCraftingCalculator.Tests
{
    public class MarketServiceTests
    {

        [Fact]
        public void GivenItem_LooksUpPriceCorrectly()
        {
            //Arrange
            var example = It.IsAny<ITradable>();
            var marketService = new MarketService();

            //Act
            var result = marketService.GetPrice(example);

            Assert.NotNull(result);
        }
    }
}
