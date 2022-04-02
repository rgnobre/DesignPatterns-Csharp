using Demo_3___BatterLocking.Util;
using System;

namespace Demo_3___BatterLocking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the following tests.");
            Console.WriteLine("1. Multiple Instance");
            Console.WriteLine("2. Parallel Instance");
            var option = Convert.ToInt32(Console.ReadLine().Trim());

            if (option == 1)
            {
                //Just 1 constructor invoked
                SingletonTest.Test();
            }
            else if (option == 2)
            {
                //Just 1 constructor invoked, thread safe
                SingletonTest.ParallelTest();
            }
        }
    }
}
