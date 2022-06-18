using System.Diagnostics;
using System.Runtime.InteropServices;
using Definitions;
using Definitions.Runtime;

namespace FORAON
{
    using static Mathematical;

    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Contract();

            dynamic p = new Primitive();

            var z = p.Zlp;
        }
    }
}
