#nullable disable

namespace Definitions
{
    public partial class Sentience : Primitive
    {
        static Sentience()
        {
            Attention = new ();

            Reality = new ();

            Board b = Mathematical.Memory = new ();

            Marker m = new ();

            Contract c = new ();

            (c.Sides[0].This, c.Sides[1].This, c.This) = (m, b, Reality);
        }
    }
}
