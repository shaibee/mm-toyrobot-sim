using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation.Tests
{
    [TestFixture]
    public class RobotShould
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Move2StepsTowardsEast()
        {
            IRobot robot = new Robot();
            robot.Place(0, 0, Direction.NORTH);
            robot.Right();
            robot.Move();
            robot.Move();

            Assert.AreEqual(2, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual(Direction.EAST, robot.Direction);
        }

        [Test]
        public void Move2StepsTowardsNorthEast()
        {
            IRobot robot = new Robot();
            robot.Place(0, 0, Direction.NORTH);
            robot.Right();
            robot.Move();
            robot.Left();
            robot.Move();

            Assert.AreEqual(1, robot.X);
            Assert.AreEqual(1, robot.Y);
            Assert.AreEqual(Direction.NORTH, robot.Direction);
        }

        [Test]
        public void Move2StepsWithoutPlaceCall()
        {
            IRobot robot = new Robot();
            robot.Right();
            robot.Move();
            robot.Move();

            Assert.AreEqual(2, robot.X);
        }

        [Test]
        public void ReturnReport()
        {
            IRobot robot = new Robot();
            robot.Place(0, 0, Direction.NORTH);
            robot.Right();
            robot.Move();
            robot.Left();
            robot.Move();


            Assert.AreEqual("Output: 1, 1, NORTH", robot.GetReport());
        }

    }
}
