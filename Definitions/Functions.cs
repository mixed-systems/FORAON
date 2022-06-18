namespace Definitions
{
    public static class Functions
    {
        public const string P1 = "+1";
        public const string M1 = "-1";

        public static string Print(Direction x) => Direction.Positive == x ? P1 : M1;

        public static string Print(Contract.Side x) => $"{Print(x.Direction)}";

        public static string Print(Contract x)
        {
            var s = null == x.Axis ? "?" :
                Orientation.Primary == x.Axis ? "P" : "S";

            return $"{x.Sides[1]}:{s}:{x.Sides[0]}";
        }
    }
}
