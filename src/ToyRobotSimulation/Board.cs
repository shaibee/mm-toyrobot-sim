using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation
{
    public class Board
    {
        private const int xLimit = 5;
        private const int yLimit = 5;
        
        public Board()
        {
            X = 0;
            Y = 0;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
