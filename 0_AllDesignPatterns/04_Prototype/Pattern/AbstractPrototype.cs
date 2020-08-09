using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Prototype.Pattern
{
    abstract class AbstractPrototype
    {
        public AbstractPrototype(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }

        public abstract AbstractPrototype Clone();
    }
}
