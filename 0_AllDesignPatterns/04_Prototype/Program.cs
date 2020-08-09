using _04_Prototype.Pattern;
using System;

namespace _04_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPrototype prototype = null;
            AbstractPrototype clone = null;

            prototype = new ConcretePrototype1(1);
            clone = prototype.Clone();

            Console.WriteLine(clone + " clone.Id:" + clone.Id);

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();

            Console.WriteLine(clone + " clone.Id:" + clone.Id);
        }
    }
}
