namespace ToyRobotSimulation
{
    public interface IRobot
    {
        Direction Direction { get; }
        bool IsPlaced { get; }
        int X { get; }
        int Y { get; }

        void Place(int x, int y, Direction direction);
        string GetReport();
        void Right();
        void Left();
        void Move();

    }
}