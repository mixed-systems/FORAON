using Definitions.Runtime;

namespace Definitions
{
#pragma warning disable CS8618

    public partial class Board : Primitive
    {
        public override partial void Write(dynamic? x) { }

        public override partial dynamic? Read() => Storage.Values.ToArray();
    }
}
