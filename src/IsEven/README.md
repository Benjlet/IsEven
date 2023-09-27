# IsEven

A robust, extensible, and blue-sky-thinking .NET library for calculating if a number is even.

In a rapidly-changing technology landscape where the demystification of number even-ness is mission-critical, this may be the game-changer for facing into your organisational arithmetic delivery.

With the introduction of the .NET 7 `INumber` interface that already offers `IsEvenInteger` and `IsOddInteger` out of the box, this library places you back in the box with an additional project dependency.

## Examples

### IsEvenCalculator

Use the IsEvenCalculator to determine the even-ness of your number, using Modulo division by default:

```
bool isEven = IsEvenCalculator.IsEven(2);
bool isOdd = IsEvenCalculator.IsOdd(5);
```

An `AlgorithmType` argument may optionally be supplied to specify the algorithm to use when calculating whether a number is even:

```
bool isEven = IsEvenCalculator.IsEven(2, AlgorithmType.LastDigitCheck);
```

Sometimes you may be unsure if you have a number that is odd or even - the below will alleviate all doubt:

```
bool isOddOrEven = IsEvenCalculator.IsOddOrEven(2);
```

### Extension Methods

You may face into the below extension methods, adding further strings to your strategic enterprise bow:

```
bool isEven = 2.IsEven();
bool isOdd = 5.IsOdd();
bool isOddOrEven = 6.IsOddOrEven();
```

### Client

You may also use the `IsEvenClient`, underpinned by the helpful `IIsEvenClient` interface, pivoting into dependency injection and mocking opportunities.

```
IIsEvenClient isEvenClient = new();

bool isEven = isEvenClient.IsEven(2);
bool isOdd = isEvenClient.IsEven(3);
bool isOddOrEven = isEvenClient.IsOddOrEven(4);
```

### Settings

This library matches the default `IsEvenInteger` checks from the .NET 7 `INumber` interface, however the below settings can be customised, allowing you to bypass decimal digits to determine if its base value is even:

```
TestIsEvenSettings settings = new()
{
    IntegersOnly = false,
    IsZeroEven = true,
    IgnoreDecimalDigits = true
};
```

We haven't found a use case for this feature yet, but we hope to one day.

The option to consider zero as even has been retained to avoid any potential arguments.

## Dependencies

This library does not include dependencies to avoid additional architectural sign-off, keeping the discussions about introducing this library confined to only a handful of solution assessment boards.
