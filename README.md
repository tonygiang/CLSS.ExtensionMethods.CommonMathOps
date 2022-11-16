# CLSS.ExtensionMethods.CommonMathOps

### Problem

How do you read the logic flow of this expression?

```csharp
Math.Pow(Math.Floor((1 / ((5.4 + 8) * 12.8)) - 16) + 3, 4);
```

When order of execution doesn't always flow from left to right, it's often hard to comprehend how you can get from the input to the output.

### Solution

This package provides common mathematical operations in a functional syntax. The above expression can be rewritten in the following way:

```csharp
using CLSS;

(5.4).Plus(8).Multiply(12.8).Pow(-1).Subtract(16).Floor().Plus(3).Pow(4);
```

This package supports the following operations:

- Plus
- Subtract
- Multiply
- Divide
- Remainder
- Abs
- Ceiling
- Floor
- Log
- Pow
- Round
- Truncate

The below table outlines how to write some of the less obvious operations in this syntax:

| Operation Name | Raw Expression | Functional Syntax |
| ---            | ---            | ---               |
| Inversion      | `1 / x`        | `x.Pow(-1)`       |
| Square Root    | `Math.Sqrt(x)` | `x.Pow(0.5)`      |
| Nth Root       | N/A            | `x.Pow(1.0 / n)`  |

**Note #1**: Due to implicit conversions, using this syntax may create some imprecision with floating point values.

**Note #2**: These methods should not replace all math operations due to performance overhead. They should only be used in places where you need extra clarity on order of operations.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).