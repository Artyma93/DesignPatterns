
using _00_CurrentTrainingDesignPattern.Pattern.Components;
using _00_CurrentTrainingDesignPattern.Pattern.Decorators;
using System;

namespace _00_CurrentTrainingDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractComponent component = new ConcreteComponent();
            AbstractDecorator decoratorA = new ConcreteDecoratorA();
            AbstractDecorator decoratorB = new ConcreteDecoratorB();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;

            decoratorB.Operation();
        }
    }
}
