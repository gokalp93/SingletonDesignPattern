using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern.Lazy
{
    public sealed class Singleton
    {
        public static readonly Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());
        private Singleton() => Console.WriteLine("Constructor invoked");

        public static Singleton Instance
        {
            get
            {
               Console.WriteLine("Instance called");
               return _lazy.Value;
            }
        }
    }
}
