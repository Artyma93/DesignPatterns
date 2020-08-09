using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Prototype.Pattern
{
    class ConcretePrototype2 : AbstractPrototype
    {
        public ConcretePrototype2(int Id) : base(Id)
        {
        }

        public override AbstractPrototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}
