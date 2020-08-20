using System;
using System.Collections.Generic;
using System.Text;

namespace _09_DecoratorDesignPattern.Pattern.Components
{
    class ConcreteComponent : AbstractComponent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation");
        }
    }
}
