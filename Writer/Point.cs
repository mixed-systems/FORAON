using System.Diagnostics;

namespace Writer
{
    [DebuggerDisplay("({X},{Y})")]
    public struct Point
    {
        public float X;
        public float Y;

        public override string ToString() => $"({X.Print()},{Y.Print()})";

        public Point(float ax, float ay) => (X, Y) = (ax, ay);

        public Point Movex(float mx) => new Point(X + mx, Y);
        public Point Movey(float my) => new Point(X, Y + my);

        public void Append(Point that) {
            X += that.X;
            Y += that.Y;
        }
    }
}