using _01_AbstractFactoryDesignPattern.Pattern;
using _01_AbstractFactoryDesignPattern.Pattern.Factory;
using System;

namespace _01_AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new PepsiColaFactory());
            client.Run();

            client = new Client(new CocaColaFactory());
            client.Run();
        }
    }
}
