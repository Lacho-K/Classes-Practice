using System;
using System.Collections.Generic;
namespace CatsNDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[5];
            Cat[] cats = new Cat[5];
            dogs[0] = new Dog("Pencho");
            dogs[1] = new Dog("Gancho");
            dogs[2] = new Dog("Dancho");
            dogs[3] = new Dog("Spashcho");
            dogs[4] = new Dog("Chancho");
            cats[0] = new Cat("Abby");
            cats[1] = new Cat("Gabby");
            cats[2] = new Cat("Jabby");
            cats[3] = new Cat("Habby");
            cats[4] = new Cat("Nabby");
            foreach (var item in dogs)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            foreach (var item in cats)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            Array.Sort(dogs);
            Array.Sort(cats);
            foreach (var item in dogs)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            foreach (var item in cats)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(cats[1].Name.CompareTo(cats[0].Name));
        }
    }
}
