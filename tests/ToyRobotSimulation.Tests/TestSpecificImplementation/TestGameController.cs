using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation.Tests
{
    class TestGameController : GameController
    {
        public TestGameController(int dimX, int dimY) 
            : base(dimX, dimY)
        {

        }
        public IRobot Robot { get { return _robot; } }
    }
}
