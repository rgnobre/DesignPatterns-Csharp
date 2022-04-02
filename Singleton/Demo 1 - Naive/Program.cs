using Demo_1___Naive.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_1___Naive
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
                //Just 1 constructor call
                SingletonTest.Test();
            }
            else if (option == 2)
            {
                //3 constructor calls, Naive is not thread safe
                SingletonTest.ParallelTest();
            }
        }
    }
}
