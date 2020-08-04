using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulation
{
    class CommandProcessor
    {
        public static CommandRequest Process(string line)
        {
            string[] commandParts = line.Split(' ');
            if (commandParts == null || commandParts.Length == 0)
            {
                return new CommandRequest();    // Invalid Command
            }

            string command = commandParts[0].ToUpperInvariant();
            switch (command)
            {
                case Commands.Place:
                    if (commandParts.Length > 1)
                    {
                        string argsPart = commandParts[1];
                        string[] arguments = argsPart.Split(',');

                        if (arguments.Length > 2)
                        {
                            int x, y;
                            object direction;

                            bool result = Int32.TryParse(arguments[0], out x);
                            result &= Int32.TryParse(arguments[1], out y);
                            result &= Enum.TryParse(typeof(Direction), arguments[2].ToUpperInvariant(), out direction);

                            if (result)
                            {
                                PlaceCommandParams commandParams = new PlaceCommandParams(x, y, (Direction)direction);
                                return new CommandRequest(Commands.Place, commandParams);
                            }
                        }
                    }
                    break;
                case Commands.Left:
                case Commands.Right:
                case Commands.Move:
                case Commands.Report:
                case Commands.Quit:
                    return new CommandRequest(command, CommandParams.Empty);

                default:
                    break;

            }

            return new CommandRequest(); //Invalid 
        }
    }

    class CommandRequest
    {
        public CommandRequest()
        {
            IsCommandValid = false;
        }

        public CommandRequest(string command, CommandParams param)
        {
            Command = command;
            Params = param;
            IsCommandValid = true;
        }

        public string Command { get; private set; }
        public CommandParams Params { get; private set; }
        public bool IsCommandValid { get; private set; }       
    }
}
