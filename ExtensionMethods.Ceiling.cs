// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <inheritdoc cref="Math.Ceiling(double)"/>
    public static double Ceiling(this double a)
    { return Math.Ceiling(a); }

    /// <inheritdoc cref="Math.Ceiling(double)"/>
    public static double Ceiling(this float a)
    { return Math.Ceiling(a); }

    /// <inheritdoc cref="Math.Ceiling(decimal)"/>
    public static decimal Ceiling(this decimal d)
    { return Math.Ceiling(d); }
  }
}
