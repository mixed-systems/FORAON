namespace Definitions
{
    public partial class Contract
    {
        public class Side
        {
            public Direction Direction;
            public dynamic? This;
        }

        public readonly Side[] Sides =
        {
            new Side { Direction = Direction.Positive },
            new Side { Direction = Direction.Negative }
        };

        public Orientation? Axis;

        public dynamic? This;

        public partial void Rotate(Direction x);
    }
}
