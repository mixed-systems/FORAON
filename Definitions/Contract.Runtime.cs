namespace Definitions
{
    partial class Contract
    {
        public static readonly HashSet<Contract> Storage = new ();

        public Contract() => Storage.Add(this);

        public partial void Rotate(Direction x)
        {
            if (null == Axis || Rotate(Axis.Value, x)) Swap();
        }

        void Swap() => (Sides[0], Sides[1]) = (Sides[1], Sides[0]);

        bool Rotate(Orientation x, Direction h)
        {
            Axis = Orientation.Primary == x ?
                Orientation.Secondary :
                Orientation.Primary;

            return (Orientation.Primary == x && Direction.Negative == h ||
                    Orientation.Secondary == x && Direction.Positive == h);
        }
    }
}
