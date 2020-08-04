namespace ToyRobotSimulation
{
    public class CommandRequest
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
