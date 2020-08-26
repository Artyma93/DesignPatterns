using System;
using System.Collections.Generic;
using System.Text;

namespace _11_FlyweightDesignPattern.Pattern
{
    class ConcreteFlyweight : Flyweight
    {
        private string intrinsicState = "ConcreteFlyweight ";
        private ConsoleColor extrinsicState;
        public override void Operation(ConsoleColor extrinsicState)
        {
            this.extrinsicState = extrinsicState;
            Console.ForegroundColor = this.extrinsicState;
            Console.WriteLine(intrinsicState + GetHashCode());
        }
    }
}
