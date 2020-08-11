using _05_SingletonDesignPattern.Pattern;
using System;

namespace _05_SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Initial();
            Singleton singleton2 = Singleton.Initial();

            singleton1.SingletonDataOperation();

            string singletonData = singleton1.GetSingletonData();

            Console.WriteLine(singletonData);
        }
    }
}
