using _02_BuilderDesignPattern.HouseElement;
using _02_BuilderDesignPattern.Pattern;
using _02_BuilderDesignPattern.Pattern.PatternElementBuilder;
using System;

namespace _02_BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();

            Director director = new Director(builder);

            director.Construct();

            House house = builder.CreateHouse();

            Console.WriteLine(house);
        }
    }
}
