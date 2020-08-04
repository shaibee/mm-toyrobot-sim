using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation.Tests
{
    [TestFixture]
    class GameControllerShould
    {
        [Test]
        public void Move2StepsTowardsEast()
        {
            TestGameController controller = new TestGameController(5, 5);

            controller.RunCommand(Commands.Place, new PlaceCommandParams(0, 0, Direction.NORTH));
            controller.RunCommand(Commands.Right, CommandParams.Empty);
            controller.RunCommand(Commands.Move, CommandParams.Empty);
            controller.RunCommand(Commands.Move, CommandParams.Empty);

            Assert.AreEqual(2, controller.Robot.X);
            Assert.AreEqual(0, controller.Robot.Y);
            Assert.AreEqual(Direction.EAST, controller.Robot.Direction);
        }

        [Test]
        public void Move2StepsTowardsNorthEast()
        {
            TestGameController controller = new TestGameController(5, 5);
            controller.RunCommand(Commands.Place, new PlaceCommandParams(0, 0, Direction.NORTH));
            controller.RunCommand(Commands.Right, CommandParams.Empty);
            controller.RunCommand(Commands.Move, CommandParams.Empty);
            controller.RunCommand(Commands.Left, CommandParams.Empty);
            controller.RunCommand(Commands.Move, CommandParams.Empty);

            Assert.AreEqual(1, controller.Robot.X);
            Assert.AreEqual(1, controller.Robot.Y);
            Assert.AreEqual(Direction.NORTH, controller.Robot.Direction);
        }

        [Test]
        public void NotMoveWithoutPlaceCall()
        {
            TestGameController controller = new TestGameController(5, 5);
            controller.RunCommand(Commands.Right, CommandParams.Empty);

            controller.RunCommand(Commands.Move, CommandParams.Empty);
            controller.RunCommand(Commands.Move, CommandParams.Empty);

            Assert.AreEqual(0, controller.Robot.X);
        }
        
        [Test]
        public void NotMoveWith1x1BoardButChangeDirectionTowardsSouth()
        {
            TestGameController controller = new TestGameController(1, 1);

            controller.RunCommand(Commands.Place, new PlaceCommandParams(0, 0, Direction.NORTH));
            controller.RunCommand(Commands.Right, CommandParams.Empty);
            controller.RunCommand(Commands.Right, CommandParams.Empty);
            controller.RunCommand(Commands.Move, CommandParams.Empty);

            Assert.AreEqual(0, controller.Robot.X);
            Assert.AreEqual(0, controller.Robot.Y);
            Assert.AreEqual(Direction.SOUTH, controller.Robot.Direction);
        }
    }
}
