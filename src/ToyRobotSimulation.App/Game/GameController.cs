using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace ToyRobotSimulation
{
    public class GameController : IGameController
    {
        private readonly Board _board;
        protected readonly Robot _robot;

        public GameController(int boardDimensionsX, int boardDimensionsY)
        {
            _board = new Board(boardDimensionsX, boardDimensionsY);
            _robot = new Robot();
        }

        public void RunCommand(string command, CommandParams commandParams)
        {
            switch (command)
            {
                case Commands.Place:
                    SafePlace((PlaceCommandParams)commandParams);
                    break;

                case Commands.Move:
                    SafeMove();
                    break;

                case Commands.Left:
                    SafeLeft();
                    break;

                case Commands.Right:
                    SafeRight();
                    break;

                case Commands.Report:
                    SafeReport();
                    break;
            }
        }

        private void SafePlace(PlaceCommandParams commandParams)
        {
            if (IsPlacementValid(commandParams.X, commandParams.Y))
            {
                _robot.Place(commandParams.X, commandParams.Y, commandParams.Direction);
            }
        }

        private bool IsPlacementValid(int x, int y)
        {
            if (x < _board.MinDimensionX || x >= _board.MaxDimensionX)
            {
                return false;
            }

            if (y < _board.MinDimensionY || y >= _board.MaxDimensionY)
            {
                return false;
            }

            return true;
        }

        private void SafeMove()
        {
            if (_robot.IsPlaced && !IsRobotOnEdge())
            {
                _robot.Move();
            }
        }


        private void SafeLeft()
        {
            if (_robot.IsPlaced)
            {
                _robot.Left();
            }
        }
        private void SafeRight()
        {
            if (_robot.IsPlaced)
            {
                _robot.Right();
            }
        }
        private void SafeReport()
        {
            if (_robot.IsPlaced)
            {
                string report = _robot.GetReport();
                Console.WriteLine(report);
            }
        }

        private bool IsRobotOnEdge()
        {
            switch (_robot.Direction)
            {
                case Direction.NORTH:
                    return (_robot.Y + 1) >= _board.MaxDimensionY;

                case Direction.EAST:
                    return (_robot.X + 1) >= _board.MaxDimensionX;

                case Direction.SOUTH:
                    return (_robot.Y - 1) < _board.MinDimensionY;

                case Direction.WEST:
                    return (_robot.X - 1) < _board.MinDimensionX;
            }

            return true;
        }

    }
}
