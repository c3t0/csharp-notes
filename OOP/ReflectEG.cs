using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectEG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //without reflection
            //var dog = new Dog {NumberOfLegs = 4};
            //Console.WriteLine("A dog has {0} legs", dog.NumberOfLegs);

            //With Reflection
            Object dog = Activator.CreateInstance(typeof(Dog));
            PropertyInfo[] properties = typeof(Dog).GetProperties();
            PropertyInfo numberOfLegsProperty1 = properties[0];

            PropertyInfo numberOfLegsProperty2 = null;
            foreach(PropertyInfo propertyInfo in properties)
            {
                if(propertyInfo.Name.Equals("NumberOfLegs", StringComparison.InvariantCulture))
                {
                    numberOfLegsProperty2 = propertyInfo;

                }
            }

            numberOfLegsProperty1.SetValue(dog, 3, null);
            Console.WriteLine(numberOfLegsProperty2.GetValue(dog, null));

            var defaulConstructor = typeof(Dog).GetConstructor(new Type[0]);
            var legConstructor = typeof(Dog).GetConstructor(new [] {typeof (int) });


            var defaultDog = (Dog)defaulConstructor.Invoke(null);
            Console.WriteLine(defaultDog.NumberOfLegs);

            var legDog = (Dog)legConstructor.Invoke(new object[] { 5 });
            Console.WriteLine(legDog.NumberOfLegs);

        }
    }
    internal class Dog
    {
        public int NumberOfLegs { get; set; }
        public Dog()
        {
            NumberOfLegs = 4;
        }
        public Dog(int legs)
        {
            NumberOfLegs = legs;
        }
    }
}

/////////////////////////////////////////////
//    //var genericDog = Activator.CreateInstance<Dog>();

//    //var dog = new Dog { NumberOfLegs = 4 };

//    //Type t1 = typeof(Dog);

//    //Type t2 = dog.GetType();

//    //Console.WriteLine(t2.Name);
//    //Console.WriteLine(t2.Assembly);
//    //Console.ReadLine();

//    var horse = new Animal() { NameAnimal = "Ed" };

//    var type = horse.GetType();

//    var property = type.GetProperty("Name");

//    var value = property.GetValue(horse, null);
//}

//    public class Animal
//{
//    public string NameAnimal { get; set; }

//}
