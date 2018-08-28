# AncillaryExtensions

A collection of extension methods.

## Download

Add AncillaryExtensions to your .Net project using the [Nuget package](https://www.nuget.org/packages/ancillaryextensions).

## IEnumerableExtensions

### GetPage

## StringExtensions

### Left

Returns a string containing a specified number of characters from the left side of a string.

#### Example

This example uses the Left method to return a specified number of characters from
the left side of a string.

```C#
String myString;
var anyString = "Hello World";
myString = anyString.Left(1); // Returns "H"
myString = anyString.Left(7); // Returns "Hello W"
myString = anyString.Left(20); // Returns "Hello World"
```

### TrimEnd

### MaskLeft
### MaskRight
### Mask