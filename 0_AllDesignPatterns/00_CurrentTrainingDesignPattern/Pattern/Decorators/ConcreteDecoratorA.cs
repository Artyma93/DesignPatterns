using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern.Decorators
{
    class ConcreteDecoratorA : AbstractDecorator
    {
        private string addedState = "Some state";

        public override void Operation()
        {
            base.Operation();

            Console.WriteLine(addedState);
        }
    }
}
