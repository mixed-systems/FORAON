namespace Writer
{
    public class Sector : Draw
    {
        public float Angle { get; }

        public static float Width = TikzPrimitive.Radius;

        public Sector(Point p, float a) : base(p, Width)
        {
            Angle = a;
        }

        public override string Print(string prefix)
        {
            Point p1 = new Point(Point.X + (Width) * (float)Math.Cos(Angle), Point.Y + (Width) * (float)Math.Sin(Angle));
            Point p2 = new Point(Point.X + (Width) * (float)Math.Cos(Angle + Math.PI), Point.Y + (Width) * (float)Math.Sin(Angle + Math.PI));

            return $"{prefix ?? "" + "    "}\\draw ({p1.X.Print()},{p1.Y.Print()}) -- ({p2.X.Print()},{p2.Y.Print()});{Environment.NewLine}";
        }
    }
}