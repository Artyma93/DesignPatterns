using _03_FactoryMethodDesignPattern.Pattern.Creators;
using _03_FactoryMethodDesignPattern.Pattern.Products;
using System;

namespace _03_FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new ConcreteCreator();
            Product product = creator.FactoryMethod();

            creator.AnOperation();

            Console.WriteLine(product);
        }
    }
}
