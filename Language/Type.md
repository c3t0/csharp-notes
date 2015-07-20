#Type

Blueprint of a value

All values are **intances of a type**

The set of possible alues a variable can be are determined by the type
## Custom Type
```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(
                milesToFeetConverter.Convert(1)));
            Console.ReadLine();


        }

        public class UnitConverter
        {
            int ratio; // data member is the  "field" called ratio
            public UnitConverter (int unitRatio) // Function Member is a "UnitConverter" Constructor 
            {
                ratio = unitRatio;
            }
            public int Convert (int unit) //Function Member is a "COnvert"  Method
            {
                return unit * ratio;
            }
        }
    }
}

```

## Members of Type

1) Data members
2) Function Members

## Constructor

A constructor is a method.


A **special method** that is being **called upon "construction" of the class.**

It has the **same name as the class itself**.

The purpose of the constructor is to initialize all member variables when an object of this class is created. 

**Any resources** acquired such as memory or open files are typically **released in the class constructor**.

A constructor is intended to be used for wiring. 
In the constructor, you want to avoid doing actual work. 
You basically prepare the class to be used. 
A method is intended to do actual work.

Is a method that is called only once. 


A constructor only works when you create a new instance of a class. 
This is the very first method to run on an instance, it has to run, and it runs exactly once.

A method on an instance can be called anywhere between zero times to infinite times on an instance once it is created.

A constructor is run implicitly. 

When a new instance of a class is created, it runs automatically. 

A method is run explicitly. 

It has to be called either from some outside source or from a method -or a constructor- in the class.


## Field

Properties expose fields. Fields should (almost always) be kept private to a class and accessed via get and set properties. 
Properties provide a level of abstraction allowing you to change the fields while not affecting the external way they are accessed by the things that use your class.
