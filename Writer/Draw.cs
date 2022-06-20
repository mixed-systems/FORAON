using System.Text;

namespace Writer
{
    public abstract class Draw
    {
        public Point Point { get; }
        public float Size { get; }

        protected Draw(Point p, float s) => (Point, Size) = (p,s);
        protected StringBuilder Accumulator = new StringBuilder();

        public abstract string Print(string prefix);
    }
}