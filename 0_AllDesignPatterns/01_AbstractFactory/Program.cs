using _01_AbstractFactory.Pattern;
using _01_AbstractFactory.Pattern.Factory;
using System;

namespace _01_AbstractFactory
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
