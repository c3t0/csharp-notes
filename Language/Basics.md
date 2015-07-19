Each file is only one class

**All executable code must be defined within a METHOD.**

** All methods must belong to CLASS or STRUCT

e.g when creating a new project VS will create a new namespace with the name of the project

```C#
namespace ConsoleApplication1
```

It will create a default entry point class in a filed name Project.cs

Since you have one class per file the name of the file matches the name of the class

Hence declared class will have the name **Program**
```C#
class Program
```

It will also create a default entry point which is the method **Main**
```C#
static void Main(string[] args)
```

## Main Method
the entry point of the program.

The default method of first method called is the **main method**

It must be defined as a **static** method otherwise the .NET will not rcognize it as a tarting point of your application

It is specified as **void** because the program will not return anything.

The program is contained within a class

## C# Functions

Methods is a kind of function

* Methods
* Constructors
* Properties
* Events
* Indexers
* Finalizers

## Namespaces

Are the container of classes.

Are used to organize the program by levels

.NET framework lives within a namespace e.g. the System namespace.
.NET framework is organized into nested namespaces

## Using directive

Brings the namespace into scope.

[Variables](Variables.md)


