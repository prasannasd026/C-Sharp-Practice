using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Fish myFish = new Fish();

            myDog.Breathe();
            myFish.Breathe();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm Breathing Air.");
        }
    }

    class Dog : Animal
    {

    }

    class Fish : Animal
    {
        public new void Breathe()
        {
            Console.WriteLine("I'm breathing underwater");
        }
    }

}
