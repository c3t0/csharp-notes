## Constructing Complex Types

Static cannot be instantiated.

Basically it is meant to be interacted with but not instantiated into an object

### Partial

*Partial* is when part of the class will be provided by someone else
they could be in two separate files e.g. dog1.cs & dog2.cs
But at run time the compiler knows that it is the same class.
partial class Dog
{
public string dogTalk { }
}
partial class Dog
{
public int dogWalks { }
}

Entity Framework will create a lot of classes for you.

How would be implement further functionnality if we could not give partial classes.

### Public

Create a class that anything can see this

add method as public 
private void Foo()

void Bar( ) { }

Internal 

inside the same assempbly 
within the assembly scope
scopes into a project.

### get; set;

isntruc compiler to create an infrastructure that will manicpulate and store 

the value of NAME

simple field access

shrot 

will create backing variable variable that will store Name

Protected for raising events  bacuse you cant raise and event on a base but you can call a method that does that for you in the base.

### Void 

does not return any number


## Two things that class can do 

1) Hold data in a property & do something with a Method
2) Raise an Event

## Event

Declared with a keyword *event*

needs an *EventHandler* which is the method that will handle the event.

Event is the way for a class or object it talks back to me

*EventHandler<Type Event Arguments>*


For events if a event is raisen in a forrest but nobody is listening it is null


The class needs to subscribe to the event in order to listen.

and * event is a list of methods that needs to be raised back*

Subscription dog.HasSpoken += dog_HasSpoken
