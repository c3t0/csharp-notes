# Classes
## Constructor

The **()** after the class is the **method invocation operator**

You are calling a **method** whenver you are creating a new instance of this class

This is called a **constructor**. 

It allows you to write some code at the moment of instantiation.

at the moment when a new instance of your class has been created.

Constructors are used for many things but typically

=> when a new object that you just created an instance of into a valid state.

Meaning that you can use it to initialize the value of properties of the object.

The constructor can be used to set default values so they are ready when the you create a new instance 

```C#
public Car()
{
//Load this from a configuration file, a database, etc.
//This is hardcoded
this.Make = "Nissan";
}
```

### Overloaded Constructor

With the constructor method you can create an overloaded constructor, the same way you can create an overloaded method by changing the _signature_ aka the input parameters.

```C#
public Car()
{
//Load this from a configuration file, a database, etc.
//This is hardcoded
this.Make = "Nissan";
}

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
             
        }

```

Which in this case would be called

```C#
 Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
```

Not specifying constructors will lead to the creation of an empty constructor
```C#
public Car()
{
}
```
By specifying contructors you are taking control over the process of instantiation


### Static 
Meaning you will not need to instantiate it to be available.

other will be avaialble as static memever
Their static methods will be available to you without creating an instance of a class first

```C#
 public static void myMethod()
        {

        }
```

Static Methods of a class
some classes that you will work with will require you to first create an instance of a class.



Void


## Reference Count

How many handles to the same bucket

How many references are made to the same object.

For example 

```C#
Car myCar = new Car(); // One reference

Car myCarAgain = myCar; // Now we have to references to the same object

```
This leads to the instance myCar to having two references myCar & myCarAgain

Hence, the reference count is 2

### Deterministic Finalization

It is the specific way the .NET will actively garbage collect prompted by the programmer.

Finalizes cleanup procedures
