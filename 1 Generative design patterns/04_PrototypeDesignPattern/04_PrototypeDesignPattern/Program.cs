using _04_PrototypeDesignPattern.Pattern;
using System;

namespace _04_PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPrototype prototype;
            AbstractPrototype clone;

            prototype = new ConcretePrototype1(1);
            clone = prototype.Clone();

            Console.WriteLine(clone + " clone.Id:" + clone.Id);

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();

            Console.WriteLine(clone + " clone.Id:" + clone.Id);
        }
    }
}
