// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class CommonMathOps
  {
    /// <inheritdoc cref="Math.Abs(sbyte)"/>
    public static sbyte Abs(this sbyte value)
    { return Math.Abs(value); }

    /// <inheritdoc cref="Math.Abs(short)"/>
    public static short Abs(this short value)
    { return Math.Abs(value); }

    /// <inheritdoc cref="Math.Abs(int)"/>
    public static int Abs(this int value)
    { return Math.Abs(value); }

    /// <inheritdoc cref="Math.Abs(long)"/>
    public static long Abs(this long value)
    { return Math.Abs(value); }

    /// <inheritdoc cref="Math.Abs(float)"/>
    public static float Abs(this float value)
    { return Math.Abs(value); }

    /// <inheritdoc cref="Math.Abs(double)"/>
    public static double Abs(this double value)
    { return Math.Abs(value); }

    /// <inheritdoc cref="Math.Abs(decimal)"/>
    public static decimal Abs(this decimal value)
    { return Math.Abs(value); }
  }
}
