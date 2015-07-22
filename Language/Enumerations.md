#Enumarations

C# supports two kinds of value types.

1. Enumerations
2. Structurs


**enum** values are limited to **a set of symbolic names**.

## Declarations Syntax

**enum** keyword

set of symbols idenfitying the **legal values** that the type can have **{ }**.

```C#

enum Season {Spring, Summer, Fall, Winter}

```

## Using enum

```C#
enum Season {Spring, Summer, Fall, Winter}

class Example
{
  public void Method(Seasosn parameter)
  {
    Season localVariable; //local vairable
  }
  private Season currentSeason; // field example
}
````

All enums have to be scope d by their enumeration type

you have to write **Season.Fall**

Different enums can have literals  of the same name.

```C#

Season colorgul = Season.Fall;

Console.WriteLine(colorful); // writes out 'Fall'

```

