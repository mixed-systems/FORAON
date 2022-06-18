using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Definitions.Runtime;

[assembly: AssemblyTitle("Definitions")]
[assembly: AssemblyDescription("FORAON definitions")]
[assembly: AssemblyProduct("FORAON")]
[assembly: AssemblyCopyright("Copyright (C) Andrei Samoylov 2013-2022")]

[assembly: AssemblyVersion("1.0.0.0")]

[assembly: NeutralResourcesLanguage("en-US")]

[assembly: InternalsVisibleTo($"Proofs, PublicKey = {PublicKey.HexValue}")]
[assembly: InternalsVisibleTo($"Shell, PublicKey = {PublicKey.HexValue}")]


////
//// ReSharper disable CheckNamespace
//// ReSharper disable InconsistentNaming
//// ReSharper disable UnusedMember.Global
////


namespace Definitions.Runtime
{
    using PostSharp.Aspects;

    class __init
    {
        static void Touch(object _) { }

        /// <summary>
        /// Module initialization routine.
        /// </summary>
        [ModuleInitializer(0), ExcludeFromCodeCoverage]
        internal static void Invoke() => Touch(Sentience.Attention);
    }

    [ExcludeFromCodeCoverage]
    public class PublicKey
    {
        /// <summary/>
        public const string HexValue =
            "00240000048000009400000006020000" +
            "00240000525341310004000001000100" +
            "2DDDB80E58FF3E99AE65FF1FB082B894" +
            "38077DC7A9251B1E1231107F5DE9A8BD" +
            "CFB1C4B81F392241E0241A668E1AC6B6" +
            "E377C7E19B60E731F87F6A909A7BF19F" +
            "B97A79FB8A9F9386E4C2030C964DD750" +
            "02A69496F4839FA06E7A6B7C792037C0" +
            "5B3DAC24A44D1342F4FC8A8C78C8E30E" +
            "FFA06795130008BFA0AEA3517F704ECF";
    }
}
