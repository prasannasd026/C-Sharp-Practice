using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Add(7, 14, 5));
        }
    }

    static class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a , int b, int c)
        {
            return a + b + c;
        }
    }

    

}
