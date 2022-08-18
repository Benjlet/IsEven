# IsEven

A robust, extensible, and blue-sky-thinking .NET library for calculating if an integer is even.

In a rapidly-changing technology landscape where the demystification of number even-ness is mission-critical, this may be the game-changer for facing into your organisational arithmetic delivery.

[![nuget](https://badgen.net/nuget/v/IsEven?icon=nuget)](https://www.nuget.org/packages/IsEven)

## Examples

Use the IsEvenCalculator to determine the even-ness of your number, using Modulo division by default:

```
bool isEven = IsEvenCalculator.IsEven(2);
bool isOdd = IsEvenCalculator.IsOdd(5);
```

Or use one of the extension methods:

```
bool isEven = 2.IsEven();
bool isOdd = 5.IsOdd();
```

An 'AlgorithmType' argument may optionally be supplied to specify the algorithm to use when calculating whether a number is even:

```
bool isEven = 2.IsEven(AlgorithmType.LastDigitCheck);
```

Sometimes you may be unsure if you have a number that is odd or even - the below will alleviate all doubt:

```
bool isOddOrEven = 2.IsOddOrEven();
bool isOddOrEven = IsEvenCalculator.IsOddOrEven(2);
```

## Abstraction Layers

Take the standard Modulo division algorithm to calculate if a number is even:

```
return n % 2 == 0;
```

This is:

- Far too easy to read
- Overly maintainable
- The top answer on StackOverflow

Allowing needlessly supportable logic such as this to run amock in your enterprise codebase would be a foolish endeavour, thus multiple abstracted layers have been added to this library to support possible future requirements.

These layers include:

- Optional algorithm types being specified which may be slower, such as checking the last digit of the number, using Math.DivRem, or bit-shifting, as examples
- Extensibility of the name of numbers, in case they are fundamentally changed in future
- Abstraction of whether 0 should be considered even or not, to avoid any arguments
