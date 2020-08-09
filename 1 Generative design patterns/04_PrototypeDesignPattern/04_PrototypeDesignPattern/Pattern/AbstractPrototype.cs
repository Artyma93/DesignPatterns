using System;
using System.Collections.Generic;
using System.Text;

namespace _04_PrototypeDesignPattern.Pattern
{
    abstract class AbstractPrototype
    {
        public AbstractPrototype(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; private set; }

        public abstract AbstractPrototype Clone();
    }
}
