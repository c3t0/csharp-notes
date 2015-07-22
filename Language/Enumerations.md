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

