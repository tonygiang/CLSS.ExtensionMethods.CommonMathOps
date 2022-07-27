// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <summary>
    /// Calculates the integral part of the source number.
    /// </summary>
    /// <param name="source">A number to truncate.</param>
    /// <returns>The same result returned by
    /// Math.Truncate(<paramref name="source"/>).</returns>
    public static double Truncate(this double source)
    { return Math.Truncate(source); }

    /// <summary>
    /// Calculates the integral part of the source number.
    /// </summary>
    /// <param name="source">A number to truncate.</param>
    /// <returns>The same result returned by
    /// Math.Truncate(<paramref name="source"/>).</returns>
    public static double Truncate(this float source)
    { return Math.Truncate(source); }

    /// <summary>
    /// Calculates the integral part of the source number.
    /// </summary>
    /// <param name="source">A number to truncate.</param>
    /// <returns>The same result returned by
    /// Math.Truncate(<paramref name="source"/>).</returns>
    public static decimal Truncate(this decimal source)
    { return Math.Truncate(source); }
  }
}