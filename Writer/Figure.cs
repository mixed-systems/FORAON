namespace Writer
{
    public class Figure
    {
        public readonly TikzPrimitive Prim;
        public readonly string Prefix;

        public string? Caption { get; set; }
        public string? Label { get; set; }

        public string? Name { get; set; }

        public Figure(TikzPrimitive p, string f) => (Prim, Prefix) = (p, f);

        public string Print()
        {
            return Prim.Print(Prefix);
        }
    }
}
