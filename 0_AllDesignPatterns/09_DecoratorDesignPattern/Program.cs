using _09_DecoratorDesignPattern.Pattern.Components;
using _09_DecoratorDesignPattern.Pattern.Decorators;
using System;

namespace _09_DecoratorDesignPattern
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
