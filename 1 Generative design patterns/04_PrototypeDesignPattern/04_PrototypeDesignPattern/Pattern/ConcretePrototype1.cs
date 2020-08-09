using System;
using System.Collections.Generic;
using System.Text;

namespace _04_PrototypeDesignPattern.Pattern
{
    class ConcretePrototype1 : AbstractPrototype
    {
        public ConcretePrototype1(int Id) : base(Id)
        {
        }

        public override AbstractPrototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
}
