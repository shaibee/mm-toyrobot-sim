using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ToyRobotSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(5, 5);

            while (true)
            {
                string line = Console.ReadLine();
                CommandRequest commandRequest = CommandProcessor.Process(line);

                if (!commandRequest.IsCommandValid)
                {
                    Console.WriteLine("Please enter a valid command.");
                    Console.WriteLine("PLACE, MOVE, LEFT, RIGHT, REPORT, QUIT");
                    continue;
                }

                switch (commandRequest.Command)
                {
                    case Commands.Quit:
                        Environment.Exit(0);
                        break;

                    default:
                        game.RunCommand(commandRequest.Command, commandRequest.Params);
                        break;
                }
            } 


            //Test21();

            //Console.ReadKey();
        }

        private static void Test1()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, Direction.NORTH);
            robot.Move();
            robot.Report();
        }

        private static void Test2()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, Direction.NORTH);
            robot.Left();
            robot.Report();
        }

        private static void Test21()
        {
            Robot robot = new Robot();
            robot.Place(0, 0, Direction.WEST);
            robot.Right();
            robot.Report();
        }

        private static void Test3()
        {
            Robot robot = new Robot();
            robot.Place(1, 2, Direction.EAST);
            robot.Move();
            robot.Move();
            robot.Left();
            robot.Move();
            robot.Report();
        }
    }


}
