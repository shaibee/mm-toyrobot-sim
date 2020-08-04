using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ToyRobotSimulation.App;

namespace ToyRobotSimulation
{
    class Program
    {
        static void Main(string[] args)
        {

            if ( args != null && args.Length > 0)
            {
                string arg = args[0];
                if (arg == "testrun")
                {
                    TestRun.PlayTestRuns();
                }

                Console.WriteLine("Press any key to exit ...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            GameController game = new GameController(5, 5);
            ShowHelp();

            while (true)
            {
                string line = Console.ReadLine();
                CommandRequest commandRequest = CommandProcessor.Process(line);

                if (!commandRequest.IsCommandValid)
                {
                    ShowHelp();
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
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Please enter a valid command.");
            Console.WriteLine("PLACE, MOVE, LEFT, RIGHT, REPORT, QUIT");
        }
    }


}
