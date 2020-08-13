using _00_CurrentTrainingDesignPattern.Pattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern.Abstraction
{
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(AbstractImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            // ...
            base.Operation();
            // ...
        }
    }
}
