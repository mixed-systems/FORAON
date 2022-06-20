using System.Text;

namespace Writer
{
    public class Diagram
    {
        public Draw[] Draws;

        public Diagram(params Draw[] ds)
            => Draws = ds;

        public string Print(string prefix)
        {
            var accumulator = new StringBuilder();

            // prologue
            accumulator.Append($"{prefix ?? ""}\\begin{{tikzpicture}}");

            foreach (var draw in Draws)
                accumulator.Append(draw.Print(prefix ?? ""));

            accumulator.Append($"{prefix ?? ""}\\end{{tikzpicture}}");

            return accumulator.ToString();
        }
    }
}