
using _00_CurrentTrainingDesignPattern.Pattern.Abstraction;
using _00_CurrentTrainingDesignPattern.Pattern.Implementor;
using System;

namespace _00_CurrentTrainingDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractImplementor implementor;
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
