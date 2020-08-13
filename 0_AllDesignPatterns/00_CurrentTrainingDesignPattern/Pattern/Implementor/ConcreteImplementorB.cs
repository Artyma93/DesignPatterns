using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern.Implementor
{
    class ConcreteImplementorB : AbstractImplementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB");
        }
    }
}
