# OOP

must have 
- encapsulation
- inheritance
- polymorphism

## Encapsultation 


## Inheritance

objects that obtain behavious

## Polymorphism

Object appear to be different shapes

## Managed Language

dependent of services provided by a runtime environment

## Managed code is executed by the CLR

cannot excist ifunless it not enabled by the funtime
Common Language Runtime

Automatic memory management
Exception handling
Standard types
Security


## Standard Types

Type is the metadata
what it shoudl do and not do.

all types have a common base Object

Object defines ToString so every object has ToString function.

Three categories of types

1. Value types they store directly the value
2. Reference types or objects instances. They stor a reference to data. Points to where the object is located.
3. Pointer types only unsafe code. accessing memory directly.

## C# & Encapsulation

Public Windows and Doors => *what* it does

Private Kitchen => *how* it does it

Encapsulation if C# is via
- Unified Type system the CLR type system aka a common way to share data

- Classes and Interfaces:
Other support only classes 
why interfaces?

- Properties, Methods and Events

## C# & Inheritance

implemented in two 
1. inherit from a single base class aka .NET
can only inherit from ONE class it may be a chain but only one base.
One Dad.
Although the polymorphism can come from any part of the chain.
CAST will be know exactly since all the chain of inheritance is known.
how it implements polymorphis
what it was inherited and where from 

2. may implement zero or more interfaces
multiple inehritance is supported by interfaces

Class that implements in

interface is a promise
Interface promises a specific behavior from the class that implements the interface 

## C# & Polymorphism

I can cast you in different types.

implemented in two ways

1) Base type or Interface
2) Methods

A class can be used as its own type.
=> CAST is used to slide on the chain of inheritance.
- CAST to any base type or *interface* it implements

Objects have methods as *virtual*
*virtual* methods my be overridden in a derived type.
*virtual* methods are executed instead of the base implementation.

Method is an encapsulated function or behavior that can be overridden by a descendant.

Virtual Method A specific implementation my be overriden by derived class
However when you cast the object into a base it will maintain the overriden behavior inherited from the derived class.


## C# productivity

*var* is used for implicitly typing a local variable 

Declare + Initialize a variable in one step.
If the compiler can infer the type from the initialization expression then you can use *var*

```C#
   var x = "hello";
            var y = new System.Text.StringBuilder();
            var z = (float)Math.PI;

            // precisely equivalent to 

            string x = "hello";
            System.Text.StringBuilder y = new System.Text.StringBuilder();
            float z = (float)Math.PI;

            // when you cannot deduce by looking at the declaration
            // you decrease readablilty

            Random r = new Random();
            var x = r.Next();

            //Here we would need to go find what the declaration of the Random variable
```



Chapter 2 pg 46

- var before you had to declare the object explicitly
- JS var means something different
- LINQ - language 
- Lambdas => predicates in a small syntaz 
refinement of anonymous methods

## Code Decoration
Attributes
- associate additional metadat to types and members
- Discoverable at runtime via *reflection*


### Anonymous Types

Types with NO design-time definition

used extensively with LINQ
Not a full definition.

When you need a type or a class that you are interacting with to hold some variables or a list.

Compiler inferred types


## Lambda Expressions

- Enhancement of *anonymous methods*
- unnamed method written *inline*
- alternative to *a delegate*

lambda becomes
1) instance of a delegate
2) expression tree

Expressions validaded at compile time
dyname expression trees supported 

## Extension Methods

Add functionality to classes without altering the ones they already have.

Good for extending lcasses that are not yours or sealed

Theya re declared as static methods ina a static class

The first parameter has *this.* modifier

the first parameters type is the tyep being extended

## Dynamics

dont do strong type

## Namespace 

similar functionality accross may files 

helps enforce strongly type

t group similar duncitonality

company.application.functionalarea



