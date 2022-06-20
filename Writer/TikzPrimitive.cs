namespace Writer
{
    public class TikzPrimitive : Draw
    {
        public TikzPaint? Painting;

        public const float R = 0.25f;
        public static float Radius = R * 1.0f; // to scale with diagram

        private Painter? Painter { get; }

        public TikzPrimitive(Point p, double a, TikzPaint? painting = null) : base(p, Radius)
        {
            this.Painting = painting;
            this.Painter = painting == null ? null : new Painter(p, a, painting.Value);
        }

        public TikzPrimitive(TikzPrimitive accenting, TikzPaint? painting = null) : base(new Point(accenting.Point.X + Radius, accenting.Point.Y), Radius)
        {
            this.Painting = painting;
            this.Painter = painting == null ? null : new Painter(Point, 0, painting.Value);
        }

        public override string Print(string prefix)
        {
            Accumulator.Clear();

            Accumulator.AppendLine($"{prefix??""}\\filldraw[thick, fill=white] ({Point.X.Print()},{Point.Y.Print()}) circle ({Radius.Print()}); % {Painting?.ToString()??""}");

            if(null != Painter)
                Accumulator.Append(Painter.Print(prefix!));

            return Accumulator.ToString();
        }
    }


    public class Natprimitive : Draw
    {
        public const float R = 0.25f;
        public static float Radius = R * 1.0f; // to scale with diagram

        public Natprimitive(Point p, double a) : base(p, Radius) {
        }

        public override string Print(string prefix) {
            Accumulator.Clear();

            Accumulator.AppendLine($"{prefix ?? ""}\\filldraw[thick, fill=black] ({Point.X.Print()},{Point.Y.Print()}) circle ({Radius.Print()}); % nature");

            return Accumulator.ToString();
        }
    }
}