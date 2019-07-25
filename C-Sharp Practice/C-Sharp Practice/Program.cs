using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.Eat();


            Fish myFish = new Fish();
            myFish.Name = "Bob";
            Console.WriteLine($"Hi I'am {myFish.Name}");
            myFish.Breathe();
        }
    }

    abstract class Animal
    { 
        public string Name { get; set; }
        public string Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }
        public void Eat()
        {
            Console.WriteLine("I'm Eating");
        }
    }
    class Dog : Animal
    {
        public int NumberOfLegs { get; set; }
        public void Bark()
        {
            Console.WriteLine("woof woof");
        }
    }
    class Fish : Animal
    {
       
    }
       
    

}
