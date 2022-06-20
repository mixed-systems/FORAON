namespace Writer
{
    public class Segment : ASegment
    {
        public float Length { get; }
        public Point Center { get; }

        public Segment(float l, Point c) => (Length, Center) = (l, c);
    }

    public class Dot : Draw
    {
        public Dot(Point p) : base(p, 0f)
        {
        }

        public override string Print(string prefix) =>
            $"{prefix ?? ""}\\filldraw[black] ({Point.X.Print()},{Point.Y.Print()}) circle (1pt);";
    }

    public class Connector : Draw, ASegment
    {
        public const float W = 0.3f;
        public static float Width = W * 1.0f; // to scale with diagram

        public double Angle { get; }

        private readonly Dot Mid;
        private readonly Dot Outer;
        private readonly Dot Inner;

        public Connector(Point p, double a) : base(p, Width)
        {
            Length = Width;
            Angle = a;
            Center = p;

            Mid = new Dot(p);

            var s = this as ASegment;

            var outer = s.get_point(3, 0, Angle);

            outer.Append(p);
            Outer = new Dot(outer);

            var inner = s.get_point(3, 2, Angle);

            inner.Append(p);
            Inner = new Dot(inner);
        }

        public override string Print(string prefix)
        {
            Accumulator.Clear();

            Accumulator.AppendLine(Mid.Print(prefix + "    "));
            Accumulator.AppendLine(Outer.Print(prefix + "    "));
            Accumulator.AppendLine(Inner.Print(prefix + "    "));

            return Accumulator.ToString();
        }

        public float Length { get; }
        public Point Center { get; }
    }
}
