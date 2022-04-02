using Demo____NestedLazy.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo____NestedLazy
{
    // Source: https://csharpindepth.com/articles/singleton
    public sealed class Singleton
    {
        // reading this will initialize the instance
        public static readonly string GREETING = "Hi!";
        public static Singleton Instance
        {
            get
            {
                Logger.Log("Instance called.");
                return Nested._instance;
            }
        }

        private class Nested
        {
            // Tell C# compiler not to mark type as beforefieldinit (https://csharpindepth.com/articles/BeforeFieldInit)
            static Nested()
            {
            }
            internal static readonly Singleton _instance = new Singleton();
        }

        private Singleton()
        {
            // cannot be created except within this class
            Logger.Log("Constructor invoked.");
        }
    }
}
