# Classes

## Reference Count

How many handles to the same bucket

How many references are made to the same object.

For example 

```
Car myCar = new Car(); // One reference

Car myCarAgain = myCar; // Now we have to references to the same object

```
This leads to the instance myCar to having two references myCar & myCarAgain

Hence, the reference count is 2
