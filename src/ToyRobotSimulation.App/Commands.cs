using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation
{
    static class Commands
    {
        public const string Place = "PLACE";
        public const string Move = "MOVE";
        public const string Left = "LEFT";
        public const string Right = "RIGHT";
        public const string Report = "REPORT";
        public const string Quit = "QUIT";
    }

    class CommandParams
    {
        public static CommandParams Empty
        {
            get 
            {
                return new CommandParams();
            }
        }
    }

    class PlaceCommandParams : CommandParams
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public PlaceCommandParams(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
    }
}
