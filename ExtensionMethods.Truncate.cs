// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <inheritdoc cref="Math.Truncate(double)"/>
    public static double Truncate(this double d)
    { return Math.Truncate(d); }

    /// <inheritdoc cref="Truncate(double)"/>
    public static double Truncate(this float d)
    { return Math.Truncate(d); }

    /// <inheritdoc cref="Truncate(decimal)"/>
    public static decimal Truncate(this decimal d)
    { return Math.Truncate(d); }
  }
}