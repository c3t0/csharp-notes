# Data Validation

Compiler does NOT validate objects value

Debu / Trace Assert(0 methods aler developer

Should be the "exception" not the "norm"

## Raise an Exception

```C#
System.ArgumentException
System.ArgumentOutofRangeException
System.ArgumentNullException



```
examples
```C#

         public override void SetName (string value)
        {
            //validate empty
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("value");
            // validate conflict
            if (value == this.Name)
                throw new ArgumentException("value is duplicate");
            // validate size
            if (value.Length > 10)
                throw new ArgumentException("value is too long");

            this.Name = value
        }

```
further 

```C#

            Animal cat = new Cat();
            Animal dog = new Dog();

            if (car is Dog)
                throw new NotSupportedException("Dogs only!");

            if (cat == dog)
                throw new Exception("Not the same");

            if (cat.Equals(dog)) ;
            throw new Exception("Not equal");

````
