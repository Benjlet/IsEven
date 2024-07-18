# IsEven

A robust, extensible, and blue-sky-thinking .NET library for calculating if a number is even.

In a rapidly-changing technology landscape where the demystification of number even-ness is mission-critical, this may be the game-changer for facing into your organisational arithmetic delivery.

With the introduction of the .NET 7 `INumber` interface that already offers `IsEvenInteger` and `IsOddInteger` out of the box, this library places you back in the box with an additional project dependency.

[![nuget](https://badgen.net/nuget/v/IsEven?icon=nuget)](https://www.nuget.org/packages/IsEven)


## Examples

Use the `IsEvenClient` to determine the even-ness of your number, using Modulo division by default:

```
IIsEvenClient isEvenClient = new IsEvenClient();
bool isEven = isEvenClient.IsEven(2);
bool isOdd = isEvenClient.IsOdd(5);
```

An `AlgorithmType` argument may optionally be supplied to specify the algorithm to use when calculating whether a number is even:

```
bool isEven = isEvenClient.IsEven(2, AlgorithmType.LastDigitCheck);
```

Sometimes you may be unsure if you have a number that is odd or even - the below squares the circle, alleviating all doubt:

```
bool isOddOrEven = isEvenClient.IsOddOrEven(2);
```

### Dependency Injection

You may also face into the strategic `IIsEvenClient` interface, pivoting into dependency injection and mocking opportunities.

Here is an example of it being added to a DI container with the `Microsoft.Extensions.DependencyInjection` library:

```
public static class Extensions
{
    private static void AddIsEvenClient(this IServiceCollection services, IIsEvenClientSettings settings)
    {
        services.AddTransient<IIsEvenClient>(c =>
        {
            return new IsEvenClient(settings);
        });
    }
}
```

## Dependencies

This library does not include dependencies to avoid additional architectural sign-off, keeping the discussions about introducing this library confined to only a handful of solution assessment boards.

## Performance

This library has not been performance tested but ran quite quickly on Gareth's laptop.

## Footnote

You can just do the below to check if a number is even:

```
bool isEven = n % 2 == 0;
```

.NET 7 introduced the `INumber` interface with the `IsInteger`, `IsEvenInteger`, and `IsOddInteger` methods so this library is entirely superfluous.
