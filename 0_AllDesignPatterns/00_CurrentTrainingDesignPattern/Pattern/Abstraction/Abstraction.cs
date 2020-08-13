using _00_CurrentTrainingDesignPattern.Pattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern.Abstraction
{
    abstract class Abstraction
    {
        AbstractImplementor implementor;
        public Abstraction(AbstractImplementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
