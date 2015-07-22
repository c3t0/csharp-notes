#Methods

## Declaration Syntax

```C#
returnType methodName (parmeterList)
{
// metod body statements;
}

// aka

returnType methodName ()
{
// body
}
```

### returnType or void

Specified the information that the **method returns**

If the method **does not return** a value:

use the keyword **void** instead of the **returnType**

### methodName

named used to call the method

Follwos the same identifier rules.

cameCase

### parameterList

Optional

Types & Names that will be passed into the method.

Write parameters as if you were declaring variables:

Type folled by the name of parameter.

More than one are separated by commas.

there are **no global methods**

**All methods are inside a class**

**Declaration Example**

The method called "addValues" retuns a type int and takes two parameters leftHandSide and rightHandSide.
Both parameters are type int.

```C#
int addValues (int leftHandSide, int rightHandSide)
{
//method body statements go here
}
```

The method showResult **does not** return a vale. 
It takes one parameter named answer of type int.
```C#
void showResult (int answer)
{
//method body statements go here
}
```

## Return statement

When return type is **not void** you **must** include a **return** statement

return keyword + expression specifying the returned value + ; semicolon

Type must be the same as the type specified in the method declaration.

## Parameters

Is the varaible in a method definition.

```C#

public void MyMethod(string myParam)
{
// Statments here;
}

```

**Arguments** are the **data passed** to the methods **parameters**


When a method is called, 
```C#
string myArg1 = "This is my argument";
myClass.MyMethod(myArb1);
```
