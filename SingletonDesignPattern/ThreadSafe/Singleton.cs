using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern.ThreadSafe
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object padlock = new object();
        private Singleton() => Console.WriteLine("Constructor invoked");

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                if (_instance is null)
                {
                    lock (padlock)
                    {
                        if (_instance is null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

    }
}
