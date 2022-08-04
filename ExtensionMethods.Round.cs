// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <inheritdoc cref="Math.Round(double, int, MidpointRounding)"/>
    public static double Round(this float source,
      int digits = 0,
      MidpointRounding mode = MidpointRounding.ToEven)
    { return Math.Round(source, digits, mode); }

    /// <inheritdoc cref="Math.Round(double, int, MidpointRounding)"/>
    public static double Round(this double value,
      int digits = 0,
      MidpointRounding mode = MidpointRounding.ToEven)
    { return Math.Round(value, digits, mode); }

    /// <inheritdoc cref="Math.Round(decimal, int, MidpointRounding)"/>
    public static decimal Round(this decimal d,
      int digits = 0,
      MidpointRounding mode = MidpointRounding.ToEven)
    { return Math.Round(d, digits, mode); }
  }
}
