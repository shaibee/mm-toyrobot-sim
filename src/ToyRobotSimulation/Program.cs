using System;

namespace ToyRobotSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                string line = Console.ReadLine();
                string[] commandParts = line.Split(' ');
                if ( commandParts == null || commandParts.Length == 0)
                {
                    Console.WriteLine("Please enter correct command");
                    continue;
                }

                string command = commandParts[0].ToUpperInvariant();
                switch (command)
                {
                    case Commands.Place:

                        break;
                    case Commands.Move:
                        break;
                    case Commands.Left:
                        break;
                    case Commands.Right:
                        break;
                    case Commands.Report:
                        break;
                    case Commands.Quit:
                        break;
                    default:
                        break;
                }
            } 


            Test21();

            Console.ReadKey();
        }

        private static void Test1()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, Direction.North);
            robot.Move();
            robot.Report();
        }

        private static void Test2()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, Direction.North);
            robot.Left();
            robot.Report();
        }

        private static void Test21()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, Direction.West);
            robot.Right();
            robot.Report();
        }

        private static void Test3()
        {
            Robot robot = new Robot();
            robot.Place(1, 2, Direction.East);
            robot.Move();
            robot.Move();
            robot.Left();
            robot.Move();
            robot.Report();
        }
    }
}
