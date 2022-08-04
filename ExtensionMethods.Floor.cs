// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <inheritdoc cref="Math.Ceiling(double)"/>
    public static double Floor(this double d)
    { return Math.Floor(d); }

    /// <inheritdoc cref="Math.Ceiling(double)"/>
    public static double Floor(this float d)
    { return Math.Floor(d); }

    /// <inheritdoc cref="Math.Ceiling(decimal)"/>
    public static decimal Floor(this decimal d)
    { return Math.Floor(d); }
  }
}
