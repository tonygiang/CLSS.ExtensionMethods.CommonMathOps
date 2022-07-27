// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <summary>
    /// Returns the largest integral value less than or equal to the source
    /// number.
    /// </summary>
    /// <param name="source">A number to floor.</param>
    /// <returns>The same result returned by
    /// Math.Floor(<paramref name="source"/>).</returns>
    public static double Floor(this double source)
    { return Math.Floor(source); }

    /// <summary>
    /// Returns the largest integral value less than or equal to the source
    /// number.
    /// </summary>
    /// <param name="source">A number to floor.</param>
    /// <returns>The same result returned by
    /// Math.Floor(<paramref name="source"/>).</returns>
    public static double Floor(this float source)
    { return Math.Floor(source); }

    /// <summary>
    /// Returns the largest integral value less than or equal to the source
    /// number.
    /// </summary>
    /// <param name="source">A number to floor.</param>
    /// <returns>The same result returned by
    /// Math.Floor(<paramref name="source"/>).</returns>
    public static decimal Floor(this decimal source)
    { return Math.Floor(source); }
  }
}
