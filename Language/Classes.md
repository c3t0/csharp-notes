# Classes

Class is the root word of the term classification. When you design a class, you systematically arrange
information and behavior into a meaningful entity.

Blue Print of an object or template

Represents a *Reference Type*

vs Struct => value type

## Encapsulation

A program that uses a class should not have to worry how the class actually works internally.

The program simply creates an instance of a class and calls the methods of that class.

The program does not care about the implementation.

The class might need to maintain all sorts of **internal state information** to perform its various methods.

State information and activity are hidden from the program using a class.


Encapsulation actually has two purposes:

1. To combine methods and data within a class; in other words, to support classification

2. To control the accessibility of the methods and data; in other words, to control the use of the
class

## Syntax

Use the **class** keyword to define a new class

Followed by the name used to refer to that class.

```C#
class Circle
        {
            int radius;

            double Area()
            {
                return Math.PI * radius * radius;
            }
        }

```

*vis-a-vis method does not use a 'method' keyword in the declaration.*

Methods & Fields(Data) go between the braces.

Fields are variables in a class

## Class as type

You can use a class similar to using other types

The keyword **new** is necessary to declare a **variable of class type**

*What is the Circle equivalent of 42?*

C# does not provide the syntax for assigning literal class values 

Memory of variable sof class types is allocated differently than literal class values

See Values ad References

You can assign an intance of a class to another variable of the same type

```C#
Circle c;
c = new Circle();
Circle d;
d = c;
```

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

