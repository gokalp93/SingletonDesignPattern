using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern.Naive
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private Singleton() => Console.WriteLine("Constructor invoked");

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Instance called");
                if (_instance is null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
