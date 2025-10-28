namespace ConquerorsBladeCraftingCalculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        //Unit kits:
        //Buy unit kits outright on Market(V, Auction house)
        //Trade colonies have a 2nd Smuggler who sells random unit kits, in the map legend they're under military trades
        //Buy with bronze in barracks
        //Buy materials on Market > craft unit Kit
        //Buy resources on Market > refine materials > craft unit kit
        //Openworld trading posts sells random exotics, needed to craft rare and up materials

        // Atillery:
        //            Buy atillery outright on Market(V, Auction house)
        //Siege engineer sells only uncommon atillery 3200 - 3500
        //Openworld trading posts sells random rare atillery
        //Buy atillery components on Market > Trade with siege engineer
        //Buy materials on Market > craft atillery
        //Buy resources on Market > refine materials > craft atillery
        public void GivenUnitKit_CorrectlyTellsWhichIsCheaper()
        {

            //Arrange
            var example = true;

            //Act
            var result = Program.DoThing(example);

            Assert.True(result);
        }
    }
}
