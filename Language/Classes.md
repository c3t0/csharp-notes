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

## Declaration Syntax

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

## Class Accessibility

Classes form a boundary to the ouside world.

The fields and methods are not available to the program.

Methods and Fields:

1. You need to **explicity** use the keyword **public**

2. Use the keyword **private** when the intended behaviour of a method of field is to not be accessible to the program. 

Keyword needs to be repeated with every field or method declaration.

**public** accesssible to both within and outside of the class

```C#

        class Circle
        {
            private int radius;

            public double Area()
            {
                return Math.PI * radius * radius;
            }
        }

```

Although "radius" is private "Area" is public and can see "radius"

*How do we initialize radius?* we need a **contructor**

### Naming Conventions

Capital letter for All Classes.

**constructor** MUST use Capital Letter because it need to have the same name.

* Capital letter for **public** aka PascalCase

* Lowercase letter for  **non-public** aka camelCase

Sometimes:

* camelCase for methods 
* _underScore for **private**


## Constuctors

A **special method** that runs automativally when you create an instance of a class.

it is a **methods that**

1. Same name as class. Hence it is capitalized
2. **cannot** return a value... not even "void"
3. It must be in every class
4. Must be public

```C#
        class Circle
        {
            private int radius;

            public Circle()
            {
                radius = 0;
            }

            double Area()
            {
                return Math.PI * radius * radius;
            }
        }


```
 
when you use the **new** keyword to crate an object.

The CLR (runtime) must'

1. grab a piece of memory based on the class
2. fill it with the **fields** defined in the class
3. perform **initialization** by invoking the **constructor**

### Default contructor

Does not take any parameters

```C#
public Circle()
{
//body
}
```

IF you add parameters === **Overloaded Constructor**

private constructor prevents you from being able to create objects that are not part of the class

### Overloading Constructors

Constructor just like any other method can be **overloaded**.

So you can use the **default constructor** to generate **default initialization** if there is no input.

You can write several version of the constructor depending on the **signature** aka parameters passed or provided.

The compiler will determine which constructor to use depening on the signature and the parametes passed.

IF you make your own constructor teh compiler **will not genreate a default constructor**.

IF you **also want a default with no parameters** you need to write the constructor yourself.


### Partial Classes

When a class is separated in several files.

Write different file names

The class in the file should be the **same class name**

**~/circ1.cs**

```C#
 partial Circle
        {
            public Circle() //default constructor
            {
                radius = 0;
            }

            public Circle (int initialRadius) //overloaded constructor
            {
                this.radius = intialRadius;

            }       
        }
````

**~/circ2.cs**

```C#
 partial Circle
        {
            private int radius;

            public double Area()
            {
                return Math.PI * this.radius * this.radius;

            }       
        }
````

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

