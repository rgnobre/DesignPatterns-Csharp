using Demo_4___Static_Constructors_and_Singleton.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4___Static_Constructors_and_Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        //reading this will initialize the _instance
        public static readonly string GREETING = "Hi!";
        //Tell C# compiler not mark type as beforefieldinit
        //(https://csharpindepth.com/articles/beforefieldinit)

        static Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                Logger.Log("Instance called");
                return _instance;
            }
        }

        private Singleton()
        {
            // cannot be created except within this class
            Logger.Log("Constructor invoked.");
        }
    }
}
