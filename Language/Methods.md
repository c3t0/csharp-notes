#Methods

## Declaration Syntax

```C#
returnType methodName (parmeterList)
{
// metod body statements;
}
```

## returnType or void

Specified the information that the **method returns**

If the method **does not return** a value:

use the keyword **void** instead of the **returnType**

## methodName

named used to call the method

Follwos the same identifier rules.

cameCase

## parameterList

Optional

Types & Names that will be passed into the method.

Write parameters as if you were declaring variables:

Type folled by the name of parameter.

More than one are separated by commas.

there are **no global methods**

**All methods are inside a class**

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