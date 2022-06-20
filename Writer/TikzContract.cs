namespace Writer
{
    public class TikzContract : Draw, ASegment
    {
        public const float W = 3f;
        public static float Width = W * 1.0f; // to scale with diagram

        public TikzPrimitive Root, Positive, Negative;

        public Connector CPositive, CNegative;
        public double Angle { get; }

        public TikzContract(Point p, double a) : base(p, Width)
        {
            Angle = a;
            Length = Width;
            Center = p;
            Root = new TikzPrimitive(p, a, TikzPaint.Opposition);

            ASegment? s = this;

            Point p1;

            Positive = new TikzPrimitive(p1 = s.get_point(5, 4, a), a, TikzPaint.Positive);
            Negative = new TikzPrimitive(p1 = s.get_point(5, 0, a), a, TikzPaint.Negative);

            CPositive = new Connector(p1 = s.get_point(5, 1, a), a);
            CNegative = new Connector(p1 = s.get_point(5, 3, a), a);
        }

        public override string Print(string prefix)
        {
            string? newPrefix = prefix ?? "" + "    ";

            Accumulator.Clear();

            string s;

            Accumulator.Append(s = Root.Print(newPrefix));
            Accumulator.Append(s = Positive.Print(newPrefix));
            Accumulator.Append(s = CPositive.Print(newPrefix));
            Accumulator.Append(s = Negative.Print(newPrefix));
            Accumulator.Append(s = CNegative.Print(newPrefix));

            s = Accumulator.ToString();
            return s;
        }

        public float Length { get; }
        public Point Center { get; }
    }
}
