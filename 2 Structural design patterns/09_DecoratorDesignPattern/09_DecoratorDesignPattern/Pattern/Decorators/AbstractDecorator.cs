using _09_DecoratorDesignPattern.Pattern.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09_DecoratorDesignPattern.Pattern.Decorators
{
    abstract class AbstractDecorator : AbstractComponent
    {
        public AbstractComponent Component { protected get; set; }

        public override void Operation()
        {
            if(Component != null)
            {
                Component.Operation();
            }
        }
    }
}
