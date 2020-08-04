using NUnit.Framework;
using ToyRobotSimulation;

namespace ToyRobotSimulation.Tests
{
    [TestFixture]
    public class CommandProcessorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnPlaceCommand()
        {
            CommandRequest commandRequest = CommandProcessor.Process("PLACE 1,2,EAST");

            Assert.AreEqual(true, commandRequest.IsCommandValid);
            Assert.AreEqual(Commands.Place, commandRequest.Command);
            Assert.IsAssignableFrom(typeof(PlaceCommandParams), commandRequest.Params);
        }

        [Test]
        public void ShouldReturnMoveCommand()
        {
            CommandRequest commandRequest = CommandProcessor.Process("move");

            Assert.AreEqual(true, commandRequest.IsCommandValid);
            Assert.AreEqual(Commands.Move, commandRequest.Command);
            Assert.IsAssignableFrom(typeof(CommandParams), commandRequest.Params);
        }

        [Test]
        public void ShouldReturnInvalidCommand()
        {
            CommandRequest commandRequest = CommandProcessor.Process("invalidcommand");

            Assert.AreEqual(false, commandRequest.IsCommandValid);
        }
    }
}