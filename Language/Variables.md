# Variables

Storage location that holds a value

## Naming Variables
According to C# step-by-set do not start idenfiers with an underscore

Do not use identifiers that are different only by case

Lower case should be used for the name

Multiword start by lower then upper

## Declaring Variables
Provides the Type of data to be store and the name we will use to refer to that data stored.

Declaration statement is used to declare the type and name of a variable.

You must specify the type.

There are **no implicit varaible declarations**


Varaibel named age that holds int(integer) values.
```C#
int age;
```
Remember declaration does not mean you will assign a value.

### Assignment

(=) equal is the assignemnet operator
asigns the vlaue on the right to the variable on the left.

You can us ethe variable name to refer to the value ti holds.

char -> single character
bool -> boolean
decimal -> monetary

### Unassigned local variables

When you declare a variable a random value is assigned until you specify the value you wish to store.

C# does not allow you to use an unassigned value.

You **must assigne a value** or your program will not compile.

"Use of Unassigned local variable age"

```C#
int age;
Console.WriteLine(age); // Compile error
```

This is because Console.WrriteLine the value stored in age

### var
You can use the **var** only when you supply an expression to initialize a variable.

**Implictly typed variables** are those that were declared using **var**  




