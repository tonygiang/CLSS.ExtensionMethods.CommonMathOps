// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this sbyte x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this byte x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this short x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this ushort x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this int x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this uint x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this long x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this ulong x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this float x, double y)
    { return Math.Pow(x, y); }

    /// <inheritdoc cref="Math.Pow(double, double)"/>
    public static double Pow(this double x, double y)
    { return Math.Pow(x, y); }
  }
}
