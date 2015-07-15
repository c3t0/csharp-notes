## Ternary

```C#
if (value == 1)
{
Console.WriteLine("One");
}
else
{
Console.WriteLine("Not One");
}

//Ternary
Console.WriteLine(value == 1 ? "One : "Not One");


```

Each case clause needs to be completed by a jump statement

```C#
namespace @switch
{
    class Class1
    {
        enum Dogs { Lassie, Snoopy, Yeller, Fido}

        void x()
        {
            var snoopy = Dogs.Snoopy;

            switch (snoopy)
            {
                case Dogs.Lassie:
                    Console.WriteLine("Hi");
                    break;
                case Dogs.Snoopy:
                    Console.WriteLine("Hi");
                    break;
                case Dogs.Yeller:
                    break;
                default:
                    throw new NotSupportedException();
                    break;
            }
        }

    }
}
```

inheritance

```C#
namespace @switch
{
    public class y
    {
        public void x()
        {
            var animal = new Animal();
            var dog = new Dog();
            var poodle = new Poodle();

            TakeAnimal(animal);
        }
        public void TakeAnimal(Animal a)
        {
            a.Temp = 10;
            //var dog = (Dog)a;

            if (a is Dog)
            {
                var dog = a as Dog;
                if (dog != null)
                    dog.Name = "Daren";
            }


        }
    }
    public class Animal
    {
        public int Temp { get; set; }
    }
    public class Dog : Animal
    {
        public string Name { get; set; }
    }
    public class Poodle : Dog
    {
        public string Groomer { get; set; }
    }
}

````

Strings are immutable

When you modify a string you are creating a new object

StringBuilder handles this

```C#

`````
