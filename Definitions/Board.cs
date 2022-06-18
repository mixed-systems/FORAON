using Definitions.Runtime;

namespace Definitions
{
#pragma warning disable CS8618

    public enum Direction : sbyte
    {
        Positive = +1,
        Negative = -1,
    }

    public enum Orientation : byte
    {
        Primary = 0,
        Secondary = 1,
    }

    public partial class Board : Primitive
    {
        public readonly Dictionary<int, dynamic> Storage = new();

        public int IdSeed = 1;

        public dynamic? Last;

        public override partial void Write(dynamic? x = null);

        public override partial dynamic? Read();
    }
}
