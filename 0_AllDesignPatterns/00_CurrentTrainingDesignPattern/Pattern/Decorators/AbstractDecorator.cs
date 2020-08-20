using _00_CurrentTrainingDesignPattern.Pattern.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern.Decorators
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
