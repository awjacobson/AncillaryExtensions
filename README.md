# AncillaryExtensions

A collection of extension methods.

## Download

Add AncillaryExtensions to your .Net project using the [Nuget package](https://www.nuget.org/packages/ancillaryextensions).

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
