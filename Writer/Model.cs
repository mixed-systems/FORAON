using System;
using System.Collections.Generic;
using System.Globalization;

namespace Writer
{
    public static class Printer
    {
        public static string Print(this float x) => (x).ToString("0.00", CultureInfo.InvariantCulture);
    }
}
