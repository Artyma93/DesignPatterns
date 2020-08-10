using _00_CurrentTrainingDesignPattern.Pattern;
using System;

namespace _00_CurrentTrainingDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            singleton1.SingletonOperation();

            string singletonData = singleton1.GetSingletonData();

            Console.WriteLine(singletonData);

        }
    }
}
