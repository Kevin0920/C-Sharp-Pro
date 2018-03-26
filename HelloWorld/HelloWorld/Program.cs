using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Add(21, 23));

            Console.WriteLine(Multi(100, 2));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multi(int c , int d)
        {
            return c * d;
        }
    }
}
