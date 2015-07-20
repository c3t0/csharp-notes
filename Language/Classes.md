# Classes

Blue Print of an object or template

Represents a *Reference Type*

vs Struct => value type

## Syntax

Use the **class** keyword to define a new class

Followed by the name used to refer to that class.

*vis-a-vis method does not use a keyword in the declaration.*

Methods & Fields(Data) go between the braces.

Fields are variables in a class

## Class as type

You can use a class similar to using other types

The keyword **new** is necessary to declare a **variable of class type**

C# does not provide the syntax for assigning literal class values 



After C# syntax

Base class library



## Encapsulation

Encapsulation actually has two purposes:
* To combine methods and data within a class; in other words, to support classification
* To control the accessibility of the methods and data; in other words, to control the use of the
class

Inheritance

The .NET framework is a set of base clases and derived classes.

Derived classes are classes that inherit the properties and methods of the base class or superclass and add or specialize the functionality.

StreamReader derives from FileStream

Every class in .NET derives from the System.Object

### Virtual Class
It allows the method to be overridden to fit the specific needs of that inherited class.

### Override Class
Override the properties from the inherited method

### Abstract Class
You must change it. You can derive for me but you will need to change it to your needs

### Sealed Class
You *cannot inherit* from a sealed class

```C#
sealed class Truck : Vehicle
```

inheritance method or porperties not apparent

look at the parents since they might have been inherited.
