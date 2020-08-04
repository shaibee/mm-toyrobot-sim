using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation.App
{
    class TestRun
    {
        public static void PlayTestRuns()
        {
            Test1();
            Test2();
            Test3();
            Test4();

        }
        private static void Test1()
        {
            Console.WriteLine("PLACE 0,0,NORTH");
            Console.WriteLine("MOVE");
            Console.WriteLine("REPORT");

            List<CommandRequest> commandRequests = new List<CommandRequest>();
            commandRequests.Add(CommandProcessor.Process("PLACE 0,0,NORTH"));
            commandRequests.Add(CommandProcessor.Process("MOVE"));
            commandRequests.Add(CommandProcessor.Process("REPORT"));

            Play(commandRequests);
            Console.WriteLine("------------------------------------------");
        }

        private static void Test2()
        {
            Console.WriteLine("PLACE 0,0,NORTH");
            Console.WriteLine("LEFT");
            Console.WriteLine("REPORT");

            List<CommandRequest> commandRequests = new List<CommandRequest>();
            commandRequests.Add(CommandProcessor.Process("PLACE 0,0,NORTH"));
            commandRequests.Add(CommandProcessor.Process("LEFT"));
            commandRequests.Add(CommandProcessor.Process("REPORT"));

            Play(commandRequests);
            Console.WriteLine("------------------------------------------");
        }

        private static void Test3()
        {
            Console.WriteLine("PLACE 0,0,WEST");
            Console.WriteLine("RIGHT");
            Console.WriteLine("REPORT");

            List<CommandRequest> commandRequests = new List<CommandRequest>();
            commandRequests.Add(CommandProcessor.Process("PLACE 0,0,WEST"));
            commandRequests.Add(CommandProcessor.Process("RIGHT"));
            commandRequests.Add(CommandProcessor.Process("REPORT"));

            Play(commandRequests);
            Console.WriteLine("------------------------------------------");
        }

        private static void Test4()
        {
            Console.WriteLine("PLACE 1,2,EAST");
            Console.WriteLine("MOVE");
            Console.WriteLine("MOVE");
            Console.WriteLine("LEFT");
            Console.WriteLine("MOVE");
            Console.WriteLine("REPORT");

            List<CommandRequest> commandRequests = new List<CommandRequest>();
            commandRequests.Add(CommandProcessor.Process("PLACE 1,2,EAST"));
            commandRequests.Add(CommandProcessor.Process("MOVE"));
            commandRequests.Add(CommandProcessor.Process("MOVE"));
            commandRequests.Add(CommandProcessor.Process("LEFT"));
            commandRequests.Add(CommandProcessor.Process("MOVE"));
            commandRequests.Add(CommandProcessor.Process("REPORT"));

            Play(commandRequests);
            Console.WriteLine("------------------------------------------");
        }

        private static void Play(List<CommandRequest> commandRequests)
        {
            GameController gameController = new GameController(5, 5);
            foreach (var commandRequest in commandRequests)
            {
                gameController.RunCommand(commandRequest.Command, commandRequest.Params);
            }
        }
    }
}
