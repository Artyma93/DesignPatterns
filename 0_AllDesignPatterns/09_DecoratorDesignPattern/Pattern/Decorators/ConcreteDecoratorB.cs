using System;
using System.Collections.Generic;
using System.Text;

namespace _09_DecoratorDesignPattern.Pattern.Decorators
{
    class ConcreteDecoratorB : AbstractDecorator
    {
        private void AddedBehavior()
        {
            Console.WriteLine("AddedBehavior");
        }

        public override void Operation()
        {
            base.Operation();

            AddedBehavior();
        }
    }
}
