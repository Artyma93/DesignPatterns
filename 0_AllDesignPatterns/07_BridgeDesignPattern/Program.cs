using _07_BridgeDesignPattern.Pattern.Abstraction;
using _07_BridgeDesignPattern.Pattern.Implementor;
using System;

namespace _07_BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractionImplementor implementor;
            Abstraction abstraction;

            implementor = new ConcreteImplementorA();
            abstraction = new RefinedAbstraction(implementor);
            abstraction.Operation();

            implementor = new ConcreteImplementorB();
            abstraction = new RefinedAbstraction(implementor);
            abstraction.Operation();
        }
    }
}
