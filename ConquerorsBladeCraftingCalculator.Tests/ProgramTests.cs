namespace ConquerorsBladeCraftingCalculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Test1()
        {

            //Arrange
            var example = true;

            //Act
            var result = Program.DoThing(example);

            Assert.True(result);
        }
    }
}
