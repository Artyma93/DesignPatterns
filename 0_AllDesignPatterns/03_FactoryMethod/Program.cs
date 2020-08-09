using _03_FactoryMethod.Pattern.Creator;
using _03_FactoryMethod.Pattern.Product;
using System;

namespace _03_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCreator creator = new ConcreteCreator();
            AbstractProduct product = creator.FactoryMethod();

            creator.AnOperation();

            Console.WriteLine(product);
        }
    }
}
