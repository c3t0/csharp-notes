# Classes

Blue Print of an object or template

Represents a *Reference Type*

vs Struct => value type
After C# syntax

Base class library

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

