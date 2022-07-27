// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <summary>
    /// Returns the smallest integral value greater than or equal to the source
    /// number.
    /// </summary>
    /// <param name="source">A number to ceil.</param>
    /// <returns>The same result returned by
    /// Math.Ceiling(<paramref name="source"/>).</returns>
    public static double Ceiling(this double source)
    { return Math.Ceiling(source); }

    /// <summary>
    /// Returns the smallest integral value greater than or equal to the source
    /// number.
    /// </summary>
    /// <param name="source">A number to ceil.</param>
    /// <returns>The same result returned by
    /// Math.Ceiling(<paramref name="source"/>).</returns>
    public static double Ceiling(this float source)
    { return Math.Ceiling(source); }

    /// <summary>
    /// Returns the smallest integral value greater than or equal to the source
    /// number.
    /// </summary>
    /// <param name="source">A number to ceil.</param>
    /// <returns>The same result returned by
    /// Math.Ceiling(<paramref name="source"/>).</returns>
    public static decimal Ceiling(this decimal source)
    { return Math.Ceiling(source); }
  }
}
