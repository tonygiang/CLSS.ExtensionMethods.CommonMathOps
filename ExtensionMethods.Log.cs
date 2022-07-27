// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this sbyte source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this byte source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this short source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this ushort source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this int source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this uint source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this long source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this ulong source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this float source, double newBase = Math.E)
    { return Math.Log(source, newBase); }

    /// <summary>
    /// Returns the logarithm of the source number in a specified base.
    /// </summary>
    /// <param name="source">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>The same result returned by
    /// Math.Log(<paramref name="source"/>, <paramref name="newBase"/>).
    /// </returns>
    public static double Log(this double source, double newBase = Math.E)
    { return Math.Log(source, newBase); }
  }
}
