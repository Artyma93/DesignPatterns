using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        private string allState = "UnsharedConcreteFlyweight ";
        public override void Operation(ConsoleColor extrinsicState)
        {
            Console.ForegroundColor = extrinsicState;
            Console.WriteLine(allState + GetHashCode());
        }
    }
}
