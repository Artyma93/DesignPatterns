
using _00_CurrentTrainingDesignPattern.Pattern;
using System;

namespace _00_CurrentTrainingDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyweight[] flyweights = new Flyweight[100];
            FlyweightFactory factory = new FlyweightFactory();

            for (int i = 0; i < flyweights.Length; i++)
            {
                flyweights[i] = factory.GetConcreteFlyweight("1");
                flyweights[i].Operation(ConsoleColor.Yellow);
            }

            for (int i = 0; i < flyweights.Length; i++)
            {
                flyweights[i] = factory.GetUnsharedConcreteFlyweight();
                flyweights[i].Operation(ConsoleColor.Green);
            }
        }
    }
}
