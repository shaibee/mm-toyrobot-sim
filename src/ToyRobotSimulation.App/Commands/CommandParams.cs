namespace ToyRobotSimulation
{
    public class CommandParams
    {
        public static CommandParams Empty
        {
            get 
            {
                return new CommandParams();
            }
        }
    }

    public class PlaceCommandParams : CommandParams
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public PlaceCommandParams(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
    }
}
