// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this sbyte a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this byte a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this short a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this ushort a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this int a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this uint a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this long a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this ulong a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this float a, double newBase = Math.E)
    { return Math.Log(a, newBase); }

    /// <inheritdoc cref="Math.Log(double, double)"/>
    public static double Log(this double a, double newBase = Math.E)
    { return Math.Log(a, newBase); }
  }
}
