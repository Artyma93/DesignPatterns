﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    class Composite : AbstractComponent
    {
        ArrayList nodes = new ArrayList();

        public Composite(string name) : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(name);

            foreach(AbstractComponent component in nodes)
            {
                component.Operation();
            }
        }

        public override void Add(AbstractComponent component)
        {
            nodes.Add(component);
        }

        public override void Remove(AbstractComponent component)
        {
            nodes.Remove(component);
        }

        public override AbstractComponent GetChild(int index)
        {
            return nodes[index] as AbstractComponent;
        }
    }
}
