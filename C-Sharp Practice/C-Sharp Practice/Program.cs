using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.Color = "Blue";

            car myCar2 = new car();
            myCar2.Color = "Red";

            Console.WriteLine(myCar.Color);
            Console.WriteLine(myCar2.Color);

            int total = Math.Add(5, 3);
            int total2 = Math.Add(6, 10);

            Console.WriteLine(total);
            Console.WriteLine(total2);

            Console.ReadLine();
        }
    }

    class car
    {
        public string Color { get; set; }
    }

    static class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
