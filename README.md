# AncillaryExtensions

A collection of extension methods.

## Install AncillaryExtensions via Nuget

If you want to include AncillaryExtensions in your project, you can [install it directly from NuGet](https://www.nuget.org/packages/ancillaryextensions)

To install AncillaryExtensions, run the following command in the Package Manager Console
```
PM> Install-Package AncillaryExtensions
```

## IEnumerableExtensions

### GetPage

Get a page of items from a list of items.

#### Example

```C#
var items = new List<int> { 0, 1, 2, 3, 4, 5 };
var page = items.GetPage(1, 3); // Returns { 3, 4, 5 }
```

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

### Right

Returns a string containing a specified number of characters from the right side of a string.

#### Example

This example uses the Right method to return a specified number of characters from
the right side of a string.

```C#
String myString;
var anyString = "Hello World";
myString = anyString.Right(1); // Returns "Hd"
myString = anyString.Right(7); // Returns "o World"
myString = anyString.Right(20); // Returns "Hello World"
```

### TrimEnd

Removes the specified string from the end of the current string object.

#### Example

```C#
const string EOL = "<br/>";
var source = $"LineOfText{EOL}";
var actual = source.TrimEnd(EOL); // Returns "LineOfText"
```

### MaskLeft

Masks the characters on the left (start of the string).

#### Example

```C#
var actual = "1122334455667788".MaskLeft(4); // Returns "************7788"
```

### MaskRight

Masks the characters on the right (end of the string).

#### Example

```C#
var actual = "11223344".MaskRight(6); // Returns "112233**"
```

### Mask

Mask characters in a string.

#### Example

```C#
var actual = "1234567890".Mask('*', 2, 4); // Returns "12****7890"
```

### Replace

Replace named group in regex with value

#### Example

```C#
var regex = new Regex(@".*_(?<id>\d+)_.*", RegexOptions.IgnoreCase);
var actual = "abc_123_def".Replace(regex, "id", "456"); // Returns "abc_456_def"
```
