using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CompositeDesignPattern.Pattern
{
    abstract class AbstractComponent
    {
        protected string name;
        public AbstractComponent(string name)
        {
            this.name = name;
        }

        public abstract void Operation();
        public abstract void Add(AbstractComponent component);
        public abstract void Remove(AbstractComponent component);
        public abstract AbstractComponent GetChild(int index);

    }
}
