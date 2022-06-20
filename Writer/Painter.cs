namespace Writer
{
    internal class Painter : Draw
    {
        public List<Sector> Sectors = new ();

        public Painter(Point point, double a, TikzPaint p) : base(point, 0)
        {
            switch (p)
            {
                case TikzPaint.Opposition:
                    Sectors.Add(new Sector(point, (float)(a + Math.PI / 4)));
                    Sectors.Add(new Sector(point, (float)(a + Math.PI / 4 * 3)));
                    break;

                case TikzPaint.Positive:
                    Sectors.Add(new Sector(point, (float)a));
                    Sectors.Add(new Sector(point, (float)(a + Math.PI / 2)));
                    break;

                case TikzPaint.Negative:
                    Sectors.Add(new Sector(point, (float)a));
                    break;
            }
        }

        public override string Print(string prefix)
        {
            Accumulator.Clear();

            foreach (var sector in Sectors)
                Accumulator.Append(sector.Print(prefix + "    "));

            return Accumulator.ToString();
        }
    }
}