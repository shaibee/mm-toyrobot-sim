namespace ToyRobotSimulation
{
    public interface IRobot
    {
        Direction Direction { get; }
        bool IsPlaced { get; }
        int X { get; }
        int Y { get; }

        void Left();
        void Move();
        void Place(int x, int y, Direction direction);
        void Report();
        void Right();
    }
}