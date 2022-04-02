
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1___Naive
{
#nullable enable
    public sealed class Singleton
    {
        private static Singleton? _instance;

        public static Singleton Instance
        {
            get
            {
                Logger.Log("Instance called.");
                return _instance ??= new Singleton();
            }
        }

        private Singleton()
        {
            // cannot be created except within this class
            Logger.Log("Constructor invoked.");
        }
    }
}
