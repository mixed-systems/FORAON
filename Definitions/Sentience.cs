#nullable disable

namespace Definitions
{
    public partial class Sentience : Primitive
    {
        public static Personality Attention;
        public static Mathematical Reality;
    }

    public class Personality : Primitive { }

    public class Mathematical : Primitive
    {
        public static Board Memory;

        public static Marker Time() => new();
    }
}
