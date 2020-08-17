using _08_CompositeDesignPattern.Pattern;
using System;
using System.ComponentModel;

namespace _08_CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractComponent root = new Composite("root");
            AbstractComponent branch1 = new Composite("BR1");
            AbstractComponent branch2 = new Composite("BR2");
            AbstractComponent leaf1 = new Leaf("L1");
            AbstractComponent leaf2 = new Leaf("L2");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);

            root.Operation();

            branch2.GetChild(0).Operation();
        }
    }
}
