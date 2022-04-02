using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2___ThreadSafeSingleton.Util
{
   public static class SingletonTest
    {
        public static void ParallelTest()
        {
            var strings = new List<string>() { "one", "two", "three" };
            var instances = new List<Singleton>();
            var options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };

            Parallel.ForEach(strings, options, instance =>
            {
                instances.Add(Singleton.Instance);
            });

            Logger.Output().ToList().ForEach(h => Console.WriteLine(h));
            Logger.Clear();
        }


        public static void Test()
        {
            var one = Singleton.Instance;
            var two = Singleton.Instance;
            var three = Singleton.Instance;

            Logger.Output().ToList().ForEach(h => Console.WriteLine(h));
            Logger.Clear();
        }
    }
}
