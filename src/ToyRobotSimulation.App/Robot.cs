using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation
{
    public enum Direction   // Clockwise
    {
        NORTH = 0,
        EAST,
        SOUTH,
        WEST
    }
    public class Robot
    {

        public Robot()
        {

        }

        public void Place(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
            IsPlaced = true;
        }

        public void Left()
        {          
            Direction = Direction - 1;
            Direction = (Direction)Mod(Convert.ToInt32(Direction), 4);
        }

        public void Right()
        {
            Direction = Direction + 1;
            Direction = (Direction)Mod(Convert.ToInt32(Direction), 4);
        }

        public void Move()
        {
            switch (Direction)
            {
                case Direction.NORTH:
                    MoveNorth();
                    break;

                case Direction.EAST:
                    MoveEast();
                    break;

                case Direction.SOUTH:
                    MoveSouth();
                    break;

                case Direction.WEST:
                    MoveWest();
                    break;
            }
        }

        public void Report()
        {
            Console.WriteLine($"Output: {X}, {Y}, {Direction.ToString().ToUpperInvariant()}");
        }

        public int X { get; private set; }
        public int Y { get; private set;  }
        public Direction Direction { get; private set; }
        public bool IsPlaced { get; private set; }

        private int Mod(int x, int m)
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }

        private void MoveWest()
        {
            X--;
        }

        private void MoveSouth()
        {
            Y--;
        }

        private void MoveEast()
        {
            X++;
        }

        private void MoveNorth()
        {
            Y++;
        }

    }
}
