using _05_SingletonDesignPattern.Pattern;
using System;

namespace _05_SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            instance1.SingletonOperation();

            string singletonData = instance1.GetSingletonData();

            Console.WriteLine(singletonData);
        }
    }
}
