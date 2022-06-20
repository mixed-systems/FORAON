namespace Writer
{
    public class Connector4 : Draw, ASegment
    {
        public const float W = 3f;
        public static float Width = W * 1.0f; // to scale with diagram

        public float Length { get; }
        public Point Center { get; }
        public double Angle { get; }

        public Dot D1, D2, D3, D4;

        public Connector4(Point p, double a) : base(p, Width)
        {

            Length = Width;
            Angle = a;
            Center = p;

            var s = this as ASegment;

            var p1 = s.get_point(4, 0, Angle); p1.Append(p);
            var p2 = s.get_point(4, 1, Angle); p2.Append(p);
            var p3 = s.get_point(4, 2, Angle); p3.Append(p);
            var p4 = s.get_point(4, 3, Angle); p4.Append(p);

            D1 = new Dot(p1);
            D2 = new Dot(p2);
            D3 = new Dot(p3);
            D4 = new Dot(p4);
        }

        public override string Print(string prefix)
        {

            Accumulator.Clear();

            Accumulator.AppendLine(D1.Print(prefix + "    "));
            Accumulator.AppendLine(D2.Print(prefix + "    "));
            Accumulator.AppendLine(D3.Print(prefix + "    "));
            Accumulator.AppendLine(D4.Print(prefix + "    "));

            return Accumulator.ToString();
        }
    }
}
