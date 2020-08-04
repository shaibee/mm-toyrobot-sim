using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation
{
    public enum Direction   // Clockwise
    {
        North = 0,
        East,
        South,
        West
    }
    public class Robot
    {
        private int _x;
        private int _y;
        private Direction _direction;


        public Robot()
        {

        }

        public void Place(int x, int y, Direction direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public void Left()
        {          
            _direction = _direction - 1;
            _direction = (Direction)Mod(Convert.ToInt32(_direction), 4);
        }

        public void Right()
        {
            _direction = _direction + 1;
            _direction = (Direction)Mod(Convert.ToInt32(_direction), 4);
        }

        public void Move()
        {
            switch (_direction)
            {
                case Direction.North:
                    MoveNorth();
                    break;

                case Direction.East:
                    MoveEast();
                    break;

                case Direction.South:
                    MoveSouth();
                    break;

                case Direction.West:
                    MoveWest();
                    break;
            }
        }

        private int Mod(int x, int m)
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }

        private void MoveWest()
        {
            if (--_x < 0)
            {
                _x = 0;
            }
        }

        private void MoveSouth()
        {
            if (--_y < 0)
            {
                _y = 0;
            }
        }

        private void MoveEast()
        {
            if (++_x > 4)
            {
                _x = 4;
            }
        }

        private void MoveNorth()
        {
            if (++_y > 4)
            {
                _y = 4;
            }
        }

        public void Report()
        {
            Console.WriteLine($"Output: {_x}, {_y}, {_direction.ToString().ToUpper()}");
        }
    }
}
