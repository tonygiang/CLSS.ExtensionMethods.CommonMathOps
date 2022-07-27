// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <summary>
    /// Returns the absolute value of source number.
    /// </summary>
    /// <param name="source">A number that is greater than or equal to MinValue,
    /// but less than or equal to MaxValue.</param>
    /// <returns>The same result returned by
    /// Math.Abs(<paramref name="source"/>).</returns>
    public static sbyte Abs(this sbyte source)
    { return Math.Abs(source); }

    /// <summary>
    /// Returns the absolute value of source number.
    /// </summary>
    /// <param name="source">A number that is greater than or equal to MinValue,
    /// but less than or equal to MaxValue.</param>
    /// <returns>The same result returned by
    /// Math.Abs(<paramref name="source"/>).</returns>
    public static short Abs(this short source)
    { return Math.Abs(source); }

    /// <summary>
    /// Returns the absolute value of source number.
    /// </summary>
    /// <param name="source">A number that is greater than or equal to MinValue,
    /// but less than or equal to MaxValue.</param>
    /// <returns>The same result returned by
    /// Math.Abs(<paramref name="source"/>).</returns>
    public static int Abs(this int source)
    { return Math.Abs(source); }

    /// <summary>
    /// Returns the absolute value of source number.
    /// </summary>
    /// <param name="source">A number that is greater than or equal to MinValue,
    /// but less than or equal to MaxValue.</param>
    /// <returns>The same result returned by
    /// Math.Abs(<paramref name="source"/>).</returns>
    public static long Abs(this long source)
    { return Math.Abs(source); }

    /// <summary>
    /// Returns the absolute value of source number.
    /// </summary>
    /// <param name="source">A number that is greater than or equal to MinValue,
    /// but less than or equal to MaxValue.</param>
    /// <returns>The same result returned by
    /// Math.Abs(<paramref name="source"/>).</returns>
    public static float Abs(this float source)
    { return Math.Abs(source); }

    /// <summary>
    /// Returns the absolute value of source number.
    /// </summary>
    /// <param name="source">A number that is greater than or equal to MinValue,
    /// but less than or equal to MaxValue.</param>
    /// <returns>The same result returned by
    /// Math.Abs(<paramref name="source"/>).</returns>
    public static double Abs(this double source)
    { return Math.Abs(source); }

    /// <summary>
    /// Returns the absolute value of source number.
    /// </summary>
    /// <param name="source">A number that is greater than or equal to MinValue,
    /// but less than or equal to MaxValue.</param>
    /// <returns>The same result returned by
    /// Math.Abs(<paramref name="source"/>).</returns>
    public static decimal Abs(this decimal source)
    { return Math.Abs(source); }
  }
}
