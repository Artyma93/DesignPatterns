using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    class Leaf : AbstractComponent
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(name);
        }

        public override void Add(AbstractComponent component)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(AbstractComponent component)
        {
            throw new InvalidOperationException();
        }

        public override AbstractComponent GetChild(int index)
        {
            throw new InvalidOperationException();
        }
    }
}
