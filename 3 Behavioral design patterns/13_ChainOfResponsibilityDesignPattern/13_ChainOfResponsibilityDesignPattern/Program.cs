using _13_ChainOfResponsibilityDesignPattern.Pattern;
using System;
using System.Reflection.Metadata;

namespace _13_ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();

            handler1.Successor = handler2;

            handler1.HandleRequest(1);
            handler2.HandleRequest(2);
        }
    }
}
