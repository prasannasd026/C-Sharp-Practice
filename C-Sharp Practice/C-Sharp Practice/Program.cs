using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("bob");
            Animal myAnimal2 = new Animal("jennifer");

            Console.WriteLine(myAnimal.Name);
            Console.WriteLine(myAnimal2.Name);

            Console.ReadLine();
        }
    }

    class Animal
    {
        public string Name { get; }

        public Animal()
        {
            Name = "No Name";
        }

        public Animal(string name)
        {
            Name = name;
        }

    }

     
}
