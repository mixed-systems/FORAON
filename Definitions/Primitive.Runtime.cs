using System.Dynamic;
using Definitions.Runtime;

namespace Definitions
{
    public partial class Primitive : DynamicObject
    {
        public Primitive() { }

        public Contract? IncludedIn;

        public Primitive? Above;

        public Primitive? Below;

        public virtual partial dynamic? Read() => this;

        public virtual partial void Write(dynamic? x) { }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            result = null;
            return true;
        }

        public override bool TryConvert(ConvertBinder binder, out object? result)
        {
            result = null;
            return true;
        }

        public override bool TryInvoke(InvokeBinder binder, object?[]? args, out object? result)
        {
            result = null;
            return true;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
        {
            result = null;
            return true;
        }
    }
}
