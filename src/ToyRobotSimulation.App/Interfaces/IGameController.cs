namespace ToyRobotSimulation
{
    public interface IGameController
    {
        void RunCommand(string command, CommandParams commandParams);
    }
}