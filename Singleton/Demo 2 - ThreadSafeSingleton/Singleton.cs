using Demo_2___ThreadSafeSingleton.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2___ThreadSafeSingleton
{
    public sealed class Singleton
    {
        private static Singleton _instace = null;
        private static readonly object _lock = new object();

        public static Singleton Instance
        {
            get
            { 
                Logger.Log("Instance called.");
                lock (_lock) //this lock is used om every reference to Singleton
                {
                    if(_instace == null)
                    {
                        _instace = new Singleton();
                    }
                    return _instace;
                }
            }
        }

        private Singleton()
        {
            // cannot be created except within this class
            Logger.Log("Constructor invoked.");
        }
    }
}
