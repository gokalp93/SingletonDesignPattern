using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var one = Naive.Singleton.Instance;
            //var two = Naive.Singleton.Instance;
            //var three = Naive.Singleton.Instance;

            //var one = ThreadSafe.Singleton.Instance;
            //var two = ThreadSafe.Singleton.Instance;
            //var three = ThreadSafe.Singleton.Instance;

            var one = Lazy.Singleton.Instance;
            var two = Lazy.Singleton.Instance;
            var three = Lazy.Singleton.Instance;
        }
    }
}
