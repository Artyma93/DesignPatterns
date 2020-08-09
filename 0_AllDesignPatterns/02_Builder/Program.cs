using _02_Builder.HouseElement;
using _02_Builder.Pattern;
using _02_Builder.Pattern.Builder;
using System;

namespace _02_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);

            director.Construct();

            House house = builder.CreateHouse();

            Console.WriteLine(house);
        }
    }
}
