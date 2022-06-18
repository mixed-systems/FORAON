using System.Dynamic;
using Definitions.Runtime;

namespace Definitions
{
    public partial class Primitive : DynamicObject
    {
        public int Id;

        public virtual partial dynamic? Read();

        public virtual partial void Write(dynamic? x);
    }
}
