// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <summary>
    /// Rounds the source value to a specified number of fractional digits using
    /// the specified rounding convention.
    /// By default, this rounds to 0 fractional digit and the nearest even number
    /// when a number is halfway between two others.
    /// </summary>
    /// <param name="source">A double-precision floating-point number to be
    /// rounded.</param>
    /// <param name="digits">The number of fractional digits in the return
    /// value.</param>
    /// <param name="mode">One of the enumeration values that specifies which
    /// rounding strategy to use.</param>
    /// <returns>The same result returned by
    /// Math.Round(<paramref name="source"/>, <paramref name="digits"/>,
    /// <paramref name="mode"/>).</returns>
    public static double Round(this float source,
      int digits = 0,
      MidpointRounding mode = MidpointRounding.ToEven)
    { return Math.Round(source, digits, mode); }

    /// <summary>
    /// Rounds the source value to a specified number of fractional digits using
    /// the specified rounding convention.
    /// By default, this rounds to 0 fractional digit and the nearest even number
    /// when a number is halfway between two others.
    /// </summary>
    /// <param name="source">A double-precision floating-point number to be
    /// rounded.</param>
    /// <param name="digits">The number of fractional digits in the return
    /// value.</param>
    /// <param name="mode">One of the enumeration values that specifies which
    /// rounding strategy to use.</param>
    /// <returns>The same result returned by
    /// Math.Round(<paramref name="source"/>, <paramref name="digits"/>,
    /// <paramref name="mode"/>).</returns>
    public static double Round(this double source,
      int digits = 0,
      MidpointRounding mode = MidpointRounding.ToEven)
    { return Math.Round(source, digits, mode); }

    /// <summary>
    /// Rounds the source value to a specified number of fractional digits using
    /// the specified rounding convention.
    /// By default, this rounds to 0 fractional digit and the nearest even number
    /// when a number is halfway between two others.
    /// </summary>
    /// <param name="source">A decimal number to be rounded.</param>
    /// <param name="digits">The number of fractional digits in the return
    /// value.</param>
    /// <param name="mode">One of the enumeration values that specifies which
    /// rounding strategy to use.</param>
    /// <returns>The same result returned by
    /// Math.Round(<paramref name="source"/>, <paramref name="digits"/>,
    /// <paramref name="mode"/>).</returns>
    public static decimal Round(this decimal source,
      int digits = 0,
      MidpointRounding mode = MidpointRounding.ToEven)
    { return Math.Round(source, digits, mode); }
  }
}
