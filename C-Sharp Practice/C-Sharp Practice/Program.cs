using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myAnimal;

            Console.WriteLine("What animal are you?");
            string input = Console.ReadLine();

            if(input == "Dog")
            {
                myAnimal = new Dog();
            }
            else
            {
                myAnimal = new Animal();
            }



            myAnimal.Name = "Jessica ";
            myAnimal.Breathe();
        }
    }

    class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }
    }
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public void Breathe()
        {
            Console.WriteLine("I'm a Dog breathing");
        }
    }

    interface IAnimal
    {
        string Name { get; set; }

        void Breathe();
    }
     
}
