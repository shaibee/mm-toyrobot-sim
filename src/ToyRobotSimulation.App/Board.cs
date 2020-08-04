using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation
{
    public class Board
    {
        public Board(int dimX, int dimY)
        {
            MaxDimensionX = dimX;
            MaxDimensionY = dimY;
            MinDimensionX = 0;
            MinDimensionY = 0;
        }

        public int MaxDimensionX { get; private set; }
        public int MaxDimensionY { get; private set; }

        public int MinDimensionX { get; private set; }
        public int MinDimensionY { get; private set; }
    }
}
